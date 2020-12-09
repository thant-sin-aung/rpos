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

                return result;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.MessageToUser = "Error while creating data. Please log a ticket at Web helpdesk."; //ex.Message;

                return result;
            }
        }
    }
}