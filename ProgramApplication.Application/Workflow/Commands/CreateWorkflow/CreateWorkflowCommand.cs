using ErrorOr;
using MediatR;
using ProgramApplication.Domain.Workflow;
using ProgramApplication.Domain.Workflow.Enitites.StageEntities;

namespace ProgramApplication.Application.Workflow.Commands.CreateWorkflow
{
    public record CreateWorkflowCommand(List<Stage> Stages) : IRequest<ErrorOr<WorkFlow>>;
}
