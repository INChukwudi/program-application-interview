using ErrorOr;
using MediatR;
using ProgramApplication.Domain.ApplicationForm.Sections;
using ApplicationFormNameSpace = ProgramApplication.Domain.ApplicationForm;

namespace ProgramApplication.Application.ApplicationForm.Commands.CreateApplicationForm
{
    public record CreateApplicationFormCommand(
        CoverImageSection CoverImageSection,
        PersonalInformationSection PersonalInformationSection,
        ProfileSection ProfileSection,
        AdditionalQuestionsSection AdditionalQuestionsSection
        ) : IRequest<ErrorOr<ApplicationFormNameSpace.ApplicationForm>>;
}
