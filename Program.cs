// See https://aka.ms/new-console-template for more information

// Ask user for length of FizzBuzz exercise
Console.WriteLine("Enter your maximum number for FizzBuzz?");
bool validNum = false;
int userMaxNumber = 0;
while (!validNum)
{
    if (int.TryParse(Console.ReadLine(), out int answer))
    {
        userMaxNumber = answer;
        validNum = true;
    }
    else
    {
        Console.WriteLine("Please enter a valid number");

    }
}

// Ask user which rules to implement
bool[] activatedRules = { false, false, false, false, false, false };
bool choosingRules = true;
while (choosingRules)
{
    Console.WriteLine("Please enter a rule to add, or exit by typing N:");
    Console.WriteLine("Rule 1: Fizz  /nl Rule 2: Buzz /nl Rule 3: Bang /nl Rule 4: Bong /nl 5: Fezz  6: Reverse");
    var response = Console.ReadLine();
    if (response == "N")
    {
        choosingRules = false;
    }
    else if (int.TryParse(response, out int answer))
    {
        activatedRules[answer - 1] = true;
    }
    if (!activatedRules.Contains(false))
    {
        choosingRules = false;
        Console.WriteLine("You've activated all rules!");
    }
}

// Call FizzBuzz function as defined in fizzbuzz.cs
FizzBuzz.FizzBuzzFunc(userMaxNumber, activatedRules);

