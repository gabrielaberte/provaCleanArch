namespace ProvaCleanArch.Domain.Model
{
    public class Aluno : IEntity
{
    public Guid Id { get;  set; }
    public string Nome { get;  set; }
    public string Email { get;  set; }
    public string Endereco { get;  set; }
    public bool Ativo { get;  set; }

    public static Aluno NovoAluno(string nome, string email, string endereco)
    {
        var aluno = new Aluno();
        aluno.Nome = nome;
        aluno.Email = email;
        aluno.Endereco = endereco;
        aluno.Ativo = true;
            return aluno;
    }

    public Aluno Desativar()
    {
        Ativo = false;
        return this;
    }
}

}
