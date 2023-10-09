using Mapster;
using ProgramApplication.Application.ApplicationForm.Commands.CreateApplicationForm;
using ProgramApplication.Contracts.ApplicationForm;
using ProgramApplication.Domain.ApplicationForm;
using ProgramApplication.Domain.ApplicationForm.Entities;
using ProgramApplication.Domain.ApplicationForm.Sections;
using ProgramApplication.Domain.Common.Constants;

namespace ProgramApplication.Api.Common.Mapping
{
    public class ApplicationFormMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateApplicationFormRequest, CreateApplicationFormCommand>();

            config.NewConfig<AdditionalQuestionsSectionRequest, AdditionalQuestionsSection>();
                
            config.NewConfig<CoverImageSectionRequest, CoverImageSection>();
            config.NewConfig<PersonalInformationSectionRequest, PersonalInformationSection>();
            config.NewConfig<ProfileSectionRequest, ProfileSection>();
            config.NewConfig<ProfileSubSectionRequest, ProfileSubSection>();

            config.NewConfig<QuestionBaseRequest, DateQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.DateQuestion);

            config.NewConfig<QuestionBaseRequest, DropdownQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.DropdownQuestion);

            config.NewConfig<QuestionBaseRequest, FileUploadQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.FileUploadQuestion);

            config.NewConfig<QuestionBaseRequest, MultipleChoiceQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.MultipleChoiceQuestion);

            config.NewConfig<QuestionBaseRequest, NumberQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.NumberQuestion);

            config.NewConfig<QuestionBaseRequest, ParagraphQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.ParagraphQuestion);

            config.NewConfig<QuestionBaseRequest, ShortAnswerQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.ShortAnswerQuestion);

            config.NewConfig<QuestionBaseRequest, YesNoQuestion>()
                .Map(dest => dest, src => src, src => src.Type == QuestionTypeConstants.YesNoQuestion);


            config.NewConfig<DateQuestion, DateQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.DateQuestion);

            config.NewConfig<DropdownQuestion, DropdownQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.DropdownQuestion);

            config.NewConfig<FileUploadQuestion, FileUploadQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.FileUploadQuestion);

            config.NewConfig<MultipleChoiceQuestion, MultipleChoiceQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.MultipleChoiceQuestion);

            config.NewConfig<NumberQuestion, NumberQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.NumberQuestion);

            config.NewConfig<ParagraphQuestion, ParagraphQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.ParagraphQuestion);

            config.NewConfig<ShortAnswerQuestion, ShortAnswerQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.ShortAnswerQuestion);

            config.NewConfig<YesNoQuestion, YesNoQuestionResponse>()
                .Map(dest => dest.Id, 
                src => src.Id.Value.ToString(), 
                src => src.Type == QuestionTypeConstants.YesNoQuestion);


            config.NewConfig<ApplicationForm, ApplicationFormResponse>()
                .Map(dest => dest.Id, src => src.Id.Value.ToString());

            config.NewConfig<AdditionalQuestionsSection, AdditionalQuestionsSectionResponse>();
            config.NewConfig<CoverImageSection, CoverImageSectionResponse>();
            config.NewConfig<PersonalInformationSection, PersonalInformationSectionResponse>();
            config.NewConfig<ProfileSection, ProfileSectionResponse>();
            config.NewConfig<ProfileSubSection, ProfileSubSectionResponse>();
        }
    }
}
