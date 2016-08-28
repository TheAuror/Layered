using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using LayeredSolution.DataLayer.Schema;

namespace LayeredSolution.DataLayer
{
    public class SampleContext : DbContext, ISampleContext
    {
        public SampleContext():this("Webshop")
        {

        }
        public SampleContext(string connectionString) 
            : base(connectionString)
        {
            
        }

        public IDbSet<Product> Products => Set<Product>();

        public IDbSet<Order> Orders => Set<Order>();

        public IDbSet<OrderItem> OrderItems => Set<OrderItem>();

        public IDbSet<EmployeeEntity> Employees => Set<EmployeeEntity>();

        public IDbSet<Warehouse> Warehouses => Set<Warehouse>();
        /* New Schema
         * New IDbSet in SampleContext and ISampleContext
         * Add-Migration dsfdsfd
         *  Name: nameof(New Schema)
         * Update-Database
         */ 
    }
}