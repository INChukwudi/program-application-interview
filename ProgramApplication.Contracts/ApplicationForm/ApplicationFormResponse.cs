namespace ProgramApplication.Contracts.ApplicationForm
{
    public record ApplicationFormResponse(
        string Id,
        CoverImageSectionResponse CoverImageSection,
        PersonalInformationSectionResponse PersonalInformationSection,
        ProfileSectionResponse ProfileSection,
        AdditionalQuestionsSectionResponse AdditionalQuestionsSection);

    public record CoverImageSectionResponse(
        string Name,
        FileUploadQuestionResponse Question);

    public record PersonalInformationSectionResponse(
        string Name,
        List<QuestionBaseResponse> Questions);

    public record ProfileSectionResponse(List<ProfileSubSectionResponse> SubSections);

    public record AdditionalQuestionsSectionResponse(
        string Name,
        List<QuestionBaseResponse> Questions);

    public record ProfileSubSectionResponse(
        string Name,
        bool IsMandatory,
        bool IsHidden,
        List<QuestionBaseResponse> Questions);

    public record DateQuestionResponse(
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record DropdownQuestionResponse(
        bool IsOtherEnabled,
        List<string> Choices,
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record FileUploadQuestionResponse(
        ushort MaxSize,
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record MultipleChoiceQuestionResponse(
        bool IsOtherEnabled,
        List<string> Choices,
        ushort MaxChoices,
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record NumberQuestionResponse(
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record ParagraphQuestionResponse(
        uint Limit,
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record ShortAnswerQuestionResponse(
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record YesNoQuestionResponse(
        bool DisqualifyIfNo,
        string Question,
        string Type,
        string Id,
        bool IsInternal = false,
        bool IsHidden = false) : QuestionBaseResponse(Id, Question, Type, IsInternal, IsHidden);

    public record QuestionBaseResponse(
        string Id,
        string Question,
        string Type,
        bool IsInternal = false,
        bool IsHidden = false);
}
