using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCopyCompany
{
    public static class MiscExtensions
    {
        // Ex: collection.TakeLast(5);
        public static IEnumerable<T> TakeLast<T>(this IEnumerable<T> source, int N)
        {
            return source.Skip(Math.Max(0, source.Count() - N));
        }
    }
    public partial class frmMain : Form
    {

        private SQLCredentials sourceCredentials = new SQLCredentials();
        private SQLCredentials targetCredentials = new SQLCredentials();

        private SqlConnection sourceConnection;
        private SqlConnection targetConnection;

        //private List<string> log = new List<string>();
        private string logString = "";
        public frmMain()
        {
            InitializeComponent();

            chkSourceUseWinAuth.CheckedChanged += ChkSourceUseWinAuth_CheckedChanged;
            chkTargetUseWinAuth.CheckedChanged += ChkTargetUseWinAuth_CheckedChanged;

            cmdSourceConnect.Click += CmdSourceConnect_Click;
            cmdTargetConnect.Click += CmdTargetConnect_Click;

            cmdTestSetup.Click += CmdTestSetup_Click;
            cmdShowLog.Click += CmdShowLog_Click;
            cmdGo.Click += CmdGo_Click;
        }

        private void CmdShowLog_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(string.Join(Environment.NewLine, log.TakeLast(2)));
            MessageBox.Show(logString);
        }

        private void CmdTestSetup_Click(object sender, EventArgs e)
        {
            if (sourceConnection.State == ConnectionState.Closed)
            {
                CmdSourceConnect_Click(cmdSourceConnect, EventArgs.Empty);
            }
            if (targetConnection.State == ConnectionState.Closed)
            {
                CmdTargetConnect_Click(cmdTargetConnect, EventArgs.Empty);
            }
            var sourceCompany = cmbSourceCompanies.Text;
            var targetCompany = cmbTargetCompanies.Text;
            var sourceTables = TablesFromCompany(sourceConnection, sourceCompany);
            var targetTables = TablesFromCompany(targetConnection, targetCompany);

            var intersection = sourceTables.Intersect(targetTables);


            //MessageBox.Show($"Source Tables: {sourceTables.Count()}{Environment.NewLine}Target Tables: {targetTables.Count()}{Environment.NewLine}Intersection: {intersection.Count()}");

            var sourceTableColumns = new Dictionary<string, IEnumerable<string>>();
            foreach (var sourceTable in sourceTables)
            {
                sourceTableColumns.Add(sourceTable, ColumnsFromTable(sourceConnection, $"{sourceCompany}${sourceTable}").Select(x => x.Name));
            }

            var targetTableColumns = new Dictionary<string, IEnumerable<string>>();
            foreach (var targetTable in targetTables)
            {
                targetTableColumns.Add(targetTable, ColumnsFromTable(targetConnection, $"{targetCompany}${targetTable}").Select(x => x.Name));
            }



            var outputSourceTableColumns = sourceTableColumns.Select(s => OutputStrings(s)).SelectMany(x => x);
            var outputTargetTableColumns = targetTableColumns.Select(s => OutputStrings(s)).SelectMany(x => x);
            var intersectionColumns = outputSourceTableColumns.Intersect(outputTargetTableColumns);


            MessageBox.Show($"Source Tables: {sourceTables.Count()}{Environment.NewLine}Target Tables: {targetTables.Count()}{Environment.NewLine}Intersection: {intersection.Count()}{Environment.NewLine}" +
                $"Source Table Columns: {outputSourceTableColumns.Count()}{Environment.NewLine}" +
                $"Target Table Columns: {outputTargetTableColumns.Count()}{Environment.NewLine}" +
                $"Intersection Table Columns: {intersectionColumns.Count()}{Environment.NewLine}"
                );

            lstInSourceNotInTarget.Items.Clear();
            lstInTargetNotInSource.Items.Clear();


            lstInSourceNotInTarget.Items.AddRange(outputSourceTableColumns.Except(intersectionColumns).ToArray());
            lstInTargetNotInSource.Items.AddRange(outputTargetTableColumns.Except(intersectionColumns).ToArray());

        }

        private IEnumerable<string> OutputStrings(KeyValuePair<string, IEnumerable<string>> kvp)
        {
            var output = new List<string>();
            foreach (var value in kvp.Value)
            {
                output.Add(kvp.Key + ";" + value);
            }
            return output;
        }

        private void CmdGo_Click(object sender, EventArgs e)
        {
            var bgWorker = new BackgroundWorker();
            bgWorker.DoWork += Go;
            bgWorker.WorkerReportsProgress = true;

            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerAsync(new string[] { cmbSourceCompanies.Text, cmbTargetCompanies.Text });
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show(e.Error.Message + Environment.NewLine + e.Error.StackTrace);
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblProgressValue.Text = e.UserState.ToString() + " " + e.ProgressPercentage + "%";
        }

        private void Go(object sender, DoWorkEventArgs e)
        {
            var worker = (BackgroundWorker)sender;

            worker.ReportProgress(0, "Started");

            if (sourceConnection.State == ConnectionState.Closed)
            {
                CmdSourceConnect_Click(cmdSourceConnect, EventArgs.Empty);
            }
            if (targetConnection.State == ConnectionState.Closed)
            {
                CmdTargetConnect_Click(cmdTargetConnect, EventArgs.Empty);
            }


            var arguments = (string[])e.Argument;
            var sourceCompany = arguments[0];
            var targetCompany = arguments[1];
            var sourceTables = TablesFromCompany(sourceConnection, sourceCompany);
            var targetTables = TablesFromCompany(targetConnection, targetCompany);

            var intersectionTables = new Dictionary<string, IEnumerable<SQLColumn>>();
            foreach (var table in sourceTables.Intersect(targetTables))
            {
                intersectionTables.Add(table, ColumnsFromTable(sourceConnection, table, sourceCompany));
            }
            worker.ReportProgress(0, "Found intersection");

            int counter = 0;
            int cntTables = intersectionTables.Count;

            worker.ReportProgress(0, $"Started with sql, intersections: {cntTables}");
            foreach (var kvp in intersectionTables)
            {
                var progress = (int)(100 * ((double)counter / (double)cntTables));
                worker.ReportProgress(progress, $"{sourceCompany}${kvp.Key}");


                int c2 = 0;
                var insertSqls = new List<string>();
                var command = new SqlCommand($"SELECT [{string.Join("],[", kvp.Value)}] FROM [{sourceCompany}${kvp.Key}]", sourceConnection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        var insertSQL = $"INSERT INTO [{targetCompany}${kvp.Key}] ([{string.Join("],[", kvp.Value)}]) VALUES ";
                        var inserts = new List<string>();
                        while (reader.Read())
                        {
                            var vals = kvp.Value.ToList().Select(v => SqlValueString(reader[v.Name].ToString(), v.DataType));
                            inserts.Add($"({string.Join(",", vals)})");

                            c2++;
                            if (c2 % 1000 == 0)
                            {
                                worker.ReportProgress(progress, $"{sourceCompany}${kvp.Key} | still working {c2} |");
                                insertSQL += string.Join($",{Environment.NewLine}", inserts);
                                insertSqls.Add(insertSQL);
                                insertSQL = $"INSERT INTO [{targetCompany}${kvp.Key}] ([{string.Join("],[", kvp.Value)}]) VALUES ";
                                inserts.Clear();
                            }
                        }
                        if (c2 % 1000 != 0)
                        {
                            insertSQL += string.Join($",{Environment.NewLine}", inserts);
                            insertSqls.Add(insertSQL);
                        }
                    }
                }
                //log.Add(string.Join(Environment.NewLine, insertSqls));


                if (chkDeleteOldData.Checked)
                {
                    new SqlCommand($"DELETE FROM [{targetCompany}${kvp.Key}]", targetConnection) { CommandTimeout = 600 }.ExecuteNonQuery();
                }
                int c3 = 0;
                foreach (var insertSql in insertSqls)
                {
                    //log.Add(insertSql);
                    logString = insertSql;
                    worker.ReportProgress(progress, $"{sourceCompany}${kvp.Key} | still working {c3}/{c2} |");
                    new SqlCommand(insertSql, targetConnection) { CommandTimeout = 600 }.ExecuteNonQuery();
                    c3 += 1000;
                }
                counter++;
                worker.ReportProgress(progress, kvp.Key);

            }
            worker.ReportProgress(100, "Done");
        }

        private string SqlValueString(string value, string dataType)
        {
            switch (dataType)
            {
                case "image":
                case "varchar":
                case "datetime":
                    return $"'{value.Replace("'", "''")}'";

                case "int":

                case "timestamp":
                case "varbinary":
                case "uniqueidentifier":
                case "tinyint":
                case "bigint":
                    return $"{value}";
                case "decimal":
                    return $"{value.Replace(',', '.')}";
            }
            return "";
        }


        private IEnumerable<SQLColumn> ColumnsFromTable(SqlConnection conn, string tableName, string company = "")
        {
            if (!(conn.State == ConnectionState.Open))
            {
                throw new ArgumentException("Connection not open");
            }
            var columns = new List<SQLColumn>();
            var companyString = string.IsNullOrEmpty(company) ? string.Empty : company + "$";

            var command = new SqlCommand($"select COLUMN_NAME,DATA_TYPE from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = '{companyString}{tableName}' AND COLUMN_NAME != 'timestamp'", conn);
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        columns.Add(new SQLColumn { Name = reader.GetString(0), DataType = reader.GetString(1) });
                    }
                }
            }
            return columns;
        }
        private IEnumerable<string> TablesFromCompany(SqlConnection conn, string companyName)
        {

            if (!(conn.State == ConnectionState.Open))
            {
                throw new ArgumentException("Connection not open");
            }
            var tables = new List<string>();
            var command = new SqlCommand($"select SUBSTRING(TABLE_NAME,{companyName.Length + 2},9999) from INFORMATION_SCHEMA.TABLES where TABLE_NAME like '{companyName}$%' AND TABLE_TYPE	= 'BASE TABLE' order by [TABLE_NAME]", conn);
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        tables.Add(reader.GetString(0));
                    }
                }
            }
            return tables;
        }

        private void CmdTargetConnect_Click(object sender, EventArgs e)
        {
            ConnectAndFillCmb(txtTargetServer.Text, txtTargetDB.Text, chkTargetUseWinAuth.Checked, targetCredentials, out targetConnection, cmbTargetCompanies);
        }

        private void ConnectAndFillCmb(string server, string db, bool winAuth, SQLCredentials credentials, out SqlConnection conn, ComboBox cmb)
        {
            conn = new SqlConnection
            {
                ConnectionString = $"server={server};Database={db};",
            };
            if (winAuth)
            {
                conn.ConnectionString += $"Integrated Security=true;";
            }
            else
            {
                conn.ConnectionString += $"Password={credentials.Password};UID={credentials.Username}";
            }
            conn.Open();
            cmb.Items.Clear();
            foreach (var company in GetCompanies(conn))
            {
                cmb.Items.Add(company);
            }
        }

        private void CmdSourceConnect_Click(object sender, EventArgs e)
        {
            ConnectAndFillCmb(txtSourceServer.Text, txtSourceDB.Text, chkSourceUseWinAuth.Checked, sourceCredentials, out sourceConnection, cmbSourceCompanies);
        }

        private void ChkTargetUseWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkTargetUseWinAuth.Checked)
            {
                new CredentialForm(targetCredentials).ShowDialog();
            }
        }

        private void ChkSourceUseWinAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSourceUseWinAuth.Checked)
            {
                new CredentialForm(sourceCredentials).ShowDialog();
            }
        }


        private IEnumerable<string> GetCompanies(SqlConnection conn)
        {
            if (!(conn.State == ConnectionState.Open))
            {
                throw new ArgumentException("Connection not open");
            }
            var companies = new List<string>();
            var command = new SqlCommand("select Name from [Company]", conn);
            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        companies.Add(reader.GetString(0));
                    }
                }
            }
            return companies;
        }
    }
}



