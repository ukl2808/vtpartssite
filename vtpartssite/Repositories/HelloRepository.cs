using vtpartssite.Interfaces;

namespace vtpartssite.Repositories
{
    public class HelloRepository : IHelloRepository
    {
        public string GetMessage()
        {
            return "I am new Repository";
        }
    }
}
