using EFMigrations.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMigrations
{
   public class LojaContex: DbContext
    {
        public LojaContex() : base("Loja")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LojaContex, Configuration>());
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}
