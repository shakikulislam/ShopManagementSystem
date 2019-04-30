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
	}
}