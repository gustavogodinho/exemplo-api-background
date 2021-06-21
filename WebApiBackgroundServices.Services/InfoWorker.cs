using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using WebApiBackgroundServices.Services.Services;

namespace WebApiBackgroundServices.Services
{
    public class InfoWorker : IHostedService
    {
       // private string message = "Mensagem inicial";
        private Timer _timer;
        // private ICommandRepository _commandRepository;
        private readonly RelatorioServices _relatorioServices;
        public InfoWorker(
            //ICommandRepository commandRepository
            RelatorioServices relatorioServices
            )
        {
            _relatorioServices = relatorioServices;
            //_commandRepository = commandRepository;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
            TimeSpan.FromSeconds(1));
            
            return Task.CompletedTask;
        }
        private void DoWork(object state)
        {
            Debug.WriteLine(_relatorioServices.EnvioRelatorio());

        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Stop {nameof(InfoWorker)}");

            return Task.CompletedTask;
        }
    }
}
