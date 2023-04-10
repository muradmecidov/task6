using ConsoleApp2.NewFolder;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal("male");
            var dog = new Dog("Max", "Golden Retriever", "male");
         Console.WriteLine($"Name: {dog.Name}, Breed: {dog.Breed}, Gender: {dog.Gender}, BirthYear: {dog.BirthYear}");




        }
    }
}