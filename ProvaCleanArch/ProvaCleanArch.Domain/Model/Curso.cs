namespace ProvaCleanArch.Domain.Model
{
    public class Curso
    {
        public Guid Id { get;  set; }
        public string Titulo { get;  set; }
        public string Descricao { get;  set; }
        public int Vagas { get; set; } = 30;
        public bool Ativo { get;  set; }

        public List<Matricula> Matriculas { get; set; }

        public Guid ProfessorId { get; private set; }
        public Professor Professor { get; private set; }

        public DateTime DataInicio { get; set; }

        public static Curso novoCurso(string titulo, string descricao, Professor professor, DateTime dataInicio)
        {
            var curso = new Curso();
            curso.Titulo = titulo;
            curso.Descricao = descricao;
            curso.Professor = professor;
            curso.ProfessorId = professor.Id;
            curso.Ativo = true;
            curso.Matriculas = new List<Matricula>();
            curso.DataInicio = dataInicio;
            return curso;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
