using System.Text.Json;

var objectPerson = new People()
{
    Name = "Brian",
    Age = 12,
};

// SERIALIZAR
string stringJsonPerson = JsonSerializer.Serialize(objectPerson);
Console.WriteLine(stringJsonPerson);

// DESERIALIZAR
string jsonPerson = @"{
    ""Name"":""Brian"",
    ""Age"":12
}";

People newObjectPerson = JsonSerializer.Deserialize<People>(jsonPerson);
Console.WriteLine(newObjectPerson.Name);
Console.WriteLine(newObjectPerson.Age);

class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}