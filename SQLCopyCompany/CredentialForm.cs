using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLCopyCompany
{
    public partial class CredentialForm : Form
    {
        SQLCredentials initialCredentials;
        public CredentialForm(SQLCredentials initialCredentials)
        {
            InitializeComponent();
            this.initialCredentials = initialCredentials;

            txtPassword.Text = (string)initialCredentials.Password.Clone();
            txtUsername.Text = (string)initialCredentials.Username.Clone();

            cmdOK.Click += CmdOK_Click;
            cmdCancel.Click += CmdCancel_Click;

            this.AcceptButton = cmdOK;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            initialCredentials.Username = txtUsername.Text;
            initialCredentials.Password = txtPassword.Text;
            Close();
        }
    }
}
