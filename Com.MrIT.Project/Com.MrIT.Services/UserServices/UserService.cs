using Com.MrIT.Common;
using Com.MrIT.Common.Configuration;
using Com.MrIT.DataRepository;
using Com.MrIT.DBEntities;
using Com.MrIT.DBEntities.Entities;
using Com.MrIT.ViewModels;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.MrIT.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly ISysUserRepository _repoUser;
        private readonly AppSettings _appSettings;
        public UserService(ISysUserRepository repoUser, IOptions<AppSettings> appSettings)
        {
            this._repoUser = repoUser;
            this._appSettings = appSettings.Value;
        }

        public VmSysUser ValidateUser(int pin)
        {
            var result = new VmSysUser();

            //validate user
            var dbResult = _repoUser.ValidateUser(pin);

            //not found
            if(dbResult == null) 
            {
                return null;
            }

            Copy<SysUser, VmSysUser>(dbResult, result);
            result.EncryptId = Md5.Encrypt(result.ID.ToString());

            return result;
        }


    }
}
