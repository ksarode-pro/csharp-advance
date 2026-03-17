using System.Dynamic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var obj = SingletonService.Instance;
            System.Console.WriteLine(obj.GetDate());

            var obj2 = OldSingletonService.Instance;
            System.Console.WriteLine(obj2.GetDate());
        }
    }

    //Class is sealed so that using derived class, object cannot be created
    public sealed class SingletonService
    {
        //Lazy<T> is a special class in C# that allows lazy initialization of objects. Object is created only when type is acessed.
        //Lazy<T> lazyObj = new Lazy<T>(() => new T());
        private static readonly Lazy<SingletonService> instance = new Lazy<SingletonService>(() => new SingletonService());

        //Public property which grants access to singleton object
        public static SingletonService Instance
        {
            get
            {
                return instance.Value;
            }
        }

        public string GetDate()
        {
            return Convert.ToString(DateTime.Now);
        }
    }

    //Double checking locking mechanism
    public sealed class OldSingletonService
    {
        private static OldSingletonService? _oldSingletonService;
        //Always keep locking object private so that external code cannot access it
        private static object _lockObject = new object();
        public static OldSingletonService Instance
        {
            get
            {
                if (_oldSingletonService == null) //Allow only if object is null - First check
                {
                    lock (_lockObject)
                    {
                        if (_oldSingletonService == null) //Allow only if object is null - Second check if not accessed by any thread
                        {
                            _oldSingletonService = new OldSingletonService(); //object creation inside locked zone
                        }
                    }
                }
                return _oldSingletonService;
            }
        }

        public string GetDate()
        {
            return Convert.ToString(DateTime.Now);
        }
    }

}