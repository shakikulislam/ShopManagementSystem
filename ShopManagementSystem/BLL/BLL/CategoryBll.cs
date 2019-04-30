using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAL;
using Models.Models;

namespace BLL.BLL
{
    public class CategoryBll
    {
        private CategoryDal _category=new CategoryDal();
        public bool Insert(Category category)
        {
            try
            {
                return _category.Insert(category);
            }
            catch (Exception exception)
            {
                throw new Exception("Insert Faild...\nPlease try again.");
            }
        }
    }
}
