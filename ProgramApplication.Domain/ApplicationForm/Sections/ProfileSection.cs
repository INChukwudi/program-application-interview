using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;

namespace ProgramApplication.Domain.ApplicationForm.Sections
{
    public class ProfileSection
    {
        private readonly List<ProfileSubSections> _subSections = new();

        public List<ProfileSubSections> SubSections => _subSections.ToList();

        private void AddSubSections(List<ProfileSubSections> subSections)
        {
            subSections.ForEach(_subSections.Add);
        }

        public ProfileSection(List<ProfileSubSections> subSections)
        {
            AddSubSections(subSections);
        }
    }

    public class ProfileSubSections
    {
        private readonly List<QuestionBase> _questions = new();

        public string Name { get; }

        public bool IsMandatory { get; set; } = false;
        
        public bool IsHidden { get; set; } = false;

        public IReadOnlyList<QuestionBase> Questions => _questions.ToList();

        private void AddQuestions(List<QuestionBase> questions)
        {
            questions.ForEach(_questions.Add);
        }

        public ProfileSubSections(string name, List<QuestionBase> questions)
        {
            Name = name;
            AddQuestions(questions);
        }
    }
}
