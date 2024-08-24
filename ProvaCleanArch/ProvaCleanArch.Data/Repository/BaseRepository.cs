namespace ProvaCleanArch.Data.Repository
{
    public class Baserepository<T> where T : class, IEntity
    {
        protected readonly Contexto contexto;
        public Baserepository()
        {
            contexto = new Contexto();
        }

        public void Incluir(T entity)
        {
            contexto.Set<T>().Add(entity);
            contexto.SaveChanges();
        }
        public void Alterar(T entity)
        {
            contexto.Set<T>().Update(entity);
            contexto.SaveChanges();
        }
        public T Selecionar(Guid id)
        {
            return contexto.Set<T>().FirstOrDefault(x => x.Id == id);
        }
        public List<T> SelecionarTudo()
        {
            return contexto.Set<T>().ToList();
        }
        public void Excluir(Guid id)
        {
            var entity = Selecionar(id);
            contexto.Set<T>().Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
