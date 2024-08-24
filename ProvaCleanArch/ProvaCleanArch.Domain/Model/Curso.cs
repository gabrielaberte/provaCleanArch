namespace ProvaCleanArch.Domain.Model
{
    public class Curso
    {
        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Vagas { get; set; } = 30;
        public bool Ativo { get; private set; }

        public List<Matricula> Matriculas { get; set; }

        public int ProfessorId { get; private set; }
        public Professor Professor { get; private set; }

        public DateTime DataInicio { get; set; }

        public Curso(int id, string titulo, string descricao, int vagas, Professor professor, DateTime dataInicio)
        {
            Id = id;
            Titulo = titulo;
            Descricao = descricao;
            Vagas = vagas;
            Professor = professor;
            ProfessorId = professor.Id;
            Ativo = true;
            Matriculas = new List<Matricula>();
            DataInicio = dataInicio;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}
