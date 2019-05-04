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

        private static SqlDataReader _sqlDataReader;
        //private static SqlDataAdapter _sqlDataAdapter;
        //private static DataTable _dataTable;

        
        //Insert Database
        public bool Insert(Category category)
        {
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand.CommandText="INSERT INTO Category(Code,Name)VALUES('"+category.Code+"','"+category.Name+"')";
            var isExecute=_sqlCommand.ExecuteNonQuery();
            return isExecute > 0 ? true : false;
        }


        //Show All Categories
        public List<Category> CategoryList()
        {
            List<Category> categories=new List<Category>();
            
            _sqlConnection.Close();
            _sqlConnection.Open();
            _sqlCommand.CommandText = "SELECT *FROM Category";
            _sqlDataReader = _sqlCommand.ExecuteReader();
            var index = 1;
            while (_sqlDataReader.Read())
            {
                var aCategory = new Category();
                aCategory.Code = _sqlDataReader["Code"].ToString();
                aCategory.Name = _sqlDataReader["Name"].ToString();

                categories.Add(aCategory);
                index++;
            }

            return categories;

        }



    }
}
