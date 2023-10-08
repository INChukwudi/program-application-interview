using ProgramApplication.Domain.Models;

namespace ProgramApplication.Domain.Workflow.ValueObjects
{
    public class StageId : ValueObject
    {
        public Guid Value { get; }

        private StageId(Guid value)
        {
            Value = value;
        }

        public static StageId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
