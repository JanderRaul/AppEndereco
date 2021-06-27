using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AppCadastro_WebApi.Models;

namespace AppCadastro_WebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }        
        
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<ClienteEnd> ClienteEnd { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ClienteEnd>()
                .HasKey(AD => new { AD.ClienteId, AD.EnderecoId });

            builder.Entity<Cliente>()
                .HasData(new List<Cliente>(){
                    new Cliente(1, "Jander", "Jander Raul", "111.222.333-44","Pessoa Fisica", "01/01/1990", "Ativo", "19/06/2021 10:21"),
                    new Cliente(2, "Raul", "Raul Raul", "222.333.444-55","Pessoa Fisica", "02/02/1991", "Ativo", "19/06/2021 10:22"),
                });
            
            builder.Entity<Endereco>()
                .HasData(new List<Endereco>(){
                    new Endereco(1, "Rua Numero 1", "100", "Casa", "Pinheiros", "14.000-000", "Ribeirão Preto", "São Paulo", "Ativo"),
                    new Endereco(2, "Rua Numero 2", "120", "Ap-32, 3° Andar", "Palmas", "14.000-010", "Ribeirão Preto", "São Paulo", "Ativo"),
                });

            builder.Entity<ClienteEnd>()
                .HasData(new List<ClienteEnd>() {
                    new ClienteEnd() { ClienteId = 1, EnderecoId = 1 },
                    new ClienteEnd() { ClienteId = 2, EnderecoId = 2 },                    
                });
        }
    }
}