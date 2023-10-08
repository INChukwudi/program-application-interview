using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class ParagraphQuestion : QuestionBase
    {
        public uint Limit { get; } = uint.MaxValue;
        
        private ParagraphQuestion(QuestionId id, string question, string type, uint limit)
            : base(id, question, type)
        {
            Limit = limit;
        }

        public static ParagraphQuestion Create(string question, uint limit)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.ParagraphQuestion, limit);
        }
    }
}
