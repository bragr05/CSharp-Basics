class LambdaExpressions
{
    public static void execution()
    {
        // Declaration  form #1
        Func<int, int, int> subtract = (a, b) => a - b;

        // Declaration form #2
        Func<string, string> greetings = (name) =>
        {
            return "Hello " + name;
        };

        // When using the "Multiply" function to send the required function as a parameter, a lambda expression can be used
        Multiply((a, b) => a * b, 4);
    }

    // This is a higher order function
    private static void Multiply(Func<int, int, int> fn, int number)
    {
        var result = fn(number, number);
    }
}