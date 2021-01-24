using AutoMapper;
using TalentManagement.Application.Features.Employees.Queries.GetEmployees;
using TalentManagement.Application.Features.Positions.Commands.CreatePosition;
using TalentManagement.Application.Features.Positions.Queries.GetPositions;
using TalentManagement.Domain.Entities;

namespace TalentManagement.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Position, GetPositionsViewModel>().ReverseMap();
            CreateMap<Employee, GetEmployeesViewModel>().ReverseMap();
            CreateMap<CreatePositionCommand, Position>();
        }
    }

}
