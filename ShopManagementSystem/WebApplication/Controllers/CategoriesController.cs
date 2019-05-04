using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.BLL;
using Models.Models;

namespace WebApplication.Controllers
{
    public class CategoriesController : Controller
    {
        private CategoryBll _category = new CategoryBll();

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(Category category)
        {
            try
            {
                var isSuccess = _category.Insert(category);
                return isSuccess ? ViewBag.SMsg = "Category Successfully Added." : ViewBag.FMsg = "Faild...";
            }
            catch (Exception exception)
            {
                ViewBag.FMsg = exception.Message;
            }
            return View();
        }


        public ActionResult ShowAll()
        {
            List<Category> categoryList = null;
            try
            {
                categoryList = _category.CategoryList();


            }
            catch (Exception exception)
            {
                ViewBag.FSmg = exception.Message;
            }
            return View(categoryList);
        }

        //public ActionResult ShowAll()
        //{
            
        //    //try
        //    //{

        //        return View(GetAllCategories());


        //    //}
        //    //catch (Exception exception)
        //    //{
        //    //    ViewBag.FSmg = exception.Message;
        //    //}

        //}

        //IEnumerable<Category> GetAllCategories()
        //{
        //    List<Category> categoriesList = _category.CategoryList();
        //    return categoriesList;
        //}

    }
}