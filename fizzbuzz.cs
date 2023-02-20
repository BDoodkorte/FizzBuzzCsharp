// In C# functions/methods must exist inside a class. 
internal class FizzBuzz
{
    // Define function that prints fizzbuzz. 
    public static void FizzBuzzFunc(int maxNumber,
        bool[] rulesArray)
    {        
        // Define rule variable names
        bool fizzActive = rulesArray[0];
        bool buzzActive = rulesArray[1];
        bool bangActive = rulesArray[2];
        bool bongActive = rulesArray[3];
        bool fezzActive = rulesArray[4];
        bool reverseActive = rulesArray[5];
        
        for (int counter = 1; counter <= maxNumber; counter++)
        {
            Console.WriteLine(
              (counter % 3 != 0 || !fizzActive) && (counter % 5 != 0 || !buzzActive) && (counter % 7 != 0 || !bangActive) && (counter % 11 != 0 || !bongActive) && (counter % 13 != 0 || !fezzActive)
              ?
              counter
              :
                (counter % 17 != 0 && !reverseActive) 
                ?
                ((counter % 3 != 0 || !fizzActive)? "" : "fizz") + (counter % 13 != 0  || !fezzActive? "" : "fezz") + (counter % 5 != 0 || !buzzActive ? "" : "buzz") + (counter % 7 != 0 || !bangActive ? "" : "bang") + (counter % 11 != 0 || !bongActive ? "" : "bong")
                :
                  ((counter % 11 != 0 || !bongActive? "" : "bong") + (counter % 7 != 0 || !bangActive? "" : "bang") + (counter % 5 != 0 || !buzzActive ? "" : "buzz") + (counter % 13 != 0 || !fezzActive? "" : "fezz") + (counter % 3 != 0 || !fizzActive ? "" : "fizz")));
        }
    }
}

