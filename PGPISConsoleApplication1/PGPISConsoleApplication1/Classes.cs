namespace namespace_Panda
{
    public class Panda
    {
        public string Name;
        public static int Population;
        public int Population_instance;

        public Panda(string n)      //Constructor
        {
            Name = n;
            Population = Population + 1;
            Population_instance = Population_instance + 1;
        }
    }
}
namespace namespace_Dude
{
    public class Dude
    {
        public string Name;
        public Dude(string n)      //Constructor
        {
            Name = n;
        }
        public void DudeSetName(string newName)     //Method
        {
            Name = newName;
        }
    }
}

