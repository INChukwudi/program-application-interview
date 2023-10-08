using ProgramApplication.Domain.Program;

namespace ProgramApplication.Application.Common.Interfaces.Persistence
{
    public interface IProgramRepository
    {
        Program? GetProgramByIdAsync(string id);

        void Add(Program program);
    }
}
