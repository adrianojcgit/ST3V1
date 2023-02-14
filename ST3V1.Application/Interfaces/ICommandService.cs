using ST3V1.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ST3V1.Application.Interfaces
{
    public interface ICommandService
    {
        Task<IEnumerable<ClienteDTO>> GetClientesCommand();
        string GetMessage();
        void SetMessage(string message);
    }
}
