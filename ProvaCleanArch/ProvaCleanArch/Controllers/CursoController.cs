
using Microsoft.AspNetCore.Mvc;
using ProvaCleanArch.Api.Dto;
using ProvaCleanArch.Data.Repository;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : ControllerBase
    {
        private readonly CursoRepository _repository;

        public CursoController()
        {
            _repository = new CursoRepository();
        }

        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Curso Get(Guid id)
        {
            return _repository.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Curso> Post([FromBody] CursoDto cursoDto)
        {
            var cursoEntidade = new Curso(cursoDto.Titulo, cursoDto.Descricao, cursoDto.ProfessorId, cursoDto.DataInicio);

            _repository.Incluir(cursoEntidade);

            return _repository.SelecionarTudo();
        }
    }
}