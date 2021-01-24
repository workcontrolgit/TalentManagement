using System.Collections.Generic;
using TalentManagement.Domain.Entities;

namespace TalentManagement.Application.Interfaces
{
    public interface IMockService
    {
        List<Position> GetPositions(int rowCount);
        List<Employee> GetEmployees(int rowCount);
        List<Position> SeedPositions(int rowCount);
    }
}