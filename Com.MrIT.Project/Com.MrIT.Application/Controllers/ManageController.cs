using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using Com.MrIT.App.Filters;
using Com.MrIT.Common;
using Com.MrIT.Services;
using Com.MrIT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Com.MrIT.PublicSite.Controllers
{

    public class ManageController : Controller
    {
        private readonly IMenuCategoryService _svsMenuCategory;


        public ManageController(IMenuCategoryService svsMenuCategory)
        {
           this._svsMenuCategory = svsMenuCategory;
        }

        [MrITActionFilter]
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        
    }
}