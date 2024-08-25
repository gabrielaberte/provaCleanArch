
using Microsoft.AspNetCore.Mvc;
using ProvaCleanArch.Api.Dto;
using ProvaCleanArch.Data.Repository;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private readonly ProfessorRepository _repository;

        public ProfessorController()
        {
            _repository = new ProfessorRepository();
        }

        [HttpGet]
        public IEnumerable<Professor> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Professor Get(Guid id)
        {
            return _repository.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Professor> Post([FromBody] ProfessorDto professorDto)
        {
            var profEntidade = Professor.novoProfessor(professorDto.Nome, professorDto.Email);

            _repository.Incluir(profEntidade);

            return _repository.SelecionarTudo();
        }
    }
}