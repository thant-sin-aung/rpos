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

    public class UsersController : Controller
    {
        private readonly IUserService _svsUser;


        public UsersController(IUserService svsUser)
        {
           this._svsUser = svsUser;
        }

        [MrITActionFilter]
        [HttpGet]
        public IActionResult SignIn()
        {

            return View();
        }

        [HttpPost]
        public IActionResult SignIn(VmSysUser user)
        {
            var result = _svsUser.ValidateUser(user.PinCode);

            if(result == null)
            {
                TempData["MessageToUser"] = "Pin code is invalid!";
                return View();
            }

            if(result.Active == false)
            {
                TempData["MessageToUser"] = "Account is disabled.";
                return View();
            }

            HttpContext.Session.SetString("FullName", result.FullName.ToString());
            HttpContext.Session.SetString("UserRole", result.Role.ToString());
            HttpContext.Session.SetString("UserID", result.ID.ToString());

            return RedirectToAction("Index","Home");
        }
    }
}