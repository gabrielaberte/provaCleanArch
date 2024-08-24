namespace ProvaCleanArch.Domain.Model
{
    public class Professor
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }

        public Professor(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }
    }
}
