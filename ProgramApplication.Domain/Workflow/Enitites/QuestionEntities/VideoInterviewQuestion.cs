using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Common.Entities;
using ProgramApplication.Domain.Common.ValueObjects;

namespace ProgramApplication.Domain.Workflow.Enitites.QuestionEntities
{
    public class VideoInterviewQuestion : QuestionBase
    {
        public string AdditionalInformation { get; }

        public ushort MaxDuration { get; }

        public string Units { get; }

        public ushort Deadline { get; }

        private VideoInterviewQuestion
            (QuestionId id, string question, string type, string additionalInformation, ushort maxDuration,
            string units, ushort deadline)
            : base(id, question, type)
        {
            AdditionalInformation = additionalInformation;
            MaxDuration = maxDuration;
            Units = units;
            Deadline = deadline;
        }

        public static VideoInterviewQuestion Create
            (QuestionId id, string question, string additionalInformation, ushort maxDuration, string units,
            ushort deadline)
        {
            return new(id, question, QuestionTypeConstants.VideoInterviewQuestion, additionalInformation,
                maxDuration, units, deadline);
        }
    }
}
