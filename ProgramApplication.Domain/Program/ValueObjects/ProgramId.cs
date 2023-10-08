using ProgramApplication.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApplication.Domain.Program.ValueObjects
{
    public sealed class ProgramId : ValueObject
    {
        public Guid Value { get; }

        private ProgramId(Guid value)
        {
            Value = value;
        }

        public static ProgramId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
