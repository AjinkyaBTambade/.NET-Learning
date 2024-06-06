using MvcRegisterFormApp.Models;

namespace MvcRegisterFormApp.Services
{
    public interface IRegisterService
    {
        public List<RegisterForm> GetAll();
        public bool Add(RegisterForm form);
    }
}
