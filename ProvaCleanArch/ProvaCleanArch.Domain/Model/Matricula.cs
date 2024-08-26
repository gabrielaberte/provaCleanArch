namespace ProvaCleanArch.Domain.Model
{
    public class Matricula : IEntity
    {
        public Guid Id { get; private set; }
        public DateTime DataMatricula { get; set; }
        public StatusMatricula Status { get; private set; }

        public Guid AlunoId { get; private set; }
        public Aluno Aluno { get; private set; }

        public Guid CursoId { get; private set; }
        public Curso Curso { get; private set; }

        public Matricula(Guid alunoId, Guid cursoId)
        {
            AlunoId = alunoId;
            CursoId = cursoId;
            DataMatricula = DateTime.Now;
            Status = StatusMatricula.Ativa;
        }

        public void SetCurso(Curso curso)
        {
            Curso = curso;
        }

        public void ConcluirMatricula(Matricula matricula)
        {
            if (Curso.Ativo && Curso.Vagas > 0 && Aluno.Ativo && Curso.DataInicio > DataMatricula)
            {
                Status = StatusMatricula.Concluida;
                Curso.Matriculas.Add(matricula);
                Curso.Vagas--;
            }
            else
            {
                throw new InvalidOperationException("Não é possível concluir a matrícula.");
            }
        }

        public void CancelarMatricula()
        {
            Status = StatusMatricula.Cancelada;

        }
    }

    public enum StatusMatricula
    {
        Ativa,
        Concluida,
        Cancelada
    }
}
