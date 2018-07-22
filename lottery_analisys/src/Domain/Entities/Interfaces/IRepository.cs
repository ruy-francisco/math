namespace Domain.Entities.Interfaces
{
    public interface IRepository<T>
    {
        T GetById(int id);
    }
}