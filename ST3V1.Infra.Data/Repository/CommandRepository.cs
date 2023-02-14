using Microsoft.EntityFrameworkCore;
using ST3V1.Domain.Entities;
using ST3V1.Domain.Interfaces;
using ST3V1.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ST3V1.Infra.Data.Repository
{
    public class CommandRepository : ICommandRepository
    {
        private readonly ApplicationDbContext _clienteContext;

        public CommandRepository(ApplicationDbContext clienteContext)
        {
            _clienteContext = clienteContext;
        }

        public async Task<IEnumerable<Cliente>> GetClientesCommand()
        {
            var cli = await _clienteContext.Clientes.ToListAsync();
            return cli;
        }

        private string _message;
        public CommandRepository()
        {
            _message = "teste";
        }
        public string GetMessage()
        {
            return _message;
        }

        public void SetMessage(string message)
        {
            _message = message;
        }
    }
}
