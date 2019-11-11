using System;

namespace ObjectClass
{

    public class Item{
        
		public String name;
		public double price;
		public bool onSale;
		
		public void print(){
			if(onSale)
				price = price - price * 0.2;
			
			Console.Write("{0} ({1})", name, price);
		}
	}

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
