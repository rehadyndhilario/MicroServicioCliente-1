using Common.dto;

namespace Clientes.Api.Service
{
    public interface IClienteService
    {
        public void create(ClienteInputDto clienteInputDto);
        public void delete(int id);
        public void update(ClienteInputDto clienteInputDto);
        public ClienteResponseDto getById(int id);
    }
}