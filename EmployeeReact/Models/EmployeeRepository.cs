using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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

        public async Task DeleteAsync(int id)
        {
            var employee = this.dbContext.Employee.First(it => it.EmployeeId == id);
            this.dbContext.Employee.Remove(employee);
            await this.dbContext.SaveChangesAsync();
        }

        public Employee Get(int id)
        {
            return this.dbContext.Employee.FirstOrDefault(it => it.EmployeeId == id);
        }

        public async Task<Employee> GetAsync(int id)
        {
            return await this.dbContext.Employee.FirstOrDefaultAsync(it => it.EmployeeId == id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return this.dbContext.Employee.ToList();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await this.dbContext.Employee.ToListAsync();
        }
        

        public int Insert(Employee employee)
        {
            this.dbContext.Employee.Add(employee);
            this.dbContext.SaveChanges();
            return employee.EmployeeId;
        }

        public async Task<int> InsertAsync(Employee employee)
        {
            this.dbContext.Employee.Add(employee);
            await this.dbContext.SaveChangesAsync();
            return employee.EmployeeId;
        }

        public void Update(Employee employee)
        {
            this.dbContext.Employee.Update(employee);
            this.dbContext.SaveChanges();
        }

        public async Task UpdateAsync(Employee employee)
        {
            this.dbContext.Employee.Update(employee);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
