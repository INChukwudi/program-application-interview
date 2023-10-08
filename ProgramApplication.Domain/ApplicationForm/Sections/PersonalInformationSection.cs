using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;

namespace ProgramApplication.Domain.ApplicationForm.Sections
{
    public class PersonalInformationSection
    {
        private readonly List<QuestionBase> _questions = new();

        public string Name { get; }

        public IReadOnlyList<QuestionBase> Questions => _questions.ToList();

        private void AddQuestions(List<QuestionBase> questions)
        {
            questions.ForEach(_questions.Add);
        }

        public PersonalInformationSection(List<QuestionBase> questions)
        {
            Name = SectionNamesConstants.PersonalInformationSection;
            AddQuestions(questions);
        }
    }
}
