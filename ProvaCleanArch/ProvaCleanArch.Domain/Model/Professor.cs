namespace ProvaCleanArch.Domain.Model
{
    public class Professor : IEntity
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public List<Curso> Cursos { get; set; }

        public static Professor novoProfessor(string nome, string email)
        {
            var professor = new Professor();
            professor.Nome = nome;
            professor.Email = email;
            professor.Cursos = new List<Curso>();
            return professor;
        }
    }
}
