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
                        if (int.TryParse(Console.ReadLine(), out int quantity) && quantity > 0) //TryParse returns a boolean value that indicates whether the conversion succeeded. If the conversion succeeded, the return value is true and will carry whatever value is converted to the out parameter. IF not, it will return false. Then , the program will proceed to the next condition and it will return a value of 0.
                        {
                            CartItems.Add((item.ProductName, item.Price, quantity));
                            Console.WriteLine($"You ordered: {item.ProductName} - {quantity} pcs");
                            CartCounter++;
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



            //Next Goals:
            //Goal 1: Compute the total of the items in the cart.
            //Goal 2: Display the names of the items in the cart with their prices, quantities, and sub total price.
            //Goal 3: Display the grand total price of the cart.


            //var total = POS.ComputeTotal(10.0, 20.0, 30.0, 40.0);


        }
    }
}