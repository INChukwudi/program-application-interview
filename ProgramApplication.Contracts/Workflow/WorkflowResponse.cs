namespace ProgramApplication.Contracts.Workflow
{
    public record WorkflowResponse(
        string Id,
        List<StageResponse> Stages);

    public record PlacementStageResponse(
        string Id,
        string Name,
        string Type,
        bool ShowToCandidate,
        int Position) : StageResponse(Id, Name, Type, ShowToCandidate, Position);

    public record ShortlistingStageResponse(
        string Id,
        string Name,
        string Type,
        bool ShowToCandidate,
        int Position) : StageResponse(Id, Name, Type, ShowToCandidate, Position);

    public record VideoInterviewStageResponse(
        string Id,
        string Name,
        string Type,
        bool ShowToCandidate,
        int Position,
        List<VideoInterviewQuestionResponse> Questions) : StageResponse(Id, Name, Type, ShowToCandidate, Position);

    public record VideoInterviewQuestionResponse(
        string Id,
        string AdditionalInformation,
        ushort MaxDuration,
        string Units,
        ushort Deadline,
        string Question,
        string Type);

    public record StageResponse(
        string Id,
        string Name,
        string Type,
        bool ShowToCandidate,
        int Position);
}
