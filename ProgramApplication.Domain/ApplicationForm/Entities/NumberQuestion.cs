using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class NumberQuestion : QuestionBase
    {
        private NumberQuestion(QuestionId id, string question, string type)
            : base(id, question, type)
        {
        }

        public static NumberQuestion Create(string question)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.NumberQuestion);
        }
    }
}
