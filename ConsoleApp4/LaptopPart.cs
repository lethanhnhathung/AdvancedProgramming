namespace ConsoleApp4
{
    internal class LaptopPart
    {
        public int ID;
        public Component? LaptopComponent;
        public int Quantity;

        public LaptopPart()
        {
        }

        public LaptopPart(int iD, Component? laptopComponent, int quantity)
        {
            ID = iD;
            LaptopComponent = laptopComponent;
            Quantity = quantity;
        }

        public void CreatePartInformation()
        {

            ComponentStorage storage = ComponentStorage.GetComponentStorage();
            Console.Write("Type Component ID: ");
            int componentID = int.Parse(Console.ReadLine());
            if (storage.FindComponentByID(componentID) != null)
            {
                LaptopComponent = storage.FindComponentByID(componentID);
                Console.Write("Type quantity in this laptop: ");
                Quantity = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Couldn't find component");
            }
        }
        public void DisplayPartInformation()
        {
            Console.WriteLine("==============================");
            Console.WriteLine("Product ID: " + ID);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Component in Laptop: ");
            LaptopComponent.DisplayInformation();
        }
    }
}
