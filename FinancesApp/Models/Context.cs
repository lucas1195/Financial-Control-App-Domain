using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp.Models
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Transfer> Transfer { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Account> Account { get; set; }
        public DbSet<AccountFlag> AccountFlag { get; set; }
    }
}
