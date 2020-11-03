using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace DBO.Core.SqlServer.DB
{
    public  class BaseDbConfig
    {
        public static string _connectionString;

        public BaseDbConfig()
        {

        }


        public void Test()
        {
            _connectionString = "Data Source=.;Initial Catalog=GalaxyServicesDB;Integrated Security=True";

        }
    }
}
