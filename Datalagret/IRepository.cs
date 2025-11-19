namespace Datalagret
{
    public interface IRepository<T>
    {
        void Add(T item);

        List<T> GetAll();

        T? GetById(string id);

        bool Update(T item);

        bool Delete(T item);
    }
}
