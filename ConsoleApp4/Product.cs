using System.Globalization;

namespace ConsoleApp4
{
    public class Product
    {
        public CultureInfo provider = CultureInfo.InvariantCulture;
        public string format = "dd/mm/yyyy";
        private int _id;
        private string _name;
        private string _manufacturerName;
        private decimal _price;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string ManufacturerName { get { return _manufacturerName; } set { _manufacturerName = value; } }
        public decimal Price { get { return _price; } set { _price = value; } }

        public Product(int id, string name, string manufacturerName, decimal price)
        {
            _id = id;
            _name = name;
            _manufacturerName = manufacturerName;
            _price = price;
        }
        public Product() { }

        public virtual void CreateInformation()
        {
            Console.Write("Type Product Name: ");
            Name = Console.ReadLine();
            Console.Write("Type Product Manufacturer: ");
            ManufacturerName = Console.ReadLine();
            Console.Write("Type Product Price: ");
            Price = decimal.Parse(Console.ReadLine());
        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine("ID: " + _id);
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Manufacturer: " + _manufacturerName);
            Console.WriteLine("Price: " + _price);
        }
        public virtual void UpdateInformation()
        {
            Console.WriteLine("Updating (Enter to skip update): ");
            Console.Write("Update name: ");
            string name = Console.ReadLine();
            if (name != null && name.Length > 0)
            {
                Name = name;
            }
            Console.Write("Update Manufacturer: ");
            string manufacturerName = Console.ReadLine();
            if (manufacturerName != null && manufacturerName.Length > 0)
            {
                ManufacturerName = manufacturerName;
            }
            Console.Write("Update Price: ");
            string price = Console.ReadLine();
            if (price != null && price.Length > 0)
            {
                Price = decimal.Parse(price);
            }
        }
    }
}
