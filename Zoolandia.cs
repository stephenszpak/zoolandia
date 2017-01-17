using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
         public static void Main(string[] args)
        {
            var newAnimal = new Animal();
            newAnimal.name = "Test This Name";
            newAnimal.funimals();

            var newRedPanda = new AilurusFulgens();
            newRedPanda.name = "Rosco";
            newRedPanda.size = "small";
            newRedPanda.color = "whachu think";
            newRedPanda.UniqueAttribute = "raccoon like tail";
            newRedPanda.funimals();

            //Console.WriteLine($"this cute RedPanda's name is {newRedPanda.name} and is relativily {newRedPanda.size} and its color issss {newRedPanda.color} and has a {newRedPanda.UniqueAttribute}");

            var newElephant = new Elephant();
            newElephant.name = "Dumbo";
            newElephant.size = "enormous";
            newElephant.color = "gray";
            newElephant.UniqueAttribute = "trunk for a nose";
            newElephant.funimals();

           //Console.WriteLine($"this cute Elephant's name is {newElephant.name} and is relativily {newElephant.size} and its color issss {newElephant.color} and has a {newElephant.UniqueAttribute}");

            var newLion = new Lion();
            newLion.name = "Simba";
            newLion.size = "large";
            newLion.color = "tan/brown";
            newLion.UniqueAttribute = "mane";
            newLion.funimals();

            //Console.WriteLine($"this cute newLion's name is {newLion.name} and is relativily {newLion.size} and its color issss {newLion.color} and has a {newLion.UniqueAttribute}");
        }
    }
}