using ErrorOr;

namespace ProgramApplication.Domain.Common.Errors
{
    public static class Errors
    {
        public static class Program
        {
            public static Error InvalidType => Error.Validation(
                code: "Unsupported Program Type",
                description: "Program type is not supported. Select a supported value.");

            public static Error InvalidMinQualifications => Error.Validation(
                code: "Unsupported Qualification",
                description: "Qualification is not supported. Selecte a supported value.");
        }
    }
}
