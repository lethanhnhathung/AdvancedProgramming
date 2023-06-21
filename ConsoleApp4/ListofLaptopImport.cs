namespace ConsoleApp4
{
    internal class ListofLaptopImport
    {
        public List<LaptopImport> LaptopImportList = new();
        //importCRUD
        int IdentityLaptopImportID()
        {
            int max = 0;
            foreach (LaptopImport bill in LaptopImportList)
            {
                if (bill.ID >= max)
                {
                    max = bill.ID + 1;

                }
            }
            return max;
        }
        public void AddImportInformation(Laptop laptop)
        {
            LaptopImport newLaptopImport = new();
            newLaptopImport.ID = IdentityLaptopImportID();
            newLaptopImport.Laptop = laptop;
            newLaptopImport.CreateInformation();
            LaptopImportList.Add(newLaptopImport);
        }

        public LaptopImport FindImportByID(int id)
        {

            LaptopImport result = null;
            foreach (LaptopImport bill in LaptopImportList)
            {
                if (bill.ID == id)
                {
                    result = bill;
                }
            }
            return result;
        }

        public void DeleteImportInformation()
        {
            Console.Write("Enter deleting LaptopImport's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            LaptopImport laptopImport = FindImportByID(ID);
            if (laptopImport != null)
            {
                LaptopImportList.Remove(laptopImport);
            }
        }
        public void DisplayImportInformation()
        {
            foreach (LaptopImport bill in LaptopImportList)
            {
                Console.WriteLine("=============================================");
                bill.Note();
                bill.DisplayInformation();
                Console.WriteLine("=============================================");
            }
        }
    }
}
