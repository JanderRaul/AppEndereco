using System.Threading.Tasks;
using AppCadastro_WebApi.Models;

namespace AppCadastro_WebApi.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();

        Task<Cliente[]> GetAllClientes(bool includeEnd);        
        Task<Cliente> GetClienteByNome(string ClienteNome);
        Task<Cliente> GetClienteByCPF(string ClienteNome);
        Task<Endereco> GetClienteByCEP(string CEPEndereco);
        // Task<Cliente[]> GetClienteByStatus(string ClienteStatus);
        // Task<Endereco[]> GetEnderecosByClienteId(int ClienteId);
    }
}