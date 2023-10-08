using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Workflow.ValueObjects;

namespace ProgramApplication.Domain.Workflow.Enitites.StageEntities
{
    public sealed class PlacementStage : Stage
    {
        private PlacementStage(StageId id, string name, string type, bool showToCandidate, int position)
            : base(id, name, type, showToCandidate, position)
        {
        }

        public static PlacementStage Create(string name, bool showToCandidate, int position)
        {
            return new(StageId.CreateUnique(), name, StageTypeConstants.PlacementStage, showToCandidate, position);
        }
    }
}
