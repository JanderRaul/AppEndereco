using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using AppCadastro_WebApi.Models;

namespace AppCadastro_WebApi.Models
{
    public class Endereco
    {
        public Endereco() { }
        
        public Endereco(int id, string endereco, string numero, string complemento, string bairro, string cep, string cidade, string estado, string status) 
        {
            this.id = id;
            this.endereco = endereco;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cep = cep;
            this.cidade = cidade;
            this.estado = estado;
            this.status = status;
               
        }
        
        public int id { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string status { get; set; }

        public Cliente Cliente { get; set; }

        public IEnumerable<ClienteEnd> ClienteEnd { get; set; }
    }
}