using ErrorOr;
using MediatR;
using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Domain.Workflow;

namespace ProgramApplication.Application.Workflow.Commands.CreateWorkflow
{
    public class CreateWorkflowCommandHandler : IRequestHandler<CreateWorkflowCommand, ErrorOr<WorkFlow>>
    {
        private readonly IWorkflowRepository _workflowRepository;

        public CreateWorkflowCommandHandler(IWorkflowRepository workflowRepository)
        {
            _workflowRepository = workflowRepository;
        }

        public async Task<ErrorOr<WorkFlow>> Handle(CreateWorkflowCommand request, CancellationToken cancellationToken)
        {
            var workflow = WorkFlow.Create();
            workflow.AddStages(request.Stages);

            _workflowRepository.Add(workflow);

            return workflow;
        }
    }
}
