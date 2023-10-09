using ProgramApplication.Domain.Workflow;

namespace ProgramApplication.Application.Common.Interfaces.Persistence
{
    public interface IWorkflowRepository
    {
        WorkFlow? GetWorflowById(string id);

        void Add(WorkFlow workFlow);
    }
}
