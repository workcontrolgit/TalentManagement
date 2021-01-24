using System.Collections.Generic;
using System.Threading.Tasks;
using TalentManagement.Application.Features.Positions.Queries.GetPositions;
using TalentManagement.Domain.Entities;

namespace TalentManagement.Application.Interfaces.Repositories
{
    public interface IPositionRepositoryAsync : IGenericRepositoryAsync<Position>
    {
        Task<bool> IsUniquePositionNumberAsync(string positionNumber);
        Task<bool> SeedDataAsync(int rowCount);
        Task<IEnumerable<Entity>> GetPagedPositionReponseAsync(GetPositionsQuery requestParameters);
    }
}
