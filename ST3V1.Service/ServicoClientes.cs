using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using ST3V1.Domain.Entities;
using ST3V1.Domain.Interfaces;
using ST3V1.Infra.Data.Context;
using ST3V1.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
//using System.Timers;

namespace ST3V1.Service
{
    public class ServicoClientes : IHostedService
    {
        private readonly ICommandRepository _commandService;

        private Timer _timer;
        private string _message = "Mensagem Inicial";

        public ServicoClientes(ICommandRepository commandService)
        {
            _commandService = commandService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process started {nameof(ServicoClientes)}");
            
            

            _timer = new Timer(DoWork, null, TimeSpan.FromSeconds(5), TimeSpan.FromSeconds(25));
            return Task.CompletedTask;
        }

        private void DoWork(Object state)
        {
            Console.WriteLine($"{DateTime.Now:O} => {_commandService.GetMessage()}");
            var cli = _commandService.GetClientesCommand().Result;
            int conta = 0;
            if (cli != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (var item in cli) 
                    Console.WriteLine($"Registro: {conta++} | CNPJ: {item.CnpjNumInscricao} | Nome: {item.NomeEmpresarial} ");
            }
            //Console.WriteLine($"{DateTime.Now:O}");
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine($"Process finished {nameof(ServicoClientes)}");
            return Task.CompletedTask;
        }
    }
}
