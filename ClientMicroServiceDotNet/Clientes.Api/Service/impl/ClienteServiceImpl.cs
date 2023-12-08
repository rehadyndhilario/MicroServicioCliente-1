using Clientes.Api.Controllers;
using Clientes.Api.DataAccess.Dao;
using Clientes.Api.Mapper;
using Common.dto;
using Entity.Entity;

namespace Clientes.Api.Service.impl
{
    public class ClienteServiceImpl : IClienteService
    {
        private readonly ILogger<ClientController> logger;
        private readonly IClienteDao clienteDao;
        public ClienteServiceImpl(IClienteDao clienteDao, ILogger<ClientController> logger)
        {
            this.clienteDao = clienteDao;
            this.logger = logger;
        }

        public void create(ClienteInputDto clienteInputDto)
        {
            this.clienteDao.create(ClienteMapper.convertDtoToEntity(clienteInputDto));
        }

        public void delete(int id)
        {
            this.clienteDao.delete(id);
        }

        public ClienteResponseDto getById(int id)
        {
            Cliente cliente = this.clienteDao.getById(id);
            return ClienteMapper.convertEntityToDto(cliente);
        }

        public void update(ClienteInputDto clienteInputDto)
        {
            this.clienteDao.update(ClienteMapper.convertDtoToEntity(clienteInputDto));
        }
    }
}