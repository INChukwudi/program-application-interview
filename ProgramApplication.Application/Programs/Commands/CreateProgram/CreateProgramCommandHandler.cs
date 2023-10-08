using ErrorOr;
using MediatR;
using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Domain.Program;

namespace ProgramApplication.Application.Programs.Commands.CreateProgram
{
    public class CreateProgramCommandHandler : IRequestHandler<CreateProgramCommand, ErrorOr<Program>>
    {
        private readonly IProgramRepository _programRepository;

        public CreateProgramCommandHandler(IProgramRepository programRepository)
        {
            _programRepository = programRepository;
        }

        public async Task<ErrorOr<Program>> Handle
            (CreateProgramCommand request, CancellationToken cancellationToken)
        {
            var program = Program.Create(
                request.Title, request.Summary, request.Description, request.KeySkills, request.Benefits,
                request.Criteria, request.Type, request.StartDate, request.ApplicationOpen, request.ApplicationClose,
                request.Duration, request.Location, request.MinQualification, request.MaxApplications);

            _programRepository.Add(program);

            return program;
        }
    }
}
