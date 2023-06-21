namespace ConsoleApp4
{
    internal class Laptop : Product
    {
        public string Category;
        public List<LaptopPart> LaptopPartList = new();
        public Laptop(int id, string name, string manufacterName, decimal price, string category) 
            : base(id, name, manufacterName, price)
        {
            Category = category;
        }
        public Laptop() { }
        //lapcrud
        public override void CreateInformation()
        {
            base.CreateInformation();
            Console.Write("Type Category: ");
            Category = Console.ReadLine();
        }
        public override void UpdateInformation()
        {
            base.UpdateInformation();
            string category = Console.ReadLine();
            if (category != null && category.Length > 0)
            {
                Category = category;
            }
        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("Category: " + Category);
        }

        //PartCRUD
        private int IdentityLaptopPartID()
        {
            int max = 0;
            foreach (LaptopPart part in LaptopPartList)
            {
                if (part.ID >= max)
                {
                    max = part.ID + 1;
                }
            }
            return max;
        }
        public LaptopPart FindPartByID(int id)
        {

            LaptopPart result = null;
            foreach (LaptopPart part in LaptopPartList)
            {
                if (part.ID == id)
                {
                    result = part;
                }
            }
            return result;
        }
        public void AddComponentInformation()
        {
            LaptopPart part = new();
            part.ID = IdentityLaptopPartID();
            part.CreatePartInformation();
            LaptopPartList.Add(part);
        }
        public void DisplayComponentInformation()
        {
            foreach (LaptopPart part in LaptopPartList)
            {
                Console.WriteLine("=============================================");
                part.DisplayPartInformation();
                Console.WriteLine("=============================================");
            }
        }
        public void DeleteComponentInformation()
        {
            Console.Write("Type Part ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            if (FindPartByID(id) != null)
            {
                LaptopPartList.Remove(FindPartByID(id));
            }
        }

    }
}
