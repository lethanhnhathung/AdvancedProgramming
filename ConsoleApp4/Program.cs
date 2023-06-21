using System.Globalization;
using System.Security.Cryptography;

namespace ConsoleApp4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string format = "dd/mm/yyyy";
            ComponentStorage componentStorage = ComponentStorage.GetComponentStorage();
            LaptopStorage laptopStorage = LaptopStorage.GetLaptopStorage();
            ListofLaptopImport laptopImportList = new();
            ListOfComponentImport componentImportList = new();
            Laptop l1 = new Laptop(0, " HP 15", "HP", 1500, "Gaming");
            Laptop l2 = new Laptop(1, "DELL-3", "DELL", 2100, "Office");
            Laptop l3 = new Laptop(2, "Asus ROG", "Asus", 1800, "Gaming");
            laptopStorage.GetLaptops().Add(l1);
            laptopStorage.GetLaptops().Add(l2);
            laptopStorage.GetLaptops().Add(l3);
            Component c1 = new Component(0, "Ram Asus v5", "Asus", 5678, "Ram", "8gb bus 2400hz");
            componentStorage.GetComponents().Add(c1);
            Component c2 = new Component(1, "Ram Asus g4", "Asus", 500, "Ram", "4GB ddr4");
            componentStorage.GetComponents().Add(c2);
            Component c3 = new Component(2, "Ram Asus g8", "Asus", 800, "Ram", "8GB ddr4");
            componentStorage.GetComponents().Add(c3);
            ComponentImport cI1 = new ComponentImport(0, DateTime.ParseExact("06/10/2022", format, provider), 6, c1);
            componentImportList.ComponentImportList.Add(cI1);
            ComponentImport cI2 = new ComponentImport(1, DateTime.ParseExact("04/11/2022", format, provider), 4, c2);
            componentImportList.ComponentImportList.Add(cI2);
            ComponentImport cI3 = new ComponentImport(2, DateTime.ParseExact("20/12/2022", format, provider), 7, c3);
            componentImportList.ComponentImportList.Add(cI3);
            LaptopImport lI1 = new LaptopImport(0, DateTime.ParseExact("12/01/2022", format, provider), 12, l1);
            laptopImportList.LaptopImportList.Add(lI1);
            LaptopImport lI2 = new LaptopImport(1, DateTime.ParseExact("25/09/2022", format, provider), 23, l2);
            laptopImportList.LaptopImportList.Add(lI2);
            LaptopImport lI3 = new LaptopImport(2, DateTime.ParseExact("30/03/2022", format, provider), 16, l3);
            laptopImportList.LaptopImportList.Add(lI3);
            LaptopPart p1 = new LaptopPart(0, c1, 2);
            l1.LaptopPartList.Add(p1);
            LaptopPart p2 = new LaptopPart(1, c2, 2);
            l2.LaptopPartList.Add(p2);
            LaptopPart p3 = new LaptopPart(2, c3, 2);
            l3.LaptopPartList.Add(p3);
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t==========================================");
                Console.WriteLine("\t\t\t\t\t||     Laptop&Component Management!!!   ||");
                Console.WriteLine("\t\t\t\t\t==================******==================");
                Console.WriteLine("\t\t\t\t\t||        1.Laptop management.          ||");
                Console.WriteLine("\t\t\t\t\t||        2.Component management.       ||");
                Console.WriteLine("\t\t\t\t\t||        3.Exit.                       ||");
                Console.WriteLine("\t\t\t\t\t==========================================");
                Console.Write("Choose option: ");
                try
                {


                    int k = Convert.ToInt32(Console.ReadLine());
                    switch (k)
                    {
                        case 1:
                            bool h = true;
                            while (h)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t\t==========================================");
                                Console.WriteLine("\t\t\t\t\t||           Laptop Management!!!       ||");
                                Console.WriteLine("\t\t\t\t\t==================******==================");
                                Console.WriteLine("\t\t\t\t\t||        1.Add Laptop.                 ||");
                                Console.WriteLine("\t\t\t\t\t||        2.Update Laptop.              ||");
                                Console.WriteLine("\t\t\t\t\t||        3.Delete Laptop.              ||");
                                Console.WriteLine("\t\t\t\t\t||        4.Display Laptop.             ||");
                                Console.WriteLine("\t\t\t\t\t||        5.Laptop Part.                ||");
                                Console.WriteLine("\t\t\t\t\t||        6.Import Laptop History.      ||");
                                Console.WriteLine("\t\t\t\t\t||        7.Back.                       ||");
                                Console.WriteLine("\t\t\t\t\t==========================================");
                                Console.Write("Choose option: ");
                                int l = Convert.ToInt32(Console.ReadLine());


                                switch (l)
                                {

                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\t\tADD LAPTOP!!!");
                                        laptopStorage.AddInformation();
                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\t\tUPDATE LAPTOP!!!");
                                        laptopStorage.UpdateInformation();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\t\tUPDATE LAPTOP!!!");
                                        laptopStorage.DeleteInformation();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\tDISPLAY LAPTOP LIST!!!");
                                        laptopStorage.DisplayInformation();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        Console.Write("Enter laptop's ID: ");
                                        int id = Convert.ToInt32(Console.ReadLine());
                                        Laptop laptop = laptopStorage.FindLaptopByID(id);
                                        bool p = true;
                                        while (p)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\t\t\t\t\t==========================================");
                                            Console.WriteLine("\t\t\t\t\t||        1. Add Part.                  ||");
                                            Console.WriteLine("\t\t\t\t\t||        2. Delete Part.               ||");
                                            Console.WriteLine("\t\t\t\t\t||        3. Display Part.              ||");
                                            Console.WriteLine("\t\t\t\t\t||        4. Back.                      ||");
                                            Console.WriteLine("\t\t\t\t\t==========================================");
                                            Console.Write("Choose option: ");
                                            int m = Convert.ToInt32(Console.ReadLine());
                                            switch (m)
                                            {
                                                case 1:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tADD PART!!!");
                                                    laptop.AddComponentInformation();
                                                    Console.WriteLine("Input success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tDELETE PART!!!");
                                                    laptop.DeleteComponentInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tDISPLAY PART!!!");
                                                    laptop.DisplayComponentInformation();
                                                    Console.WriteLine("Display success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    p = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 6:

                                        bool kh = true;
                                        while (kh)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\t\t\t\t\t==========================================");
                                            Console.WriteLine("\t\t\t\t\t||        1. Add Import.                ||");
                                            Console.WriteLine("\t\t\t\t\t||        2. Delete Import.             ||");
                                            Console.WriteLine("\t\t\t\t\t||        3. Display Import.            ||");
                                            Console.WriteLine("\t\t\t\t\t||        4. Back.                      ||");
                                            Console.WriteLine("\t\t\t\t\t==========================================");
                                            Console.Write("Choose option: ");
                                            int m = Convert.ToInt32(Console.ReadLine());
                                            switch (m)
                                            {
                                                case 1:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tADD IMPORT!!!");
                                                    Console.Write("Enter laptop's ID: ");
                                                    int pid = Convert.ToInt32(Console.ReadLine());
                                                    Laptop plaptop = laptopStorage.FindLaptopByID(pid);
                                                    laptopImportList.AddImportInformation(plaptop);
                                                    Console.WriteLine("Input success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tDELETE IMPORT!!!");
                                                    laptopImportList.DeleteImportInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tDISPLAY IMPORT!!!");
                                                    laptopImportList.DisplayImportInformation();
                                                    Console.WriteLine("Display success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    kh = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 7:
                                        h = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 2:
                            bool t = true;
                            while (t)
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\t\t\t==========================================");
                                Console.WriteLine("\t\t\t\t\t||        Component Management!!!       ||");
                                Console.WriteLine("\t\t\t\t\t==================******==================");
                                Console.WriteLine("\t\t\t\t\t||        1.Add Component.              ||");
                                Console.WriteLine("\t\t\t\t\t||        2.Update Component.           ||");
                                Console.WriteLine("\t\t\t\t\t||        3.Delete Component.           ||");
                                Console.WriteLine("\t\t\t\t\t||        4.Display Component.          ||");
                                Console.WriteLine("\t\t\t\t\t||        5.Import Component History.   ||");
                                Console.WriteLine("\t\t\t\t\t||        6.Back.                       ||");
                                Console.WriteLine("\t\t\t\t\t==========================================");
                                Console.Write("Choose option: ");
                                int l = Convert.ToInt32(Console.ReadLine());


                                switch (l)
                                {

                                    case 1:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\t\tADD COMPONENT!!!");
                                        componentStorage.AddInformation();
                                        Console.WriteLine("Input success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 2:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\t\tUPDATE COMPONENT!!!");
                                        componentStorage.UpdateInformation();
                                        Console.WriteLine("Update success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 3:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\t\tDELETE COMPONENT!!!");
                                        componentStorage.DeleteInformation();
                                        Console.WriteLine("Delete success");
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 4:
                                        Console.Clear();
                                        Console.WriteLine("\t\t\t\t\t\tDISPLAY COMPONENT LIST!!!");
                                        componentStorage.DisplayInformation();
                                        Console.WriteLine("Type any key to continue");
                                        Console.ReadKey();
                                        break;
                                    case 5:
                                        bool p = true;
                                        while (p)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("\t\t\t\t\t==========================================");
                                            Console.WriteLine("\t\t\t\t\t||        1. Add Import.                ||");
                                            Console.WriteLine("\t\t\t\t\t||        2. Delete Import.             ||");
                                            Console.WriteLine("\t\t\t\t\t||        3. Display Import.            ||");
                                            Console.WriteLine("\t\t\t\t\t||        4. Back.                      ||");
                                            Console.WriteLine("\t\t\t\t\t==========================================");
                                            Console.Write("Choose option: ");
                                            int m = Convert.ToInt32(Console.ReadLine());
                                            switch (m)
                                            {
                                                case 1:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tADD IMPORT!!!");
                                                    Console.Write("Enter component's ID: ");
                                                    int id = Convert.ToInt32(Console.ReadLine());
                                                    Component component = componentStorage.FindComponentByID(id);
                                                    componentImportList.AddImportInformation(component);
                                                    Console.WriteLine("Input success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tDELETE IMPORT!!!");
                                                    componentImportList.DeleteImportInformation();
                                                    Console.WriteLine("Delete success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    Console.WriteLine("\t\t\t\t\t\t\tDISPLAY IMPORT!!!");
                                                    componentImportList.DisplayImportInformation();
                                                    Console.WriteLine("Display success");
                                                    Console.WriteLine("Type any key to continue");
                                                    Console.ReadKey();
                                                    break;
                                                case 4:
                                                    p = false;
                                                    break;
                                                default:
                                                    Console.WriteLine("Invalid Input");
                                                    break;
                                            }
                                        }
                                        break;
                                    case 6:
                                        t = false;
                                        break;

                                    default:
                                        Console.WriteLine("Invalid Input");
                                        break;
                                }
                            }
                            break;
                        case 3:
                            h = false;
                            return;

                        default:
                            Console.WriteLine("Invalid Input");
                            break;


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                };




            }
        }
    }
}