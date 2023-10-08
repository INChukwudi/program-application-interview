using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.ApplicationForm.Entities
{
    public class FileUploadQuestion : QuestionBase
    {
        public ushort MaxSize { get; }
        
        private FileUploadQuestion(QuestionId id, string question, string type, ushort maxSize)
            : base(id, question, type)
        {
            MaxSize = maxSize;
        }

        public static FileUploadQuestion Create(string question, ushort maxSize)
        {
            return new(QuestionId.CreateUnique(), question, QuestionTypeConstants.FileUploadQuestion,
                maxSize);
        }
    }
}
