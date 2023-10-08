using ProgramApplication.Domain.Models;

namespace ProgramApplication.Domain.ApplicationForm.ValueObjects
{
    public class ApplicationFormId : ValueObject
    {
        public Guid Value { get; }

        private ApplicationFormId(Guid value)
        {
            Value = value;
        }

        public static ApplicationFormId CreateUnique()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}
