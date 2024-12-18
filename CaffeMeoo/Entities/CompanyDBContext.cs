using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CaffeMeoo.Model;

namespace CaffeMeoo.Entities
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext():base("MyConnectionString") { }
        public DbSet<Bills> Bills { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Cat> Cat { get; set; } 
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MasterUser> MasterUsers { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkShift> WorkShifts { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<TakeUserName> TakeUserName { get; set; }
    }


}
