using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlServerCe;

namespace Heroshima201310demo1
{
    public class Employees
    {
        static string constr = "Data Source=App_Data\\Database1.sdf";

        public IList<EmployeeEntity> FindAll()
        {
            using (var cn = new SqlCeConnection(constr))
            {
                cn.Open();
                var sql = "SELECT ID , Name , Age , Email FROM Employee";
                using (var cmd = new SqlCeCommand(sql, cn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        var result = new List<EmployeeEntity>();
                        while (dr.Read())
                        {
                            var rec = new EmployeeEntity()
                            {
                                ID = (int)dr["ID"],
                                Name = (string)dr["Name"],
                                Age = (int)dr["Age"],
                                Email = (string)dr["Email"],
                            };
                            result.Add(rec);
                        }
                        return result;
                    }
                }
            }
        }
    }
}
