class Generics
{
    // Reserved word 'ref' to pass values by reference and not as a copy. 
    // The 'T' in 'ref T a' indicates the type of data that the parameter will have.
    public static void ExchangeValues<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static void execution()
    {
        // Generics can be used even with your own classes. 
        int a = 5, b = 10;
        Console.WriteLine($"Before the exchange: a = {a}, b = {b}");
        ExchangeValues(ref a, ref b);
        Console.WriteLine($"After the exchange: a = {a}, b = {b}");

        string str1 = "HELLO", str2 = "BODY";
        Console.WriteLine($"Before the exchange: a = {str1}, b = {str2}");
        ExchangeValues(ref str1, ref str2);
        Console.WriteLine($"After the exchange: a = {str1}, b = {str2}");
    }
}