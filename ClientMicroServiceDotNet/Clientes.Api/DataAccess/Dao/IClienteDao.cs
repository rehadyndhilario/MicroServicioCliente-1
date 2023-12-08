using Entity.Entity;

namespace Clientes.Api.DataAccess.Dao
{
    public interface IClienteDao
    {
        public void create(Cliente cliente);
        public void delete(int id);
        public void update(Cliente cliente);
        public Cliente getById(int id);
    }
}