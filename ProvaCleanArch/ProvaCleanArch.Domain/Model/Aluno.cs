namespace ProvaCleanArch.Domain.Model
{
    public class Aluno : IEntity
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Endereco { get; private set; }
    public bool Ativo { get; private set; }

    public List<Matricula> Matriculas;

    public Aluno(Guid id, string nome, string email, string endereco)
    {
        Id = id;
        Nome = nome;
        Email = email;
        Endereco = endereco;
        Ativo = true;
        Matriculas = new List<Matricula>();
    }

    public void Desativar()
    {
        Ativo = false;
    }
}

}
