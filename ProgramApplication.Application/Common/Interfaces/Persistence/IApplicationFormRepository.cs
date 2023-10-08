using ApplicationFormNameSpace = ProgramApplication.Domain.ApplicationForm;

namespace ProgramApplication.Application.Common.Interfaces.Persistence
{
    public interface IApplicationFormRepository
    {
        ApplicationFormNameSpace.ApplicationForm? GetApplicationFormByIdAsync(string id);

        void Add(ApplicationFormNameSpace.ApplicationForm applicationForm);
    }
}
