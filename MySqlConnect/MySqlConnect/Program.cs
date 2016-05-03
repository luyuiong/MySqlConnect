using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            string M_str_sqlcon = "server=localhost;user id=root;password=1;database=testMySql"; //根据自己的设置
            DbConnectionMySql dbMySql = new DbConnectionMySql(M_str_sqlcon);
            dbMySql.getmysqlcom("insert into runoob_tbl values(3, 'Learn C++', 'luyulong', NOW())");

            MySqlDataReader dataReader = dbMySql.getmysqlread("select * from runoob_tbl");

            // 判断数据是否读到尾. 
            while (dataReader.Read()) 
            { 
                Console.WriteLine(String.Format("{0}, {1}",
                dataReader[0], dataReader[1])); 
            } 
            // 一定要关闭 reader 对象. 
            dataReader.Close(); 
        }


    }


}
