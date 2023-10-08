using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class DropdownQuestion : QuestionBase
    {
        private readonly List<string> _choices = new();

        public bool IsOtherEnabled { get; }

        public IReadOnlyList<string> Choices => _choices.ToList();

        private void AddChoices(List<string> choices)
        {
            choices.ForEach(_choices.Add);
        }

        private DropdownQuestion
            (QuestionId id, string question, string type, bool otherEnabled, List<string> choices)
            : base(id, question, type)
        {
            IsOtherEnabled = otherEnabled;
            AddChoices(choices);
        }

        public static DropdownQuestion Create(string question, bool otherEnabled, List<string> choices)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.DropdownQuestion,
                otherEnabled, choices);
        }
    }
}
