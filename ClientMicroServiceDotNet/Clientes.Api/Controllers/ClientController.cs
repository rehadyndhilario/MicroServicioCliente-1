using Clientes.Api.Service;
using Common.dto;
using Microsoft.AspNetCore.Mvc;

namespace Clientes.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {        

        private readonly ILogger<ClientController> logger;
        private readonly IClienteService clienteService;

        public ClientController(ILogger<ClientController> logger, IClienteService clienteService)
        {
            this.logger = logger;
            this.clienteService = clienteService;
        }

        [HttpGet("{id}")]
        public ClienteResponseDto getById(int id)
        {
            logger.LogInformation($"Entrando por el metodo getById {id}");
            return this.clienteService.getById(id);
        }

        [HttpPost]
        public void create([FromBody] ClienteInputDto clienteInputDto)
        {
            logger.LogInformation($"Entrando por el metodo delete {clienteInputDto}");
            this.clienteService.create(clienteInputDto);
        }

        [HttpPut]
        public void update([FromBody] ClienteInputDto clienteInputDto)
        {
            logger.LogInformation($"Entrando por el metodo update {clienteInputDto}");
            this.clienteService.update(clienteInputDto);
        }

        [HttpDelete("{id}")]
        public void delete(int id)
        {
            logger.LogInformation($"Entrando por el metodo delete {id}");
            this.clienteService.delete(id);
        }
    }
}