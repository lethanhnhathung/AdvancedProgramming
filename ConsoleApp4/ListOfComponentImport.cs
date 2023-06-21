namespace ConsoleApp4
{
    internal class ListOfComponentImport
    {
        public List<ComponentImport> ComponentImportList = new();

        //importCRUD
        public int IdentityComponentImportID()
        {
            int max = 0;
            foreach (ComponentImport bill in ComponentImportList)
            {
                if (bill.ID >= max)
                {
                    max = bill.ID + 1;
                }
            }
            return max;
        }
        public void AddImportInformation(Component component)
        {
            ComponentImport newComponentImport = new();
            newComponentImport.ID = IdentityComponentImportID();
            newComponentImport.Component = component;
            newComponentImport.CreateInformation();
            ComponentImportList.Add(newComponentImport);
        }
        public ComponentImport FindByImportID(int id)
        {

            ComponentImport result = null;
            foreach (ComponentImport bill in ComponentImportList)
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
            Console.Write("Enter deleting ComponentImport's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            ComponentImport componentImport = FindByImportID(ID);
            if (componentImport != null)
            {
                ComponentImportList.Remove(componentImport);
            }
        }
        public void DisplayImportInformation()
        {
            foreach (ComponentImport bill in ComponentImportList)
            {
                Console.WriteLine("=============================================");
                bill.Note();
                bill.DisplayInformation();
                Console.WriteLine("=============================================");
            }
        }
    }
}
