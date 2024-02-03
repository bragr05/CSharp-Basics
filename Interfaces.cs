// Interfaces allow us to type - categorize the classes
class User : INotifiable
{
    public string PreferenceNotification { get; set; }
    public string UserName { get; set; }

    public User(string userName, string preferenceNotification)
    {
        PreferenceNotification = preferenceNotification;
        UserName = userName;
    }
    public void notify(string message)
    {
        Console.WriteLine($"User: {UserName} / Notify by {PreferenceNotification} / Message : {message}");
    }
}

// Use 'I' in interface name as convention
interface INotifiable
{
    string PreferenceNotification { get; set; }
    void notify(string message);

}
