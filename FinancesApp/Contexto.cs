using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Finances_Control_App.Domain.FinancesApp
{
    public class Contexto(DbContextOptions<Contexto> options) : DbContext(options)
    {
        public DbSet<Transferencia> Transferencia { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<AccountFlag> AccountFlag { get; set; }
    }
}
