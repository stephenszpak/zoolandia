using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
         public static void Main(string[] args)
        {
            var RedPanda = new AilurusFulgens();
            RedPanda.name = "Rosco";
            RedPanda.size = "small";
            RedPanda.color = "whachu think";
            RedPanda.UniqueAttribute = "raccoon like tail";

            var Elephant = new Elephant();
            Elephant.name = "Dumbo";
            Elephant.size = "enormous";
            Elephant.color = "gray";
            Elephant.UniqueAttribute = "trunk for a nose";

            var Lion = new Lion();
            Lion.name = "Simba";
            Lion.size = "large";
            Lion.color = "tan/brown";
            Lion.UniqueAttribute = "mane";

          Console.WriteLine($"this cute RedPanda's name is {RedPanda.name} and is relativily {RedPanda.size} and its color issss {RedPanda.color} and has a {RedPanda.UniqueAttribute}");

          Console.WriteLine($"this cute Elephant's name is {Elephant.name} and is relativily {Elephant.size} and its color issss {Elephant.color} and has a {Elephant.UniqueAttribute}");

          Console.WriteLine($"this cute Lion's name is {Lion.name} and is relativily {Lion.size} and its color issss {Lion.color} and has a {Lion.UniqueAttribute}");
        }
    }
}