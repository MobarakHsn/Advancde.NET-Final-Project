﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ERPEntities : DbContext
    {
        public ERPEntities()
            : base("name=ERPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Customer_emails> Customer_emails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Expens> Expenses { get; set; }
        public virtual DbSet<Finance_Activities> Finance_Activities { get; set; }
        public virtual DbSet<Finance_import_histories> Finance_import_histories { get; set; }
        public virtual DbSet<Finance_payment_histories> Finance_payment_histories { get; set; }
        public virtual DbSet<Hr_Activites> Hr_Activites { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Issue> Issues { get; set; }
        public virtual DbSet<Leave_requests> Leave_requests { get; set; }
        public virtual DbSet<Liability> Liabilities { get; set; }
        public virtual DbSet<Order_products> Order_products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Organizaton> Organizatons { get; set; }
        public virtual DbSet<ProductManager_Activities> ProductManager_Activities { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sales_Activities> Sales_Activities { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
    }
}
