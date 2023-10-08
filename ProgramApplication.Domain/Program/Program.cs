using ProgramApplication.Domain.ApplicationForm.ValueObjects;
using ProgramApplication.Domain.Models;
using ProgramApplication.Domain.Program.ValueObjects;
using ProgramApplication.Domain.Workflow.ValueObjects;

namespace ProgramApplication.Domain.Program
{
    public sealed class Program : AggregateRoot<ProgramId>
    {
        public string Title { get; }

        public string Summary { get; }
        
        public string Description { get; }

        public List<string> KeySkills { get; }

        public string Benefits { get; }

        public string Criteria { get; }

        public string Type { get; }

        public DateTimeOffset StartDate { get; }
        
        public DateTimeOffset ApplicationOpen { get; }
        
        public DateTimeOffset ApplicationClose { get; }
        
        public ushort Duration { get; }
        
        public string Location { get; }

        public string MinQualification { get; }

        public uint MaxApplication { get; }

        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;

        public DateTimeOffset LastModifiedAt { get; set; } = DateTimeOffset.Now;

        public string ApplicationFormId { get; private set; } = null!;  

        public string WorkFlowId { get; private set; } = null!;

        public void UpdateApplicationForm(ApplicationFormId formId)
        {
            ApplicationFormId = formId.Value.ToString();
        }

        public void UpdateWorkFlow(WorkFlowId formId)
        {
            WorkFlowId = formId.Value.ToString();
        }

        private Program(
            ProgramId id,
            string title,
            string summary,
            string description,
            List<string> keySkills,
            string benefits,
            string criteria,
            string type,
            DateTimeOffset startDate,
            DateTimeOffset applicationOpen,
            DateTimeOffset applicationClose,
            ushort duration,
            string location,
            string minQualification,
            uint maxApplication) : base(id)
        {
            Id = id;
            Title = title;
            Summary = summary;
            Description = description;
            KeySkills = keySkills;
            Benefits = benefits;
            Criteria = criteria;
            Type = type;
            StartDate = startDate;
            ApplicationOpen = applicationOpen;
            ApplicationClose = applicationClose;
            Duration = duration;
            Location = location;
            MinQualification = minQualification;
            MaxApplication = maxApplication;
        }

        public static Program Create(
            string title,
            string summary,
            string description,
            List<string> keySkills,
            string benefits,
            string criteria,
            string type,
            DateTimeOffset startDate,
            DateTimeOffset applicationOpen,
            DateTimeOffset applicationClose,
            ushort duration,
            string location,
            string minQualification,
            uint maxApplication)
        {
            return new(ProgramId.CreateUnique(), title, summary, description, keySkills, benefits, criteria, 
                type, startDate, applicationOpen, applicationClose, duration, location, minQualification, 
                maxApplication);
        }
    }
}
