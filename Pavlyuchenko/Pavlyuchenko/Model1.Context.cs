﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pavlyuchenko
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ПавлюченкоEntities : DbContext
    {
        private static ПавлюченкоEntities павлюченкоEntities = null;

        public static ПавлюченкоEntities Get()
        {
            if (павлюченкоEntities == null)
                павлюченкоEntities = new ПавлюченкоEntities();
            return павлюченкоEntities;
        }

        public ПавлюченкоEntities()
            : base("name=ПавлюченкоEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<Маршруты> Маршруты { get; set; }
        public virtual DbSet<Пользователи> Пользователи { get; set; }
        public virtual DbSet<Посылки> Посылки { get; set; }
        public virtual DbSet<Роли> Роли { get; set; }
        public virtual DbSet<Транспорты> Транспорты { get; set; }
    }
}