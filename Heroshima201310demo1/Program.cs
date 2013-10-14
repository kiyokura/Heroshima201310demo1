using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlServerCe;

namespace Heroshima201310demo1
{
    class Program
    {
        static string constr = "Data Source=App_Data\\Database1.sdf";
        static void Main(string[] args)
        {

            // 全件出す
            //using (var cn = new SqlCeConnection(constr))
            //{
            //    cn.Open();
            //    var sql = "SELECT ID , Name , Age , Email FROM Employee";
            //    using (var cmd = new SqlCeCommand(sql, cn))
            //    {
            //        using (var dr = cmd.ExecuteReader())
            //        {
            //            while (dr.Read())
            //            {
            //                Console.Write("ID:{0} , Name:{1} , Age:{2} , Email:{3}",
            //                                dr["ID"],
            //                                dr["Name"],
            //                                dr["Age"],
            //                                dr["Email"]
            //                    );
            //                Console.Write("\n");
            //            }
            //        }
            //    }
            //}

            // パラメータをバインドする
            //using (var cn = new SqlCeConnection(constr))
            //{
            //    cn.Open();
            //    var sql = "SELECT ID , Name , Age , Email FROM Employee WHERE Age > @Age";
            //    using (var cmd = new SqlCeCommand(sql, cn))
            //    {
            //        var param = cmd.CreateParameter();
            //        param.ParameterName = "Age";
            //        param.SqlDbType = System.Data.SqlDbType.Int;
            //        param.Direction = System.Data.ParameterDirection.Input;
            //        param.Value = 25;

            //        cmd.Parameters.Add(param);


            //        using (var dr = cmd.ExecuteReader())
            //        {
            //            while (dr.Read())
            //            {
            //                Console.Write("ID:{0} , Name:{1} , Age:{2} , Email:{3}",
            //                                dr["ID"],
            //                                dr["Name"],
            //                                dr["Age"],
            //                                dr["Email"]
            //                    );
            //                Console.Write("\n");
            //            }
            //        }
            //    }
            //}


            // オブジェクトにマップして受け取る
            //var emp = new Employees();
            //var emloyees = emp.FindAll();
            //foreach (var e in emloyees)
            //{
            //    Console.Write("ID:{0} , Name:{1} , Age:{2} , Email:{3}",
            //                    e.ID,
            //                    e.Name,
            //                    e.Age,
            //                    e.Email
            //                 );
            //    Console.Write("\n");
            //}

            Console.ReadKey();
        }
    }
}
