using ProgramApplication.Domain.Common.ValueObjects;
using ProgramApplication.Domain.Models;

namespace ProgramApplication.Domain.Common.Entities
{
    public class QuestionBase : Entity<QuestionId>
    {
        public string Question { get; }

        public string Type { get; }

        public bool IsInternal { get; set; } = false;

        public bool IsHidden { get; set; } = false;

        protected QuestionBase(QuestionId id, string question, string type) : base(id)
        {
            Question = question;
            Type = type;
        }
    }
}
