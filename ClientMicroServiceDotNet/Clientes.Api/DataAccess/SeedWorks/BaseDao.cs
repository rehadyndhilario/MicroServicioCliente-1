using InfraStructure.SeedWorks;

namespace Clientes.Api.DataAccess.SeedWorks
{
    public abstract class BaseDao
    {
        protected readonly IUnitOfWork unitOfWork;

        protected BaseDao(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}