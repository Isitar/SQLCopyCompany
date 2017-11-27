using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCopyCompany
{
    public class SQLColumn
    {
        public string Name { get; set; } = "";
        public string DataType { get; set; } = "";

        public override string ToString()
        {
            return Name;
        }
    }
}
