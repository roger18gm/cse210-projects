using System.Text.Json.Serialization;
public class User {
    [JsonInclude]
    private string firstName;
    [JsonInclude]
    private string lastName;
    [JsonInclude]
    private string username;
    [JsonInclude]
    private string password;

    public User(string firstName, string lastName, string username, string password) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.username = username;
        this.password = password;
    }   
    public string GetFirstName() {
        return firstName;
    }
    public string GetLastName() {
        return lastName;
    }
    public string GetUsername() {
        return username;
    }
    public string GetPassword() {
        return password;
    }

    public override string ToString()
    {
        return $"User: {firstName} {lastName}";
    }
}