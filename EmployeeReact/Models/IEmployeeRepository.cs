using System.Collections.Generic;

namespace EmployeeReact.Models
{
    public interface IEmployeeRepository
    {
        Employee Get(int id);
        IEnumerable<Employee> GetAll();
        int Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
    }
}
