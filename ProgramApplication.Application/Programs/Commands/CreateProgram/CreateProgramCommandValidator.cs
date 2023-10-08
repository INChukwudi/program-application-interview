using FluentValidation;

namespace ProgramApplication.Application.Programs.Commands.CreateProgram
{
    public class CreateProgramCommandValidator : AbstractValidator<CreateProgramCommand>
    {
        public CreateProgramCommandValidator()
        {
            // Required Rules
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Type).NotEmpty();
            RuleFor(x => x.ApplicationClose).NotEmpty();
            RuleFor(x => x.ApplicationOpen).NotEmpty();
            RuleFor(x => x.Location).NotEmpty();

            // Max Length
            RuleFor(x => x.Summary).MaximumLength(250);
        }
    }
}
