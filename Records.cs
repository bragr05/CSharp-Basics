// Records are a type of data whose main quality is immutability. They are similar to Structs
record Person
{
    public string? Name { get; init; }
    public int Age { get; init; }
}

class Records
{
    public static void execution()
    {

        var person = new Person { Name = "Juan", Age = 30 };
        Console.WriteLine($"Nombre: {person.Name}, Edad: {person.Age}");

        // Creation of another instance of Person with the same values
        var anotherPerson = new Person { Name = "Juan", Age = 30 };

        // Verification of equality between records
        Console.WriteLine($"¿Los dos registros son iguales?: {person.Equals(anotherPerson)}");
    }
}
