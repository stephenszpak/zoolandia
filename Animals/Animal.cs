using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }
        public string size { get; set; }
        public string color { get; set; }
        public string UniqueAttribute { get; set; }
        public virtual void funimals()
        {
            Console.WriteLine("waiT WHAT!");
        }
        
    }
}