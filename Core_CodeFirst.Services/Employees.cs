using Core_CodeFirst.Data.Models;
using Core_CodeFirst.Services.IServices;

namespace Core_CodeFirst.Services
{
    public class Employees : IEmployees
    {
        private readonly TestDbmajwtContext testDbmajwtContext;

        public Employees(TestDbmajwtContext db)
        {
            this.testDbmajwtContext = db;
        }
        public List<Employee> GetAllEmployee()
        {
            return testDbmajwtContext.Employees.ToList();
        }
    }
}