namespace GenericRepository
{
    /// <summary>
    /// A class to maintain generic data repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class GenericRepo<T>
    {
        public List<T> GetAll()
        {
            return new List<T>();
        }

        public T Get(int id)
        {
            return default(T);
        }

        public void Add(T entity)
        {
            System.Console.WriteLine($"{entity} is added"); 
        }

        public void Update(T entity)
        {
            System.Console.WriteLine($"{entity} is updated");
        }

        public void Delete(int id)
        {
            System.Console.WriteLine($"{id} is deleted");
        }
    
    }
}
