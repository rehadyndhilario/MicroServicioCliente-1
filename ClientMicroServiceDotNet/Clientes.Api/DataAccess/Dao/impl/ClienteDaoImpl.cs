using Clientes.Api.DataAccess.SeedWorks;
using Entity.Entity;
using InfraStructure.SeedWorks;

namespace Clientes.Api.DataAccess.Dao.impl
{
    public class ClienteDaoImpl : BaseDao, IClienteDao
    {
        private readonly IRepository<Cliente> clienteRepository;
        public ClienteDaoImpl(IUnitOfWork unitOfWork, IRepository<Cliente> clienteRepository) : base(unitOfWork)
        {
            this.clienteRepository = clienteRepository;
        }

        public void create(Cliente cliente)
        {
            this.clienteRepository.Add(cliente);
        }

        public void delete(int id)
        {
            Cliente cliente = this.clienteRepository.GetAsync(id);
            this.clienteRepository.Delete(cliente);
        }

        public Cliente getById(int id)
        {
            return this.clienteRepository.GetAsync(id);
        }

        public void update(Cliente cliente)
        {
            this.clienteRepository.Update(cliente);
        }       
    }
}