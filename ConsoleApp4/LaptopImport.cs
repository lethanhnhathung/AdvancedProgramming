
namespace ConsoleApp4
{
    internal class LaptopImport : ProductImport
    {
        public Laptop? Laptop;
        public LaptopImport(int id, DateTime dateImport, int quantity, Laptop? laptop) 
            : base(id, dateImport, quantity)
        {
            Laptop = laptop;
        }
        public LaptopImport() { }
        public override void CreateInformation()
        {
            Console.Write("Type Date Import: ");
            string importDate = Console.ReadLine();
            DateImport = DateTime.ParseExact(importDate, format, provider);
            Console.Write("Type Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
        }
        public override void DisplayInformation()
        {
            Console.WriteLine("Laptop Import ID: " + ID);
            Console.WriteLine("Laptop Import Quantity: " + Quantity);
            Console.WriteLine("Laptop Import Date: " + DateImport.ToString("dd/mm/yyyy"));
            Console.WriteLine("Laptop name: " + Laptop?.Name);
        }

        public override void Note()
        {
            Console.WriteLine("{0} Laptop {1} is imported on {2}.", Quantity, Laptop?.Name, DateImport.ToString("dd/mm/yyyy"));
        }
    }
}
