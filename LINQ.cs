class LINQ
{
    public static List<string> names = new List<string>
    {
        "Juan",
        "María",
        "Carlos",
        "Laura",
        "Pedro",
        "Ana",
        "José",
        "Sofía",
        "Miguel",
        "Luisa",
        "David",
        "Elena",
        "Pablo",
        "Lucía",
        "Fernando",
        "Isabel",
        "Diego",
        "Carmen",
        "Javier",
        "Teresa"
    };

    // IMPORTANT NOTE: This method implements a C# interface called "IEnumerable" which guarantees that the data type <T> is iterable.
    public static void printList<T>(IEnumerable<T> list)
    {
        foreach (var data in list)
        {
            Console.Write(data + " - ");
        }
    }
    public static void execution()
    {

        var sortedNames = from n in names orderby n descending select n;

        // IMPORTANT: The LINQ formula is executed up to this point, not before, for this use .ToList()
        printList(sortedNames);

        Console.WriteLine("\n");
        var nameLength = from n in names where n.Length > 5 && n.Length < 10 select n;
        printList(nameLength);
    }

}