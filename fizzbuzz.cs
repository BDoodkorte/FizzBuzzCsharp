// In C# functions/methods must exist inside a class. 
internal class FizzBuzz
{
    // Define function that prints fizzbuzz. 
    public static void FizzBuzzFunc()
    {
        for (int counter = 0; counter <= 100; counter++)
        {
            if (counter % 3 != 0 && counter % 5 != 0 && counter % 7 != 0 && counter % 11 != 0)
            {
                Console.WriteLine(counter);
            }
            else
            {
                Console.WriteLine((counter % 3 != 0 ? "" : "fizz") + (counter % 5 != 0 ? "" : "buzz") + (counter % 7 != 0 ? "" : "bang") + (counter % 11 != 0 ? "" : "boink"));
            }
        }
    }
}
