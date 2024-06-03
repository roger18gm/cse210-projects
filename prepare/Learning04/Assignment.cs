public class Assignment 
{
    private string name;
    private string topic;

    public Assignment(string name, string topic)
    {
        this.name = name;
        this.topic = topic;
    }
    public void GetSummary()
    {
        Console.WriteLine($"{GetName()} - {GetTopic()}");
    }

    public string GetName()
    {
        return this.name;
    }

    public string GetTopic()
    {
        return this.topic;
    }
}