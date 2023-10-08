using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Models;
using ProgramApplication.Domain.Workflow.ValueObjects;

namespace ProgramApplication.Domain.Workflow.Enitites.StageEntities
{
    public class Stage : Entity<StageId>
    {
        public string Name { get; }

        public string Type { get; }

        public bool ShowToCandidate { get; }

        public int Position { get; }

        public bool IsVideoInterviewStage() => Type == StageTypeConstants.VideoInterviewStage;

        protected Stage
            (StageId id, string name, string type, bool showToCandidate, int position) : base(id)
        {
            Name = name;
            Type = type;
            ShowToCandidate = showToCandidate;
            Position = position;
        }
    }
}
