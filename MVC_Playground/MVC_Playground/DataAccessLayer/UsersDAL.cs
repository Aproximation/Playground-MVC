using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MVC_Playground.Models;

namespace MVC_Playground.DataAccessLayer
{
    class UsersDAL : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        //public UsersDAL():base("mvc"){};

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }
    }

}
