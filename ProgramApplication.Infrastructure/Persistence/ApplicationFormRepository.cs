using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Domain.ApplicationForm;

namespace ProgramApplication.Infrastructure.Persistence
{
    public class ApplicationFormRepository : IApplicationFormRepository
    {
        public void Add(ApplicationForm applicationForm)
        {
            return;
        }

        public ApplicationForm? GetApplicationFormByIdAsync(string id)
        {
            return default!;
        }
    }
}
