using Common.dto;
using Entity.Entity;

namespace Clientes.Api.Mapper
{
    public class ClienteMapper
    {

        public static Cliente convertDtoToEntity(ClienteInputDto dto)
        {
            var cliente = new Cliente();
            cliente.Id = dto.Id;    
            cliente.Nombre = dto.Nombre;
            cliente.Apellido = dto.Apellido;
            cliente.Email = dto.Email;
            cliente.FechaCreacion = dto.FechaCreacion;

            return cliente;
        }

        public static ClienteResponseDto convertEntityToDto(Cliente entity)
        {
            var clienteResponseDto = new ClienteResponseDto();
            clienteResponseDto.Apellido = entity.Apellido;
            clienteResponseDto.Nombre = entity.Nombre;
            clienteResponseDto.Id = entity.Id;
            clienteResponseDto.Email = entity.Email;
            clienteResponseDto.FechaCreacion = entity.FechaCreacion;

            return clienteResponseDto;

        }
    }
}