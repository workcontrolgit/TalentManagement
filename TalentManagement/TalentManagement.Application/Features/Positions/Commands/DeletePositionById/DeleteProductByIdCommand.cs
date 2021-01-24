using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TalentManagement.Application.Exceptions;
using TalentManagement.Application.Interfaces.Repositories;
using TalentManagement.Application.Wrappers;

namespace TalentManagement.Application.Features.Positions.Commands.DeletePositionById
{
    public class DeletePositionByIdCommand : IRequest<Response<int>>
    {
        public int Id { get; set; }
        public class DeletePositionByIdCommandHandler : IRequestHandler<DeletePositionByIdCommand, Response<int>>
        {
            private readonly IPositionRepositoryAsync _positionRepository;
            public DeletePositionByIdCommandHandler(IPositionRepositoryAsync positionRepository)
            {
                _positionRepository = positionRepository;
            }
            public async Task<Response<int>> Handle(DeletePositionByIdCommand command, CancellationToken cancellationToken)
            {
                var position = await _positionRepository.GetByIdAsync(command.Id);
                if (position == null) throw new ApiException($"Position Not Found.");
                await _positionRepository.DeleteAsync(position);
                return new Response<int>(position.Id);
            }
        }
    }
}
