using System;
using System.Collections.Generic;
using System.Text;
using AlimentosMarfim.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlimentosMarfim.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Venda> Venda { get; set; }

    }
}
