using ST3V1.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ST3V1.Domain.Interfaces
{
    public interface ICommandRepository
    {
        Task<IEnumerable<Cliente>> GetClientesCommand();
        string GetMessage();
        void SetMessage(string message);
    }
}
