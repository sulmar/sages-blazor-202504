namespace BlazorServerApp.Abstractions;

// Szablon interfejsu
public interface IEntityRepository<T>
{
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Update(T entity);
}


