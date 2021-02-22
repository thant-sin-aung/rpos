using System;
using Com.MrIT.Common;
using Com.MrIT.Services;
using Com.MrIT.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Com.MrIT.PublicSite.Controllers
{

    public class MenuController : Controller
    {
        private readonly IMenuCategoryService _svsMenuCategory;


        public MenuController(IMenuCategoryService svsMenuCategory)
        {
           this._svsMenuCategory = svsMenuCategory;
        }

        //[MrITActionFilter]
        [HttpGet]    
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Listing()
        {
            var result = _svsMenuCategory.GetAllMenuCategories();
            return View(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult Create(VmMenuCategory menuCategory)
        {
            menuCategory.CreatedBy = menuCategory.ModifiedBy = "System";
            var result = _svsMenuCategory.CreateMenuCategory(menuCategory);
            if (result.IsSuccess)
            {
                return RedirectToAction("Listing", "Menu");
            }
            else
            {
                return View(menuCategory);
            }
        }

        [HttpGet]
        public IActionResult Update(string a)
        {
            try
            {
                a = Md5.Decrypt(System.Web.HttpUtility.UrlDecode(a));
                int id = 0;
                int.TryParse(a, out id);
                var result = _svsMenuCategory.GetMenuCategory(id);
                if(result == null)
                {
                    return RedirectToAction("Listing", "Menu");
                }
                return View(result);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Listing", "Menu");
            }
        }

        [HttpPost]
        public IActionResult Update(VmMenuCategory menuCategory)
        {
            menuCategory.ModifiedBy = "System"; // Session ['LogOnUser']
            var result = _svsMenuCategory.UpdateMenuCategory(menuCategory);
            if (result.IsSuccess)
            {
                return RedirectToAction("Listing", "Menu");
            }
            else
            {
                return View(menuCategory);
            }
        }

        [HttpGet]
        public IActionResult Delete(string a)
        {
            try
            {
                a = Md5.Decrypt(System.Web.HttpUtility.UrlDecode(a));
                int id = 0;
                int.TryParse(a, out id);
                var result = _svsMenuCategory.DeleteMenuCategory(id);
                if(result == null)
                {
                    return RedirectToAction("Listing", "Menu");
                }
                return RedirectToAction("Listing", "Menu");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Listing", "Menu");
            }
        }
    }
}