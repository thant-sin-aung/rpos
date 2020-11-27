using Com.MrIT.DBEntities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.MrIT.DBEntities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public virtual DbSet<LoginLog> LoginLogs { get; set; }

        public virtual DbSet<ChangeLog> ChangeLogs { get; set; }

        public virtual DbSet<EmailTemplate> EmailTemplates { get; set; }

        public virtual DbSet<EmailLog> EmailLogs { get; set; }

        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }


        

        public virtual DbSet<MaterialCategory> MaterialCategories { get; set; }

        public virtual DbSet<MaterialItem> MaterialItems { get; set; }

        public virtual DbSet<MaterialUOM> MaterialUOMs { get; set; }

        public virtual DbSet<MenuCategory> MenuCategories { get; set; }

        public virtual DbSet<MenuItem> MenuItems { get; set; }

        public virtual DbSet<MenuItemMaterial> MenuItemMaterials { get; set; }

        public virtual DbSet<MenuItemPortion> MenuItemPortions { get; set; }

        public virtual DbSet<MenuType> MenuTypes { get; set; }

    }
}
