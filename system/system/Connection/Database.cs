using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace system.Connection
{
    public sealed class Database
    {
        private static volatile SqlConnection instance;
        private static object syncRoot = new object();
        private static readonly string connectionString = Properties.Settings.Default.ecommerceConnectionString;

        private Database() { }

        public static SqlConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SqlConnection(connectionString);
                    }
                }

                return instance;
            }
        }
    }
}
