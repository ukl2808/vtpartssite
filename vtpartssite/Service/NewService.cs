using vtpartssite.Interfaces;
using vtpartssite.Repositories;

namespace vtpartssite.Service
{
    public class NewService : INewService
    {
        private readonly IHelloRepository _helloRepository;

        public NewService(IHelloRepository helloRepository)
        {
            _helloRepository = helloRepository;
        }
        public string GetMessage()
        {
            return "I am new service";
        }

        public string GetMessageFromRepository()
        {
            return _helloRepository.GetMessage();
        }
    }
}
