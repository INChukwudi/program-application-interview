using Mapster;
using ProgramApplication.Contracts.Program;
using DbProgram = ProgramApplication.Domain.Program;

namespace ProgramApplication.Api.Common.Mapping
{
    public class ProgramMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<DbProgram.Program, ProgramResponse>()
                .Map(dest => dest.Id, src => src.Id.Value.ToString());
        }
    }
}
