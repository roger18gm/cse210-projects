public class Word
{
    private string text;
    private bool isHidden;

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        this.isHidden = true;
    }

    public string Display()
    { //changes characters to underscores
        return this.isHidden ? new string('_', this.text.Length) : this.text;
    }

    public string GetText()
    {
        return this.text;
    }

    public bool IsHidden
    {
        get { return this.isHidden; }
    }

    public void SetText(string text)
    {
        this.text = text;
    }

    public void SetHidden(bool hidden)
    {
        this.isHidden = hidden;
    }
}
