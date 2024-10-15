namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Dell", "Gaming Laptop", 5, 1200, 16, 512);

            notebook.Sale();

            notebook.ShowFullData();

            notebook.Count = 0;
            notebook.ShowFullData();
        }
    }
    class Product
    {
        public string Name;
        public string Description;
        public int Count;
        public bool IsStock;
        public double Price;

        public Product(string name, string description, int count, double price)
        {
            if (name != null && count > 0 && price > 0)
            {
                Name = name;
                Description = description;
                Count = count;
                Price = price;
                IsStock = count > 0;
            }
        }

        public void Sale()
        {
            if (Count > 0)
            {
                Count--;
                IsStock = Count > 0;
                Console.WriteLine("Mehsul satildi.");
            }
            else
            {
                Console.WriteLine("Mehsul yoxdur!");
            }
        }
    }
    class Notebook : Product
    {
        public byte RAM;
        public int Storage;

        public Notebook(string name, string description, int count, double price, byte ram, int storage):base(name, description, count, price)
        {
            if (ram > 0 && storage > 0)
            {
                RAM = ram;
                Storage = storage;
            }
        }

        public void GetFullInfo()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Count: {Count}, Price: {Price}, RAM: {RAM}GB, Storage: {Storage}GB");
        }
        public void ShowFullData()
        {
            if (IsStock)
            {
                GetFullInfo();
            }
            else
            {
                Console.WriteLine("Mehsul yoxdur!");
            }
        }
    }
}
