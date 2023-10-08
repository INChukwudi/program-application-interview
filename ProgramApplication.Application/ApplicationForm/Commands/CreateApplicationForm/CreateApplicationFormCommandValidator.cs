using FluentValidation;
using ProgramApplication.Application.Programs.Commands.CreateProgram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramApplication.Application.ApplicationForm.Commands.CreateApplicationForm
{
    public class CreateApplicationFormCommandValidator : AbstractValidator<CreateApplicationFormCommand>
    {
        public CreateApplicationFormCommandValidator()
        {
            // Required Rules
            RuleFor(x => x.CoverImageSection).NotNull();
            RuleFor(x => x.ProfileSection).NotNull();
            RuleFor(x => x.PersonalInformationSection).NotNull();
        }
    }
}
