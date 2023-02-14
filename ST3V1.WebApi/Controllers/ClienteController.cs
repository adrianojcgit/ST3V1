using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ST3V1.Domain.Entities;
using ST3V1.Domain.Interfaces;
using ST3V1.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ST3V1.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ICommandRepository _clienteContext;
        public ClienteController(ICommandRepository context)
        {
            _clienteContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> Get()
        {
            var clientes = await _clienteContext.GetClientesCommand();
            if (clientes is null)
                return NotFound("Clientes não encontrados.");

            return clientes.ToList();
        }

        [HttpGet("{qtde}")]
        public async Task<ActionResult<int>> TotalRegistros()
        {
            var clientes = await _clienteContext.GetClientesCommand();
            if (clientes is null)
                return NotFound("Clientes não encontrados.");

            return clientes.ToList().Count();
        }

        //[HttpGet("{cnpj}")]
        //public async Task<ActionResult<ClienteDTO>> GetByCnpj(string cnpj)
        //{
        //    var cliente = await _clienteContext.GetById(0);
        //    if (cliente is null)
        //        return NotFound("Cliente não encontrado.");

        //    return cliente;
        //}

        //[HttpGet("Nome/{NomeEmpresarial}")]
        //public async Task<ActionResult<IEnumerable<ClienteDTO>>> GetByNomeEmpresarial(string NomeEmpresarial)
        //{
        //    var cliente = await _clienteContext.GetClientes();
        //    if (cliente is null)
        //        return NotFound("Registro não encontrado.");

        //    return cliente.ToList();
        //}
    }
}
