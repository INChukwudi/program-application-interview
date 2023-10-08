namespace ProgramApplication.Contracts.Program
{
    public record CreateProgramRequest(
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
        uint MaxApplications
    );
}