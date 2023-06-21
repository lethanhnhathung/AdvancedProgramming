namespace ConsoleApp4
{
    internal class ComponentImport : ProductImport
    {
        public Component? Component;
        public ComponentImport(int id, DateTime dateImport, int quantity, Component? component) 
            : base(id, dateImport, quantity)
        {
            Component = component;
        }
        public ComponentImport() { }

        public override void Note()
        {
            Console.WriteLine("{0} component {1} is imported on {2}.", Quantity, Component?.Name, DateImport.ToString("dd/mm/yyyy"));
        }
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
            Console.WriteLine("Component Import ID: " + ID);
            Console.WriteLine("Component Import Quantity: " + Quantity);
            Console.WriteLine("Component Import Date: " + DateImport.ToString("dd/mm/yyyy"));
            Console.WriteLine("Component Name: " + Component?.Name);
        }
    }
}
