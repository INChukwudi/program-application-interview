using ProgramApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApplication.Domain.Workflow.ValueObjects
{
    public class WorkFlowId : ValueObject
    {
        public Guid Value { get; }

        private WorkFlowId(Guid value)
        {
            Value = value;
        }

        public static WorkFlowId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
