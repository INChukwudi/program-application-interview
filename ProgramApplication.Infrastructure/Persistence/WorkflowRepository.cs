using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Domain.Workflow;

namespace ProgramApplication.Infrastructure.Persistence
{
    public class WorkflowRepository : IWorkflowRepository
    {
        public void Add(WorkFlow workFlow)
        {
            return;
        }

        public WorkFlow? GetWorflowById(string id)
        {
            return default!;
        }
    }
}
