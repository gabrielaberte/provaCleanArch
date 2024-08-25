namespace ProvaCleanArch.Domain.Model
{
    public class Matricula
    {
        public Guid Id { get; private set; }
        public DateTime DataMatricula { get; private set; }
        public StatusMatricula Status { get; private set; }

        public Guid AlunoId { get; private set; }
        public Aluno Aluno { get; private set; }

        public Guid CursoId { get; private set; }
        public Curso Curso { get; private set; }

        public Matricula(Guid alunoId, Curso curso)
        {
            AlunoId = alunoId;
            Curso = curso;
            DataMatricula = DateTime.Now;
            Status = StatusMatricula.Ativa;
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
