using Microsoft.EntityFrameworkCore;
using ProjetoPilotoReboque.Models;
using ProjetoPilotoReboque.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque.Data
{
    public class PilotoReboqueContext:DbContext
    {
        public DbSet<FormularioAcionamento> FormularioAcionamento { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }

        public DbSet<ColaboradorLogin> ColaboradorLogin { get; set; }

        public DbSet<FornecedorLogin> FornecedorLogin { get; set; }


        public PilotoReboqueContext(DbContextOptions<PilotoReboqueContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
