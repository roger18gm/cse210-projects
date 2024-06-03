public class WritingAssignment : Assignment
{
    private string title;

    public WritingAssignment(string name, string topic, string title) : base(name,topic)
    {
        this.title = title;
    }

    public void GetWritingInfo()
    {
        Console.WriteLine($"{base.GetName()} - {title}");
    }
}