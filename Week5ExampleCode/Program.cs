public class Week5ExampleCode
{
    public FizzBuzz CalculateFizzBuzz(int numberToTest)
    {
        if (numberToTest % 3 == 0 && numberToTest % 5 == 0)
            return FizzBuzz.FizzBuzz;
        else if (numberToTest % 3 == 0)
            return FizzBuzz.Fizz;
        else if (numberToTest % 5 == 0)
            return FizzBuzz.Buzz;
        else
            return FizzBuzz.Default;
            
    }
}

public enum FizzBuzz
{
    Default,
    Fizz,
    Buzz,
    FizzBuzz
}