using System;

namespace Program9new
{
    public class dog
    {
        private string name;
        private string breed;
        public dog()
        {
            Console.WriteLine("Bark!");
        }
        public dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
            PrintAll();
        }
        public void PrintAll()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Breed: " + breed);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Puppy";
            string breed = "Pug";
            var dog = new dog(name, breed);
            Console.WriteLine("Do you want to change info about this dog ?(yes/no)");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Name: ");
                name = Console.ReadLine();
                Console.WriteLine("Breed: ");
                breed = Console.ReadLine();
                Console.WriteLine("Info updated: ");
                dog = new dog(name, breed);

            }
            else
            {
                Console.WriteLine("The end");
            }
            new dog();
            Console.WriteLine();
            Console.WriteLine("Another one dog:");
            var dog2 = new dog("Big boy", "bulldog");
            new dog();

        }
    }
}
