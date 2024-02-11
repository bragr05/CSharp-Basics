class Delegates
{

    public void DelegateFunc()
    {
        // Define a Func delegate that takes two numbers and returns the sum
        Func<int, int, int> sum = (a, b) => a + b;

        // Function using the Func delegate to add two numbers together
        int Add(int x, int y)
        {
            return sum(x, y);
        }

        int resultado = Add(3, 5);
    }

    public void DelegateAction()
    {
        // Define an Action delegate that prints a message
        Action<string> printMessage = message => Console.WriteLine(message);

        // Function that uses the delegate Action to print a message
        void Print(string mensaje)
        {
            printMessage(mensaje);
        }

        Print("Hola mundo!");
    }

    public void DelegatePredicate()
    {
        // Define a Predicate delegate that checks whether a number is even
        Predicate<int> isEven = num => num % 2 == 0;

        // Function that uses the Predicate delegate to check if a number is an even number
        bool IsEven(int numero)
        {
            return isEven(numero);
        }

        bool isEvenResult = IsEven(4);
    }

    public void DelegateComparison()
    {
        // Define a Comparison delegate that compares two strings alphabetically
        Comparison<string> comparator = (string1, string2) => string1.CompareTo(string2);

        // Function that uses the Comparison delegate to compare two strings
        int CompareStrings(string string1, string string2)
        {
            return comparator(string1, string2);
        }

        int resultComparison = CompareStrings("manzana", "banana");
    }
}
