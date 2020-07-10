using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using MySql.Data.EntityFrameworkCore.Extensions;
using DAL;
using BOL;

namespace DAL
{
    public class LibraryContext:DbContext
    {
        //providing property for Product dbset 
        //DbSet is the name of table mapping to the class Object
        public DbSet<Product> Products { get; set;}

        //overriding onconfiguring and onModelCreating methods of Dbcontext

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DbContextOptions-->creates instances of DbCOntextOptions Class
            /*Provides a simple API surface for configuring DbContextOptions.
             Databases (and other extensions) typically define extension methods
              on this object that allow you to configure the database connection
               (and other options) to be used for a context.
            */
            //this methods has connection string so
            string conString = "server= localhost; database = ecommerce; user = root; password = root123";
           //UseMysql() is an extension of optionsBuilder object class
            optionsBuilder.UseMySQL(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //using Entity it will add the model isf not already added in entity framework
            /*Returns an object that can be used to configure a given entity type in the model. 
            If the entity type is not already part of the model, it will be added to the model.
            */
            modelBuilder.Entity<Product>(entity => 
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired();
                entity.Property(e => e.UnitPrice).IsRequired();
                entity.Property(e => e.Quantity).IsRequired();
            });
        }
    }
}