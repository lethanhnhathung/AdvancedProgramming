namespace ConsoleApp4
{
    internal class ComponentStorage : IStorageManagement
    {
        private static ComponentStorage _componentStorage;
        private ComponentStorage() { }
        public static ComponentStorage GetComponentStorage()
        {
            if (_componentStorage == null)
            {
                _componentStorage = new ComponentStorage();
            }
            return _componentStorage;
        }
        private List<Component> _components = new();
        public List<Component> GetComponents()
        {
            return _components;
        }
        private int IdentityComponentID()
        {
            int max = 0;
            foreach (Component component in _components)
            {
                if (component.Id >= max)
                {
                    max = component.Id + 1;
                }
            }
            return max;
        }
        public void AddInformation()
        {
            Component component = new();
            component.Id = IdentityComponentID();
            component.CreateInformation();
            _components.Add(component);
        }
        public Component FindComponentByID(int id)
        {
            Component result = null;
            foreach (Component component in _components)
            {
                if (component.Id == id)
                {
                    result = component;
                }
            }
            return result;
        }

        public void DeleteInformation()
        {
            Console.Write("Enter deleting Component's ID: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            Component component = FindComponentByID(ID);
            if (component != null)
            {
                _components.Remove(component);
            }
        }

        public void DisplayInformation()
        {
            foreach (Component component in _components)
            {
                Console.WriteLine("=============================================");
                component.DisplayInformation();
                Console.WriteLine("=============================================");
            }
        }

        public void UpdateInformation()
        {
            Console.Write("Type ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Component component = FindComponentByID(id);
            if (component != null)
            {
                component.UpdateInformation();
            }
            else
            {
                Console.WriteLine("Couldn't found Component!!");
            }
        }
    }
}
