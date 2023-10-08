using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class MultipleChoiceQuestion : QuestionBase
    {
        private readonly List<string> _choices = new();

        public bool IsOtherEnabled { get; }
        
        public ushort MaxChoices { get; }

        public IReadOnlyList<string> Choices => _choices.ToList();

        private void AddChoices(List<string> choices)
        {
            choices.ForEach(_choices.Add);
        }

        private MultipleChoiceQuestion
            (QuestionId id, string question, string type, bool otherEnabled, List<string> choices,
            ushort maxChoices)
            : base(id, question, type)
        {
            IsOtherEnabled = otherEnabled;
            AddChoices(choices);
            MaxChoices = maxChoices;
        }

        public static MultipleChoiceQuestion Create
            (string question, bool otherEnabled, List<string> choices, ushort maxChoices)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.MultipleChoiceQuestion,
                otherEnabled, choices, maxChoices);
        }
    }
}
