using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySqlConnect
{
    /// <summary>
    /// MySql数据库连接类
    /// </summary>
    public class DbConnectionMySql
    {
        /// <summary>
        /// MySql数据库连接
        /// </summary>
        private MySqlConnection m_mySqlCon;

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="conStr">MySql数据库连接字符串</param>
        public DbConnectionMySql(string conStr)
        {
            m_mySqlCon = new MySqlConnection(conStr);
        }

        /// <summary>
        /// 执行MySqlCommand
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        public void getmysqlcom(string M_str_sqlstr)
        {
            m_mySqlCon.Open();
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, m_mySqlCon);
            mysqlcom.ExecuteNonQuery();
            mysqlcom.Dispose();
            m_mySqlCon.Close();
            m_mySqlCon.Dispose();
        }

        /// <summary>
        /// 创建一个MySqlDataReader对象
        /// </summary>
        /// <param name="M_str_sqlstr">SQL语句</param>
        /// <returns>返回MySqlDataReader对象</returns>
        public MySqlDataReader getmysqlread(string M_str_sqlstr)
        {
            MySqlCommand mysqlcom = new MySqlCommand(M_str_sqlstr, m_mySqlCon);
            m_mySqlCon.Open();
            MySqlDataReader mysqlread = mysqlcom.ExecuteReader(CommandBehavior.CloseConnection);
            mysqlcom.Dispose();
            m_mySqlCon.Close();
            return mysqlread;
        }
    }
}
