using System.Collections.Generic;
using System.Threading.Tasks;
using TalentManagement.Application.Features.Employees.Queries.GetEmployees;
using TalentManagement.Domain.Entities;

namespace TalentManagement.Application.Interfaces.Repositories
{
    public interface IEmployeeRepositoryAsync : IGenericRepositoryAsync<Employee>
    {
        Task<IEnumerable<Entity>> GetPagedEmployeeReponseAsync(GetEmployeesQuery requestParameter);
    }
}
