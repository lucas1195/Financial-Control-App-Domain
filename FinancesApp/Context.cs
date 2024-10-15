using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Transfer> Transferencia { get; set; }
        public DbSet<Category> Categoria { get; set; }
        public DbSet<User> Usuario { get; set; }
        public DbSet<Account> Conta { get; set; }
        public DbSet<AccountFlag> AccountFlag { get; set; }
    }
}
