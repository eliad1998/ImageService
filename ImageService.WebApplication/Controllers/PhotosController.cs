﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageService.WebApplication.Controllers
{
    public class PhotosController : Controller
    {
        // GET: Photos
        public ActionResult Photos()
        {
            return View();
        }
    }
}