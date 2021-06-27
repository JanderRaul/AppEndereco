namespace AppCadastro_WebApi.Models
{
    public class ClienteEnd
    {
        public ClienteEnd()
        {

        }
        
        public ClienteEnd(int clienteId, int enderecoId) 
        {
            this.ClienteId = clienteId;
            this.EnderecoId = enderecoId;
               
        }

        public Cliente Cliente { get; set; }
        public Endereco Endereco { get; set; }
        
        public int ClienteId { get; set; }
        public int EnderecoId { get; set; }
    }
}