using System.Threading.Tasks;
using AppCadastro_WebApi.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AppCadastro_WebApi.Data;

namespace AppCadastro_WebApi.Data
{
    public class Repository: IRepository
    {
        private readonly DataContext _context;

        public Repository(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }
        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }
        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public async Task<Cliente[]> GetAllClientes(bool includeEnd = false) {
            IQueryable<Cliente> query = _context.Cliente;

            if (includeEnd)
            {
                query = query.Include(ce => ce.ClienteEnd).ThenInclude(e => e.Endereco);
            }

            query = query.AsNoTracking()
                         .OrderBy(c => c.id);

            return await query.ToArrayAsync();
        }         
        
        public async Task<Cliente> GetClienteByNome(string nome) 
        {
            IQueryable<Cliente> query = _context.Cliente;
            query = query.AsNoTracking()
                        .OrderBy(cliente => cliente.id)
                        .Where(cliente => cliente.nome == nome);

            return await query.FirstAsync();
        }

        public async Task<Cliente> GetClienteByCPF(string cpf) 
        {
            IQueryable<Cliente> query = _context.Cliente;
            query = query.AsNoTracking()
                        .OrderBy(cliente => cliente.id)
                        .Where(cliente => cliente.cpf == cpf);

            return await query.FirstAsync();
        }
        
        public async Task<Endereco> GetClienteByCEP(string CEPEndereco) 
        {
            IQueryable<Endereco> query = _context.Endereco;
            query = query.AsNoTracking()
                        .OrderBy(endereco => endereco.cep)
                        .Where(endereco => endereco.cep == CEPEndereco);

            return await query.FirstAsync();
        }

        // public async Task<Cliente[]> GetClienteByCEP(string CEPEndereco) { }
        // public async Task<Cliente[]> GetClienteByStatus(string ClienteStatus) { }
        // public async Task<Endereco[]> GetEnderecosByClienteId(int ClienteId) { }
    }
}