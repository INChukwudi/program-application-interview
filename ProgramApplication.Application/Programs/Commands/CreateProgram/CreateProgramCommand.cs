using ErrorOr;
using MediatR;
using ProgramApplication.Domain.Program;

namespace ProgramApplication.Application.Programs.Commands.CreateProgram
{
    public record CreateProgramCommand(
        string Title,
        string Summary,
        string Description,
        List<string> KeySkills,
        string Benefits,
        string Criteria,
        string Type,
        DateTimeOffset StartDate,
        DateTimeOffset ApplicationOpen,
        DateTimeOffset ApplicationClose,
        ushort Duration,
        string Location,
        string MinQualification,
        uint MaxApplications) : IRequest<ErrorOr<Program>>;
}
