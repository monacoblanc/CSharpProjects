using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;


namespace MyfirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            AnotherCSharpProgram anotherCSharpProgram = new AnotherCSharpProgram();
            anotherCSharpProgram.AreaFormula(); //Public void. Method that can be used by objects of AnotherCSharpProgram.
            AnotherCSharpProgram.Hello(); //Public static void. Method that belongs to the class itself.*/
            /*String AnimalName = "Persian Cat James";
            Animal.Eat(AnimalName);

            Cat PersianCat = new Cat();
            PersianCat.Meow();*/

            //double orders = new double[3];

            int CartQuantity = 0;
            bool ContinueShopping = true;


            StoreInventory[] inventory = {
                new StoreInventory("Saba Banana", 10 /*price*/, 20 /*qty on hand*/),
                new StoreInventory("Fuji Apple", 15 /*price*/, 30 /*qty on hand*/)
            };


            while (ContinueShopping)
            {
                Console.WriteLine("What would you like to order today [Saba Banana, Fuji Apple]? ");
                var order1 = Console.ReadLine();

                if (order1 != null)
                {
                    var item = inventory.FirstOrDefault(i => i.ProductName.Equals(order1, StringComparison.OrdinalIgnoreCase));
                    if (item != null)
                    {
                        Console.WriteLine($"You ordered: {item.ProductName}");
                        CartQuantity++;
                    }
                    else
                    {
                        Console.WriteLine("Item not found in inventory.");
                    }
                }

                Console.WriteLine("Would you like to continue shopping (yes/no)? ");
                var response = Console.ReadLine();
                if (response == null || !response.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                    ContinueShopping = false;
                }
            }

            //Console.WriteLine(inventory[0].Price);
            Console.WriteLine($"Cart Quantity: {CartQuantity}");


            //Next Goals:
            //Goal 1: Compute the total of the items in the cart.
            //Goal 2: Display the names of the items in the cart with their prices, quantities, and sub total price.
            //Goal 3: Display the grand total price of the cart.


            //var total = POS.ComputeTotal(10.0, 20.0, 30.0, 40.0);


        }
    }
}