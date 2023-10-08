using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class DateQuestion : QuestionBase
    {
        private DateQuestion(QuestionId id, string question, string type)
            : base(id, question, type)
        {
        }

        public static DateQuestion Create(string question)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.DateQuestion);
        }
    }
}
