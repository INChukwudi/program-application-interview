using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class ShortAnswerQuestion : QuestionBase
    {
        private ShortAnswerQuestion(QuestionId id, string question, string type)
            : base(id, question, type)
        {
        }

        public static ShortAnswerQuestion Create(string question)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.ShortAnswerQuestion);
        }
    }
}
