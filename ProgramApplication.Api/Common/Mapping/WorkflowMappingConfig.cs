using Mapster;
using ProgramApplication.Application.ApplicationForm.Commands.CreateApplicationForm;
using ProgramApplication.Contracts.Workflow;
using ProgramApplication.Domain.Common.Constants;
using ProgramApplication.Domain.Workflow.Enitites.QuestionEntities;
using ProgramApplication.Domain.Workflow.Enitites.StageEntities;

namespace ProgramApplication.Api.Common.Mapping
{
    public class WorkflowMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<CreateWorkflowRequest, CreateApplicationFormCommand>();

            config.NewConfig<StageRequest, PlacementStage>()
                .Map(dest => dest,
                src => src,
                src => src.Type == StageTypeConstants.PlacementStage);
            
            config.NewConfig<StageRequest, ShortlistingStage>()
                .Map(dest => dest,
                src => src,
                src => src.Type == StageTypeConstants.ShortlistingStage);
            
            config.NewConfig<StageRequest, VideoInterviewStage>()
                .Map(dest => dest,
                src => src,
                src => src.Type == StageTypeConstants.VideoInterviewStage);

            config.NewConfig<VideoInterviewQuestionsRequest, VideoInterviewQuestion>()
                .Map(dest => dest,
                src => src,
                src => src.Type == QuestionTypeConstants.VideoInterviewQuestion);
            
            
            config.NewConfig<PlacementStage, PlacementStageResponse>()
                .Map(dest => dest.Id,
                src => src.Id.Value.ToString(),
                src => src.Type == StageTypeConstants.PlacementStage);
            
            config.NewConfig<ShortlistingStage, ShortlistingStageResponse>()
                .Map(dest => dest.Id,
                src => src.Id.Value.ToString(),
                src => src.Type == StageTypeConstants.ShortlistingStage);
            
            config.NewConfig<VideoInterviewStage, VideoInterviewStageResponse>()
                .Map(dest => dest.Id,
                src => src.Id.Value.ToString(),
                src => src.Type == StageTypeConstants.VideoInterviewStage);

            config.NewConfig<VideoInterviewQuestion, VideoInterviewQuestionResponse>()
                .Map(dest => dest.Id,
                src => src.Id.Value.ToString(),
                src => src.Type == QuestionTypeConstants.VideoInterviewQuestion);

        }
    }
}
