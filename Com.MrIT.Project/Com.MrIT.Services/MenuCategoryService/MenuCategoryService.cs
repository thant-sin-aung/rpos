using Com.MrIT.Common;
using Com.MrIT.Common.Configuration;
using Com.MrIT.DataRepository;
using Com.MrIT.DBEntities.Entities;
using Com.MrIT.ViewModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.Services
{
    public class MenuCategoryService : BaseService, IMenuCategoryService
    {
        private readonly IMenuCategoryRepository _repoMenuCategory;
        private readonly AppSettings _appSettings;

        public MenuCategoryService(IMenuCategoryRepository repoMenuCategory, IOptions<AppSettings> appSettings)
        {
            this._repoMenuCategory = repoMenuCategory;
            this._appSettings = appSettings.Value;
        }
        public VmGenericServiceResult CreateMenuCategory(VmMenuCategory menuCategory)
        {
            var result = new VmGenericServiceResult();
            try
            {
                var dbMenuCategory = new MenuCategory();
                Copy<VmMenuCategory, MenuCategory>(menuCategory, dbMenuCategory);
                var dbresult = _repoMenuCategory.Add(dbMenuCategory);

                result.IsSuccess = true;
                result.MessageToUser = "Success";
                result.RequestId = dbresult.ID.ToString();

            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.MessageToUser = "Error while creating data. Please log a ticket at Web helpdesk."; //ex.Message;

            }
            return result;
        }

        public VmGenericServiceResult UpdateMenuCategory(VmMenuCategory menuCategory)
        {
            var result = new VmGenericServiceResult();
            try
            {

                var dbMenuCategory = new MenuCategory();
                Copy<VmMenuCategory, MenuCategory>(menuCategory, dbMenuCategory);
                var dbResult = _repoMenuCategory.Update(dbMenuCategory);

                result.IsSuccess = true;
                result.MessageToUser = "Success";
                result.RequestId = dbResult.ID.ToString();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.MessageToUser = "Error while updating data. Please log a ticket at Web helpdesk.";//ex.message
            }
            return result;

        }

        public VmGenericServiceResult DeleteMenuCategory(int id)
        {
            var result = new VmGenericServiceResult();
            try
            {
                var dbmenuCategory = _repoMenuCategory.GetWithoutAsync(id);
                if (dbmenuCategory == null)
                {
                    result.IsSuccess = false;
                    result.MessageToUser = "No data.";
                    return result;
                }
                dbmenuCategory.Active = false;
                var dbResult = _repoMenuCategory.Update(dbmenuCategory);
                result.RequestId = dbResult.ID.ToString();
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.MessageToUser = "Error while updating data. Please log a ticket at Web helpdesk."; //ex.message;
            }
            return result;
        }

        public List<VmMenuCategory> GetAllMenuCategories()
        {
            var result = new List<VmMenuCategory>();

            var dbMenuCategoryList = _repoMenuCategory.GetActiveAll();

            foreach (var dbMenuCategory in dbMenuCategoryList)
            {
                var resultItem = new VmMenuCategory();
                Copy<MenuCategory, VmMenuCategory>(dbMenuCategory, resultItem);
                resultItem.EncryptId = Md5.Encrypt(resultItem.ID.ToString());

                result.Add(resultItem);
            }
            return result;
        }

        public VmMenuCategory GetMenuCategory(int id)
        {
            var dbMenuCategory = _repoMenuCategory.GetMenuCategory(id);
            if(dbMenuCategory == null)
            {
                return null;
            }

            var result = new VmMenuCategory();
            Copy<MenuCategory, VmMenuCategory>(dbMenuCategory, result);
            result.EncryptId = Md5.Encrypt(result.ID.ToString());

            return result;
        }
    }
}