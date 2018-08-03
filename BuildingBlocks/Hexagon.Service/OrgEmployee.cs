using Hexagon.Data.Repository;
using Hexagon.Entity;
using Hexagon.IService;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace Hexagon.Service
{
    public class OrgEmployee : RepositoryFactory<Organization_Employee>, IOrgEmployee
    {
        private string conString;
        public OrgEmployee(IConfiguration paramConfiguration)
        {
            if (paramConfiguration != null)
            {
                conString = paramConfiguration.GetConnectionString("OracleConnectionString");
            }
        }

        public List<Organization_Employee> GetEmployeeList()
        {
            string sql = "select * from Organization_Employee";
            //string conString = "User Id=cad93;Password=cad93;" +

            //    //How to connect to an Oracle DB without SQL*Net configuration file
            //    //  also known as tnsnames.ora.
            //    "Data Source=192.168.48.30:1521/cad93;";
            return BaseRepository(conString).FindList(sql).ToList();
        }
    }
}
