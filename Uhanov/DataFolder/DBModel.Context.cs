﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Uhanov.DataFolder
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adress> Adress { get; set; }
        public virtual DbSet<AreaOfKnowledge> AreaOfKnowledge { get; set; }
        public virtual DbSet<Author> Author { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<BookAreaOfKnowledge> BookAreaOfKnowledge { get; set; }
        public virtual DbSet<BookAuthor> BookAuthor { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Instance> Instance { get; set; }
        public virtual DbSet<PublishingHouse> PublishingHouse { get; set; }
        public virtual DbSet<Reader> Reader { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<UsageBooks> UsageBooks { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}