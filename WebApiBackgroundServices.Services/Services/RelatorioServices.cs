using WebApiBackgroundServices.Repository;

namespace WebApiBackgroundServices.Services.Services
{
    public class RelatorioServices
    {
        private ICommandRepository _commandRepository;

        public RelatorioServices(ICommandRepository commandRepository)
        {
            _commandRepository = commandRepository;
        }

        public string EnvioRelatorio()
        {
            return _commandRepository.GetMessage();
        }
        

    }
}
