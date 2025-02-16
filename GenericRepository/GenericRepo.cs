using Entity;

namespace GenericRepository
{
    /// <summary>
    /// A class to maintain generic data repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepo<T>
    {
        public List<T> GetAll()
        {
            return new List<T>();
        }

        public T Get(int entity_id)
        {
            return default(T);
        }

        public void Add(T entity)
        {
            System.Console.WriteLine($"{typeof(T)} entity added");
        }

        public void Update(T entity)
        {
            System.Console.WriteLine($"{typeof(T)} entity updated");
        }

        public void Delete(int entity_id)
        {
            System.Console.WriteLine($"{typeof(T)} entity deleted");
        }

    }
}
