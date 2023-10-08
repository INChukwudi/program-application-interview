using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Workflow.Enitites.QuestionEntities;
using ProgramApplication.Domain.Workflow.ValueObjects;

namespace ProgramApplication.Domain.Workflow.Enitites.StageEntities
{
    public sealed class VideoInterviewStage : Stage
    {
        private readonly List<VideoInterviewQuestions> _questions = new();

        public IReadOnlyList<VideoInterviewQuestions> Questions => _questions.ToList();

        private VideoInterviewStage(StageId id, string name, string type, bool showToCandidate, int position)
            : base(id, name, type, showToCandidate, position)
        {
        }

        public static VideoInterviewStage Create(string name, bool showToCandidate, int position)
        {
            return new(StageId.CreateUnique(), name, StageTypeConstants.VideoInterviewStage, showToCandidate, position);
        }
    }
}
