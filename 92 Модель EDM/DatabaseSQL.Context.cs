﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp39
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseSQLEntities : DbContext
    {
        public DatabaseSQLEntities()
            : base("name=DatabaseSQLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACC_TRANSACTION> ACC_TRANSACTION { get; set; }
        public virtual DbSet<ACCOUNT> ACCOUNT { get; set; }
        public virtual DbSet<BRANCH> BRANCH { get; set; }
        public virtual DbSet<BUSINESS> BUSINESS { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMER { get; set; }
        public virtual DbSet<DEPARTMENT> DEPARTMENT { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public virtual DbSet<INDIVIDUAL> INDIVIDUAL { get; set; }
        public virtual DbSet<OFFICER> OFFICER { get; set; }
        public virtual DbSet<PRODUCT> PRODUCT { get; set; }
        public virtual DbSet<PRODUCT_TYPE> PRODUCT_TYPE { get; set; }
    }
}
