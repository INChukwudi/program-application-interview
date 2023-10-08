using ProgramApplication.Domain.ApplicationForm.Sections;
using ProgramApplication.Domain.ApplicationForm.ValueObjects;
using ProgramApplication.Domain.Models;

namespace ProgramApplication.Domain.ApplicationForm
{
    public sealed class ApplicationForm : AggregateRoot<ApplicationFormId>
    {
        public CoverImageSection CoverImageSection { get; }
       
        public PersonalInformationSection PersonalInformationSection { get; }

        public ProfileSection ProfileSection { get; }

        public AdditionalQuestionsSection AdditionalQuestionsSection { get; }

        private ApplicationForm
            (ApplicationFormId id, CoverImageSection coverImageSection, 
            PersonalInformationSection personalInformationSection, ProfileSection profileSection, 
            AdditionalQuestionsSection additionalQuestionsSection) : base(id)
        {
            Id = id;
            CoverImageSection = coverImageSection;
            PersonalInformationSection = personalInformationSection;
            ProfileSection = profileSection;
            AdditionalQuestionsSection = additionalQuestionsSection;
        }

        public static ApplicationForm Create(CoverImageSection coverImageSection,
            PersonalInformationSection personalInformationSection, ProfileSection profileSection,
            AdditionalQuestionsSection additionalQuestionsSection)
        {
            return new(ApplicationFormId.CreateUnique(), coverImageSection,
            personalInformationSection, profileSection, additionalQuestionsSection);
        }
    }
}
