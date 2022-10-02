using System;
using System.Collections.Generic;

namespace RandomWithRate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items.Add(new Item() { Name = "Anna", Rate = 10});
            items.Add(new Item() { Name = "Alex", Rate = 20});
            items.Add(new Item() { Name = "Dog", Rate = 150});
            items.Add(new Item() { Name = "Cat", Rate = 30});

            Item newItem = ProportionalWheelSelection.SelectItem(items);
            Console.WriteLine(newItem.Name);
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public int Rate { get; set; }
    }
}