namespace AspNetCore_Example.Services
{
    public class DatabaseService
    {
        private static readonly DatabaseService _db;

        private DatabaseService() 
        {
            Console.WriteLine($"{nameof(DatabaseService)} is created.");
        }
        static DatabaseService()
        {
            _db = new DatabaseService();
        }
        public static DatabaseService GetDbInstance { 
            get
            {
                return _db;
            } 
        }
        public int Count { get; set; } = 1;
        public bool Conntection()
        {
            Count++;
            Console.WriteLine("connected.");
            return true;
        }
        public bool Disconntection()
        {
            
            Console.WriteLine("Disconnected.");
            return true;
        }

    }
}
