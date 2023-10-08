namespace ProgramApplication.Contracts.Program
{
    public record ProgramResponse(
        string Id,
        string Title,
        string Summary,
        string Description,
        List<string> KeySkills,
        string Benefits,
        string Criteria,
        string Type,
        DateTimeOffset StartDate,
        DateTimeOffset ApplicationOpen,
        DateTimeOffset ApplicationClose,
        ushort Duration,
        string Location,
        string MinQualification,
        uint MaxApplications,
        DateTimeOffset CreatedAt,
        DateTimeOffset LastModifiedAt,
        string ApplicationFormId,
        string WorkFlowId);
}
