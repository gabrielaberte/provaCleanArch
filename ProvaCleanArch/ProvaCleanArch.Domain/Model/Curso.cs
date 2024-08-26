namespace ProvaCleanArch.Domain.Model
{
    public class Curso : IEntity
    {
        public Guid Id { get;  set; }
        public string Titulo { get;  set; }
        public string Descricao { get;  set; }
        public int Vagas { get; set; } = 30;
        public bool Ativo { get; set; } = true;
        public Guid ProfessorId { get; set; }
        public Professor Professor { get; set; }
        public DateTime DataInicio { get; set; }
        public List<Matricula> Matriculas { get; set; }

        public Curso(string titulo, string descricao, Guid professorId, DateTime dataInicio)
        {
            Titulo = titulo;
            Descricao = descricao;
            ProfessorId = professorId;
            DataInicio = dataInicio;
            Matriculas = new List<Matricula>();
        }

        public void SetProfessor(Professor professor)
        {
            ProfessorId = professor.Id;
            Professor = professor;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
