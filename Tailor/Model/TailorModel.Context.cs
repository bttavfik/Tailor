<<<<<<< HEAD
=======
﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tailor.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TailorEntities : DbContext
    {
        public TailorEntities()
            : base("name=TailorEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<BudgetAdjustment> BudgetAdjustments { get; set; }
        public virtual DbSet<Clothes> Clothes1 { get; set; }
        public virtual DbSet<ClothesDetail> ClothesDetails { get; set; }
        public virtual DbSet<ClothesKind> ClothesKinds { get; set; }
        public virtual DbSet<ClothesMaterial> ClothesMaterials { get; set; }
        public virtual DbSet<ClothesSize> ClothesSizes { get; set; }
        public virtual DbSet<ClothesStock> ClothesStocks { get; set; }
        public virtual DbSet<Expend> Expends { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<MaterialStock> MaterialStocks { get; set; }
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<StaffAttendance> StaffAttendances { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<StaffDeduction> StaffDeductions { get; set; }
        public virtual DbSet<StaffPermission> StaffPermissions { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
    }
}
>>>>>>> 2e77d8db63d376302573a0b3643949b309f66533
