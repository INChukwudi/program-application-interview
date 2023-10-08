using ErrorOr;
using MediatR;
using ProgramApplication.Application.Common.Interfaces.Persistence;
using ApplicationFormNameSpace = ProgramApplication.Domain.ApplicationForm;

namespace ProgramApplication.Application.ApplicationForm.Commands.CreateApplicationForm
{
    public class CreateApplicationFormCommandHandler
        : IRequestHandler<CreateApplicationFormCommand, ErrorOr<ApplicationFormNameSpace.ApplicationForm>>
    {
        private readonly IApplicationFormRepository _applicationFormRepository;

        public CreateApplicationFormCommandHandler(IApplicationFormRepository applicationFormRepository)
        {
            _applicationFormRepository = applicationFormRepository;
        }

        public async Task<ErrorOr<ApplicationFormNameSpace.ApplicationForm>> Handle
            (CreateApplicationFormCommand request, CancellationToken cancellationToken)
        {
            var applicationForm = ApplicationFormNameSpace.ApplicationForm.Create(
                request.CoverImageSection, request.PersonalInformationSection, request.ProfileSection,
                request.AdditionalQuestionsSection);

            _applicationFormRepository.Add(applicationForm);

            return applicationForm;
        }
    }
}
