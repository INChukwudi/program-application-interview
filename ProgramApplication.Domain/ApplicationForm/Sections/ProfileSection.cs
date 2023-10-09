using ProgramApplication.Domain.Common.Entities;

namespace ProgramApplication.Domain.ApplicationForm.Sections
{
    public class ProfileSection
    {
        private readonly List<ProfileSubSection> _subSections = new();

        public List<ProfileSubSection> SubSections => _subSections.ToList();

        public void AddSubSections(List<ProfileSubSection> subSections)
        {
            subSections.ForEach(_subSections.Add);
        }

        public ProfileSection(List<ProfileSubSection> subSections)
        {
            AddSubSections(subSections);
        }
    }

    public class ProfileSubSection
    {
        private readonly List<QuestionBase> _questions = new();

        public string Name { get; }

        public bool IsMandatory { get; set; } = false;
        
        public bool IsHidden { get; set; } = false;

        public IReadOnlyList<QuestionBase> Questions => _questions.ToList();

        public void AddQuestions(List<QuestionBase> questions)
        {
            questions.ForEach(_questions.Add);
        }

        public ProfileSubSection(string name, List<QuestionBase> questions)
        {
            Name = name;
            AddQuestions(questions);
        }
    }
}
