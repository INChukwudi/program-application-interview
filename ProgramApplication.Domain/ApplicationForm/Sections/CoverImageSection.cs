using ProgramApplication.Domain.ApplicationForm.Entities;
using ProgramApplication.Domain.Common.Constants;

namespace ProgramApplication.Domain.ApplicationForm.Sections
{
    public class CoverImageSection
    {
        public string Name { get; }

        public FileUploadQuestion Question { get; }

        public CoverImageSection(ushort maxSize = 1)
        {
            Name = SectionNamesConstants.CoverImageSection;
            Question = FileUploadQuestion.Create("Cover Image", maxSize);
        }
    }
}
