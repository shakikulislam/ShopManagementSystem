﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}