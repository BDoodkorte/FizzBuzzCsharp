// In C# functions/methods must exist inside a class. 
internal class FizzBuzz
{
    // Define function that prints fizzbuzz. 
    public static void FizzBuzzFunc(int maxNumber)
    {
        for (int counter = 0; counter <= maxNumber; counter++)
        {
            Console.WriteLine(
              counter % 3 != 0 && counter % 5 != 0 && counter % 7 != 0 && counter % 11 != 0 && counter % 13 != 0
              ?
              counter
              :
                counter % 17 != 0
                ?
                (counter % 3 != 0 ? "" : "fizz") + (counter % 13 != 0 ? "" : "fezz") + (counter % 5 != 0 ? "" : "buzz") + (counter % 7 != 0 ? "" : "bang") + (counter % 11 != 0 ? "" : "bong")
                : 
                  ((counter % 11 != 0 ? "" : "bong") + (counter % 7 != 0 ? "" : "bang") + (counter % 5 != 0 ? "" : "buzz") + (counter % 13 != 0 ? "" : "fezz") + (counter % 3 != 0 ? "" : "fizz")));
        }
    }
}

