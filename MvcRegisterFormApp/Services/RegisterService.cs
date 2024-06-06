using Microsoft.EntityFrameworkCore;
using MvcRegisterFormApp.DataContext;
using MvcRegisterFormApp.Models;

namespace MvcRegisterFormApp.Services
{
    public class RegisterService : IRegisterService
    {
       
        
        public bool Add(RegisterForm form)
        {
            bool status = false;
            using (DbContextRegisterForm _dbContext = new DbContextRegisterForm())
            {
                _dbContext.RegisterForms.Add(form);
                _dbContext.SaveChanges();
                status = true;
            }
            return status;
        }

        public List<RegisterForm> GetAll()
        {
            using (DbContextRegisterForm _dbContext = new DbContextRegisterForm())
            {
                return _dbContext.RegisterForms.ToList();
            }
        }
    }
}
