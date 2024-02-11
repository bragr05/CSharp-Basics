class FunctionalProgramming
{
    public static void Greetings01(string name)
    {
        Console.WriteLine("Hello " + name + ", how are you?");
    }

    // IMPORTANT! 'Action<>' is a Delegate. See the delegates that exist in Delegates.cs
    public static void Greetings03(Action<string> fn, string name)
    {
        fn(name);
    }
    public static void execution()
    {
        // Example of First-class functions 
        var Greetings02 = Greetings01;
        Greetings02("Brian");

        Console.WriteLine("-----------------");

        // Example of Higher-order functions
        Greetings03(Greetings01, "Brian");
    }
}