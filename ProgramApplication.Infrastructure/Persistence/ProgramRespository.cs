using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Domain.Program;

namespace ProgramApplication.Infrastructure.Persistence
{
    public class ProgramRespository : IProgramRepository
    {
        private readonly List<Program> _programs = new();

        public void Add(Program program)
        {
            _programs.Add(program);
        }

        public Program? GetProgramByIdAsync(string id)
        {
            return _programs.SingleOrDefault(p => p.Id.Value.ToString() == id);
        }
    }
}
