using System.Globalization;

namespace ConsoleApp4
{
    internal abstract class ProductImport
    {
        public CultureInfo provider = CultureInfo.InvariantCulture;
        public string format = "dd/mm/yyyy";
        public int ID;
        public DateTime DateImport;
        public int Quantity;

        public ProductImport(int id, DateTime dateImport, int quantity)
        {
            ID = id;
            DateImport = dateImport;
            Quantity = quantity;
        }
        public ProductImport() { }


        public abstract void Note();
        public abstract void CreateInformation();
        public abstract void DisplayInformation();
    }
}
