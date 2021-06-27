using System.Collections.Generic;
using AppCadastro_WebApi.Models;

namespace AppCadastro_WebApi.Models
{
    public class Cliente
    {
        public Cliente() { }
        
        public Cliente(int id, string nome, string tratamento, string cpf, string tipo, string dataNasc, string status, string dataInc) 
        {
            this.id = id;
            this.nome = nome;
            this.tratamento = tratamento;
            this.cpf = cpf;
            this.tipo = tipo;
            this.dataNasc = dataNasc;
            this.status = status;
            this.dataInc = dataInc;
        }

        public int id { get; set; }
        public string nome { get; set; }
        public string tratamento { get; set; }
        public string cpf { get; set; }
        public string tipo { get; set; }
        public string dataNasc { get; set; }
        public string status { get; set; }
        public string dataInc { get; set; }

        public List<Endereco> Enderecos { get; set; }

        public IEnumerable<ClienteEnd> ClienteEnd { get; set; }
    }
}