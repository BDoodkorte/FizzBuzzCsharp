// See https://aka.ms/new-console-template for more information

// Call FizzBuzz function as defined in fizzbuzz.cs
Console.WriteLine("Hello World");

Console.WriteLine("Enter your maximum number for FizzBuzz?");
bool validNum = false;
int userMaxNumber = 0;
while(!validNum) {
    if(int.TryParse(Console.ReadLine(), out int answer)) {
        userMaxNumber = answer;
        validNum = true;
    } else { 
        Console.WriteLine("Please enter a valid number");

    }
}

FizzBuzz.FizzBuzzFunc(userMaxNumber);

