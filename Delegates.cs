// They allow the typing of functions. The ones shown in the code are the default ones, although it is possible to create your own delegates.
class Delegates
{

    #region "Example of custom delegate"

    delegate void MyDelegate(string message);

    static void Greetings(string message)
    {
        Console.WriteLine("Hello, " + message + "!");
    }
    public void UseCustomDelegate()
    {
        MyDelegate myDelegate;
        myDelegate = Greetings;
    }

    #endregion

    public void ExampleDefaultDelegates()
    {
        // Delegado Func
        Func<int, int, int> sum = (a, b) => a + b;
        int Add(int x, int y)
        {
            return sum(x, y);
        }
        int resultado = Add(3, 5);
        Console.WriteLine("Func Result: " + resultado);

        // Delegado Action
        Action<string> printMessage = message => Console.WriteLine(message);
        void Print(string mensaje)
        {
            printMessage(mensaje);
        }
        Print("Hola mundo!");

        // Delegado Predicate
        Predicate<int> isEven = num => num % 2 == 0;
        bool IsEven(int numero)
        {
            return isEven(numero);
        }
        bool isEvenResult = IsEven(4);
        Console.WriteLine("Predicate Result: " + isEvenResult);

        // Delegado Comparison
        Comparison<string> comparator = (string1, string2) => string1.CompareTo(string2);
        int CompareStrings(string string1, string string2)
        {
            return comparator(string1, string2);
        }
        int resultComparison = CompareStrings("manzana", "banana");
        Console.WriteLine("Comparison Result: " + resultComparison);
    }

}
