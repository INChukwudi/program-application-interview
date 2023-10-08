using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;

namespace ProgramApplication.Domain.ApplicationForm.Sections
{
    public class AdditionalQuestionsSection
    {
        private readonly List<QuestionBase> _questions = new();

        public string Name { get; }

        public IReadOnlyList<QuestionBase> Questions => _questions.ToList();

        private void AddQuestions(List<QuestionBase> questions)
        {
            questions.ForEach(_questions.Add);
        }

        public AdditionalQuestionsSection(List<QuestionBase> questions)
        {
            Name = SectionNamesConstants.PersonalInformationSection;
            AddQuestions(questions);
        }
    }
}
