namespace CoffeeMachineProject;

public interface IRepository<TKey, TEntity>
{
    TKey Add(TEntity entity);
    TEntity? Get(TKey id);
    bool Remove(TEntity entity);
}