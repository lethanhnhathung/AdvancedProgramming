namespace ConsoleApp4
{
    internal class LaptopStorage : IStorageManagement
    {
        private static LaptopStorage _laptopStorage;
        private LaptopStorage() { }// chỉ có một LaptopStorage
        public static LaptopStorage GetLaptopStorage()
        {
            if (_laptopStorage == null)
            {
                _laptopStorage = new LaptopStorage();
            }
            return _laptopStorage;
        }
        private List<Laptop> _laptops = new List<Laptop>();
        public List<Laptop> GetLaptops()
        {
            return _laptops;
        }
        //crud
        private int IdentityLaptopID()
        {
            int max = 0;
            foreach (Laptop laptop in _laptops)
            {
                if (laptop.Id >= max)
                {
                    max = laptop.Id + 1;
                }
            }
            return max;
        }
        public void AddInformation()
        {
            Laptop laptop = new();
            laptop.Id = IdentityLaptopID();
            laptop.CreateInformation();
            _laptops.Add(laptop);
        }
        public Laptop FindLaptopByID(int id)
        {
            Laptop result = null;
            foreach (Laptop laptop in _laptops)
            {
                if (laptop.Id == id)
                {
                    result = laptop;
                }
            }
            return result;
        }

        public void DeleteInformation()
        {
            Console.Write("Type id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (FindLaptopByID(id) != null)
            {
                _laptops.Remove(FindLaptopByID(id));
            }
            else
            {
                Console.WriteLine("Laptop not found");
            }
        }

        public void DisplayInformation()
        {
            foreach (Laptop laptop in _laptops)
            {
                Console.WriteLine("=============================================");
                laptop.DisplayInformation();
                Console.WriteLine("=============================================");
            }
        }

        public void UpdateInformation()
        {
            Console.Write("Enter Updating laptop's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Laptop laptop = FindLaptopByID(ID);
            if (laptop != null)
            {
                laptop.UpdateInformation();
            }
            else
            {
                Console.WriteLine("No ID found!!!");
            }
        }

    }
}
