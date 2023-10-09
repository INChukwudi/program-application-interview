using ProgramApplication.Domain.Models;
using ProgramApplication.Domain.Workflow.Enitites.StageEntities;
using ProgramApplication.Domain.Workflow.ValueObjects;

namespace ProgramApplication.Domain.Workflow
{
    public sealed class WorkFlow : AggregateRoot<WorkFlowId>
    {
        private readonly List<Stage> _stages = new();

        public IReadOnlyList<Stage> Stages => _stages.ToList();

        private WorkFlow(WorkFlowId id) : base(id)
        { 
            Id = id;
        }

        public void AddStages(List<Stage> stages)
        {
            stages.ForEach(_stages.Add);
        }

        public static WorkFlow Create()
        {
            return new(WorkFlowId.CreateUnique());
        }
    }
}
