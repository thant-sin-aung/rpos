using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Com.MrIT.DBEntities.Entities
{
    [Table("sys_user")]
    public class SysUser:GenericEntity
    {
        public string FullName { get; set; }
        public int PinCode { get; set; }
        public string Role { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }
}
