using Com.MrIT.DBEntities;
using Com.MrIT.DBEntities.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Com.MrIT.DataRepository
{
    public class SysUserRepository : GenericRepository<SysUser> , ISysUserRepository
    {
        public SysUserRepository(DataContext context, ILoggerFactory loggerFactory) :
        base(context, loggerFactory, "SysUserRepository")
        {

        }

        public SysUser ValidateUser(int pin)
        {
            var record = this.entities.Where(e => e.SystemActive == true && e.PinCode == pin).FirstOrDefault();

            return record;
        }
    }
}
