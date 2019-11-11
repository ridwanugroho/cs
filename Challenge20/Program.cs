using System;

namespace ObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make this code works by create new class, method, and property.
            Item item = new Item();
            item.name = "Indomie Goreng";
            item.price = 3500;
            item.onSale = true; // If true the price will drop 20%

            item.print(); // Output: "Indomie Goreng (Rp2800)"
        }
    }
}
