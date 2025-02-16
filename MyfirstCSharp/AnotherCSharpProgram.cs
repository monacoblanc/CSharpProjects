using System;
using System.Security.Cryptography.X509Certificates;

public class AnotherCSharpProgram
{
    public void AreaFormula()
    {

        Console.WriteLine("Enter an option [1. Area of Square\n2.Area of Rectangle]: ");
        var option = Console.ReadLine();

        switch (option) {
            case "1":
                Console.WriteLine("Enter the side of the square: ");
                var side = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The area of the square is: " + side * side);
                break;

            case "2":
                Console.WriteLine("Enter the length of the rectangle: ");
                var length = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle: ");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The area of the rectangle is: " + length * width);
                break;

            case "3":
                Random random = new Random();
                int[] GrandLotto = new int[6]; //Assigning empty array of 6 elements

                for (int i = 0; i < GrandLotto.Length; i++)
                {
                    int LottoMachine;
                    do
                    {
                        LottoMachine = random.Next(0, 58); // Generates numbers between 0 and 58 inclusive. Change 60 if needed.
                    } while (GrandLotto.Contains(LottoMachine)); // Check if the number is already in GrandLotto

                    GrandLotto[i] = LottoMachine; // Add the unique number to the array
                }

                Console.WriteLine("Grand Lotto numbers:");
                Console.WriteLine(string.Join(", ", GrandLotto));
                break;

        }


    }

    public static void Hello()
    { /*This is a method of specifically to class AnotherCSharpProgram*/
        Console.WriteLine("Hello World!");
    }
}

public class POS {

    public static double ComputeTotal(params double[] prices)
    //params keyword allows you to pass a variable number of arguments to a method.
    //This is a general blueprint of the class POS.
    //This is a method that belongs to the class itself. To identify this, the keyword static is used.
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }
        return total;
    }
}


public class StoreInventory
{
    public string ProductName { get; set; }
    public int Price { get; set; }
    public int Quantity { get; set; }
    public StoreInventory(string productName, int price, int quantity)
    {
        ProductName = productName;
        Price = price;
        Quantity = quantity;
    }
    public int ComputeTotal()
    {
        return Price * Quantity;
    }
}
