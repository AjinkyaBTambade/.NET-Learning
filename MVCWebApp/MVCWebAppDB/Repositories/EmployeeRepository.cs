using Microsoft.EntityFrameworkCore;
using MVCWebAppDB.Data;
using MVCWebAppDB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MVCWebAppDB.Repositories
{
    public class EmployeeRepository
    {
        private readonly MVCWebAppDBContext _context;

        public EmployeeRepository(MVCWebAppDBContext context)
        {
            _context = context;
        }

        public List<Employee> GetAll()
        {
            var employees = _context.Employees.ToList();
            return employees;
        }
        public Employee Details(int id)
        {
            Employee empDetails = _context.Employees.FirstOrDefault(emp => emp.Id == id);
            return empDetails;
        }
        public bool Remove(int id)
        {
            bool status = false;
            var empToDelete = _context.Employees.FirstOrDefault(emp => emp.Id == id);
            if (empToDelete != null)
            {
                _context.Employees.Remove(empToDelete);
                _context.SaveChanges();
                status = true;
            }
            return status;
        }

        public bool Insert(Employee emp)
        {
            bool status = false;
            _context.Employees.Add(emp);
            _context.SaveChanges();
            status = true;
            return status;
        }

        public bool Update(Employee emp)
        {
            bool status = false;
            _context.Employees.Update(emp);
            _context.SaveChanges();
            status = true;
            return status;
        }
    }
}
