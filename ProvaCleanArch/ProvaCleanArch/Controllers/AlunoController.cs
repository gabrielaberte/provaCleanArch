
using Microsoft.AspNetCore.Mvc;
using ProvaCleanArch.Api.Dto;
using ProvaCleanArch.Data.Repository;
using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly AlunoRepository _repository;

        public AlunoController()
        {
            _repository = new AlunoRepository();
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Aluno Get(Guid id)
        {
            return _repository.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Aluno> Post([FromBody] AlunoDto alunoDto)
        {
            var alunoEntidade = Aluno.NovoAluno(alunoDto.Nome, alunoDto.Email, alunoDto.Endereco);

            _repository.Incluir(alunoEntidade);

            return _repository.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public Aluno Put(Guid id)
        {
            var alunoEntidade = _repository.Selecionar(id);

            alunoEntidade.Desativar();

            _repository.Alterar(alunoEntidade);

            return alunoEntidade;
        }
    }
}