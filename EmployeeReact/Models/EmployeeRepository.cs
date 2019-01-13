using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeReact.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly POCContext dbContext;

        public EmployeeRepository(POCContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Delete(int id)
        {
            var employee = this.dbContext.Employee.First(it => it.EmployeeId == id);
            this.dbContext.Employee.Remove(employee);
            this.dbContext.SaveChanges();
        }

        public Employee Get(int id)
        {
            return this.dbContext.Employee.FirstOrDefault(it => it.EmployeeId == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.dbContext.Employee.AsEnumerable();
        }

        public int Insert(Employee employee)
        {
            this.dbContext.Employee.Add(employee);
            this.dbContext.SaveChanges();
            return employee.EmployeeId;
        }

        public void Update(Employee employee)
        {
            this.dbContext.Employee.Update(employee);
            this.dbContext.SaveChanges();
        }
    }
}
