using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class DAO
    {
        protected SqlConnection sqlConnection;
        protected string table;
        protected User user;

        public DAO(string table, User user)
        {
            sqlConnection = new SqlConnection($@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = {AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 10) + "DatabaseProject.mdf"}; Integrated Security = True");
            this.table = table;
            this.user = user;
        }
    }
}
