using ProvaCleanArch.Domain.Model;

namespace ProvaCleanArch.Api.Dto
{
    public class CursoDto
    {
        public required string Titulo { get; set; }
        public required string Descricao { get; set; }
        public required Guid ProfessorId { get; set; }
        public required DateTime DataInicio { get; set; }
    }
}
