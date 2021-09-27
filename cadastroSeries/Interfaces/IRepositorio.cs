using System.Collections.Generic;

namespace cadastroSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Show();
        T GetById(int id);
        void Insert(T entidade);
        void Delete(int id);
        void Update(int id, T entidade);
        int NextId();
    }
}