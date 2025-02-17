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

            int CartCounter = 0;
            List<(string ProductName, int Price, int Quantity)> CartItems = new List<(string, int, int)>();
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
                        Console.WriteLine("Enter quantity: ");
                        if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0)
                        {
                            var existingItemIndex = CartItems.FindIndex(ci => ci.ProductName == item.ProductName);
                            if (existingItemIndex >= 0)
                            {
                                var existingItem = CartItems[existingItemIndex];
                                CartItems[existingItemIndex] = (existingItem.ProductName, existingItem.Price, existingItem.Quantity + quantity);
                            }
                            else
                            {
                                CartItems.Add((item.ProductName, item.Price, quantity));
                                CartCounter++;
                            }
                            Console.WriteLine($"You ordered: {item.ProductName} - {quantity} pcs");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity.");
                        }
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

            Console.WriteLine("Cart Items:");
            int grandTotal = 0;


            foreach (var cartItem in CartItems)
            {
                int subTotal = cartItem.Price * cartItem.Quantity;
                grandTotal += subTotal;
                Console.WriteLine($"{cartItem.ProductName} {cartItem.Price} pesos * {cartItem.Quantity} Sub Total {subTotal}");
            }
            Console.WriteLine($"Grand Total: {grandTotal} pesos");


        }
    }
}