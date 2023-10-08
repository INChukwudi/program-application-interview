using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProgramApplication.Application.Common.Interfaces.Persistence;
using ProgramApplication.Application.Programs.Commands.CreateProgram;
using ProgramApplication.Contracts.Program;
/*using DbProgram = ProgramApplication.Domain.Entities.Program;*/

namespace ProgramApplication.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProgramsController : ApiController
    {
        private readonly IMapper _mapper;
        private readonly ISender _mediator;

        public ProgramsController(IMapper mapper, ISender mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProgram(string id)
        {
            return Ok(id);
        }
        
        [HttpPost()]
        public async Task<IActionResult> PostProgram(CreateProgramRequest programRequest)
        {
            var command = _mapper.Map<CreateProgramCommand>(programRequest);
            var createProgramResult = await _mediator.Send(command);
            return Ok(createProgramResult);
        }
        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgram(string id, CreateProgramRequest programRequest)
        {
            return Ok(programRequest);
        }
    }
}
