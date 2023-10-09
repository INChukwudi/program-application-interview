namespace ProgramApplication.Contracts.Workflow
{
    public record CreateWorkflowRequest(
        List<StageRequest> Stages);

    public record StageRequest(
        string Name,
        string Type,
        bool ShowToCandidate,
        int Position,
        List<VideoInterviewQuestionsRequest> Questions);

    public record VideoInterviewQuestionsRequest(
        string AdditionalInformation,
        ushort MaxDuration,
        string Units,
        ushort Deadline,
        string Question,
        string Type);
}
