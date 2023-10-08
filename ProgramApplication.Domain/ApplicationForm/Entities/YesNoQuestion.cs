using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class YesNoQuestion : QuestionBase
    {
        public bool DisqualifyIfNo { get; }

        private YesNoQuestion(QuestionId id, string question, string type, bool limit)
            : base(id, question, type)
        {
            DisqualifyIfNo = limit;
        }

        public static YesNoQuestion Create(string question, bool limit)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.YesNoQuestion, limit);
        }
    }
}
