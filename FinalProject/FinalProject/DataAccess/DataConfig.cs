using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject.DataAccess
{
    public class DataConfig
    {
        // doi tuong dung de ket noi
        private SqlConnection sqlConnection;
        // doi tuong thuc hien cac cau lenh them sua xoa
        private SqlCommand sqlCommand;
        //doi tuong dung de lay du lieu table tu cac cau lenh truy van
        private SqlDataAdapter sqlAdapter;
        //doi tuong table dung de chua du lieu
        private DataTable dtTable;
        //chuoi ket noi
        public string connectionString = @"Data Source=.;Initial Catalog=FinalProject;Integrated Security=True";

        public DataConfig()
        {
            CheckConnect();
        }
        // thuc tuc nay ket noi csdl sql
        public void CheckConnect()
        {
            // thu tuc nay thuc hien khoi tao doi tuong sqlconnection de cac phuong thuc sau su dung doi tuong nay!
            // thuc hien kiem tra ket noi den csdl sql
            string strConnect = connectionString;
            // khoi tao moi doi tuong sqlconnection
            sqlConnection = new SqlConnection(strConnect);
            // mo ket noi
            sqlConnection.Open();
            //kiem tra trang thai ket noi, neu dang mo thi dong ket noi
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        //thu tuc lay du lieu dang bang (data table) tu cau lenh truy van
        public DataTable GetDataTable(string strCode)
        {
            dtTable = new DataTable();
            // khoi tao doi tuong data adapter
            sqlAdapter = new SqlDataAdapter(strCode, sqlConnection);
            // do du lieu vao doi tuong dtTable.
            sqlAdapter.Fill(dtTable);
            return dtTable;
        }

        //ham thuc thi cac cau lenh them sua xoa
        public int executeNoneQuery(string strCode)
        {       
            int result = 0;
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strCode;
            result = sqlCommand.ExecuteNonQuery();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            return result;
        }

        // ham thuc thi cac cau lenh tra ve 1 gia tri
        public object excuteScalarQuery(string strCode)
        {
            object result = 0;
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = strCode;
            result = sqlCommand.ExecuteScalar();
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            return result;
        }
    }
}
