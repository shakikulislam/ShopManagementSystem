using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace DAL.DAL
{
    public class CategoryDal
    {
        private static string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
        private static  SqlConnection _sqlConnection=new SqlConnection(_connectionString);
        private SqlCommand _sqlCommand=new SqlCommand("",_sqlConnection);

        private static SqlDataAdapter _sqlDataAdapter;
        private static DataTable _dataTable;
        
        //Insert Database
        public bool Insert(Category category)
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand.CommandText="INSERT INTO Category(Code,Name)VALUES('"+category.Code+"','"+category.Name+"')";
            var isExecute=_sqlCommand.ExecuteNonQuery();
            return isExecute > 0 ? true : false;
        }


        public DataTable CategoryList()
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand.CommandText = "SELECT *FORM Category";
            _sqlDataAdapter=new SqlDataAdapter(_sqlCommand);
            _dataTable=new DataTable();
            _sqlDataAdapter.Fill(_dataTable);
            return _dataTable;

        }



    }
}
