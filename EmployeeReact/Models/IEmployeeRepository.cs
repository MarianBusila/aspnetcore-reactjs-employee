using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeeReact.Models
{
    public interface IEmployeeRepository
    {
        Employee Get(int id);
        IEnumerable<Employee> GetAll();
        int Insert(Employee employee);
        void Update(Employee employee);
        void Delete(int id);

        Task<Employee> GetAsync(int id);
        Task<IEnumerable<Employee>> GetAllAsync();
        Task<int> InsertAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
    }
}
