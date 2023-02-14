using AutoMapper;
using ST3V1.Application.DTOs;
using ST3V1.Application.Interfaces;
using ST3V1.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ST3V1.Application.Services
{
    public class CommandService : ICommandService
    {
        private readonly ICommandRepository _commandRepository;
        private readonly Mapper _mapper;

        public CommandService(ICommandRepository commandRepository, Mapper mapper)
        {
            _commandRepository = commandRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClienteDTO>> GetClientesCommand()
        {
            var clientesEntity = await _commandRepository.GetClientesCommand();
            IEnumerable<ClienteDTO> cli = _mapper.Map<IEnumerable<ClienteDTO>>(clientesEntity);
            return cli;
        }

        public string GetMessage()
        {
            throw new NotImplementedException();
        }

        public void SetMessage(string message)
        {
            throw new NotImplementedException();
        }
    }
}
