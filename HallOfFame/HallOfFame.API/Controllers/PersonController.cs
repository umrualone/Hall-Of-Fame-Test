using AutoMapper;
using HallOfFame.Application.Dtos.Requests.Person;
using HallOfFame.Application.Dtos.Resources;
using HallOfFame.Application.Dtos.Responces;
using HallOfFame.Application.Interfaces.Services;
using HallOfFame.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HallOfFame.API.Controllers
{
    [Route("api/v1/persons")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonController(IPersonService personService, IMapper mapper)
        {
            _personService = personService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var persons = await _personService.GetAll();

            return Ok(new SuccessResponse<List<PersonResources>>(
                "Список персонала",
                StatusCodes.Status200OK,
                _mapper.Map<List<PersonResources>>(persons)));
        }

        [HttpPost]
        public async Task<IActionResult> Create(PersonCreateRequest request)
        {
            var person = _mapper.Map<Person>(request);
            person = await _personService.Create(person);

            var response = new SuccessResponse<PersonResources>(
                "Сотрудник создан",
                StatusCodes.Status200OK,
                _mapper.Map<PersonResources>(person)
            );

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var person = await _personService.GetById(id);

            var response = new SuccessResponse<PersonResources>(
                "Сотрудник",
                StatusCodes.Status200OK,
                _mapper.Map<PersonResources>(person)
            );

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(long id, PersonUpdateRequest request)
        {
            var person = _mapper.Map<Person>(request);
            person = await _personService.Update(id, person);

            var response = new SuccessResponse<PersonResources>(
                "Сотрудник обновлен",
                StatusCodes.Status200OK,
                _mapper.Map<PersonResources>(person));

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _personService.Delete(id);

            var response = new SuccessEmptyResponse("Сотрудник удален", StatusCodes.Status200OK);

            return Ok(response);
        }
    }
}
