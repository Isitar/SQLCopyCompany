using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLCopyCompany
{
    public class SQLCredentials
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public SQLCredentials()
        {
            Username = string.Empty;
            Password = string.Empty;
        }
    }
}
