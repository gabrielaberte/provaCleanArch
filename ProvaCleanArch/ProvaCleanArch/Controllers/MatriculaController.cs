
using Microsoft.AspNetCore.Mvc;
using ProvaCleanArch.Api.Dto;
using ProvaCleanArch.Data.Repository;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatriculaController : ControllerBase
    {
        private readonly MatriculaRepository _repository;

        public MatriculaController()
        {
            _repository = new MatriculaRepository();
        }

        [HttpPost]
        public IEnumerable<Matricula> Post([FromBody] MatriculaDto matriculaDto)
        {
            var matriculaEntidade = new Matricula(matriculaDto.AlunoId, matriculaDto.CursoId);

            _repository.Incluir(matriculaEntidade);

            return _repository.SelecionarTudo();
        }
    }
}