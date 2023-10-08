namespace ProgramApplication.Contracts.ApplicationForm
{
    public record CreateApplicationFormRequest(
        CoverImageSectionRequest CoverImageSection,
        PersonalInformationSectionRequest PersonalInformationSection,
        ProfileSectionRequest ProfileSection,
        AdditionalQuestionsSectionRequest AdditionalQuestionsSection);

    public record CoverImageSectionRequest(
        string Name,
        FileUploadQuestionRequest Question);
    
    public record PersonalInformationSectionRequest(
        string Name,
        List<QuestionBaseRequest> Questions);
    
    public record ProfileSectionRequest(List<ProfileSubSectionRequest> SubSections);
    
    public record AdditionalQuestionsSectionRequest(
        string Name,
        List<QuestionBaseRequest> Questions);
    
    public record ProfileSubSectionRequest(
        string Name,
        bool IsMandatory,
        bool IsHidden,
        List<QuestionBaseRequest> Questions);

    public record DateQuestionRequest(QuestionBaseRequest QuestionBase);
    
    public record DropdownQuestionRequest(
        bool IsOtherEnabled,
        List<string> Choices,
        QuestionBaseRequest QuestionBase);

    public record FileUploadQuestionRequest(
        ushort MaxSize,
        QuestionBaseRequest QuestionBase);

    public record MultipleChoiceQuestionRequest(
        bool IsOtherEnabled,
        List<string> Choices,
        ushort MaxChoices,
        QuestionBaseRequest QuestionBase);
    
    public record NumberQuestionRequest(QuestionBaseRequest QuestionBase);
    
    public record ParagraphQuestionRequest(
        uint Limit,
        QuestionBaseRequest QuestionBase);
    
    public record ShortAnswerQuestionRequest(QuestionBaseRequest QuestionBase);
    
    public record YesNoQuestionRequest(
        bool DisqualifyIfNo,
        QuestionBaseRequest QuestionBase);

    public record QuestionBaseRequest(
        string Question,
        string Type,
        uint Limit,
        ushort MaxSize,
        bool IsOtherEnabled,
        List<string> Choices,
        ushort MaxChoices,
        bool DisqualifyIfNo = false,
        bool IsInternal = false,
        bool IsHidden = false);
}
