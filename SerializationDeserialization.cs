using System.Text.Json;

class People
{
    public string? Name { get; set; }
    public int Age { get; set; }
}

class SerializationDeserialization
{
    public static void execution()
    {
        var objectPerson = new People()
        {
            Name = "Brian",
            Age = 12,
        };

        // Serialize
        string stringJsonPerson = JsonSerializer.Serialize(objectPerson);
        Console.WriteLine(stringJsonPerson);

        // Deserialize
        string? jsonPerson = @"{
            ""Name"":""Brian"",
            ""Age"":12
        }";

        People? newObjectPerson = JsonSerializer.Deserialize<People>(jsonPerson);
        Console.WriteLine(newObjectPerson?.Name);
        Console.WriteLine(newObjectPerson?.Age);
    }
}