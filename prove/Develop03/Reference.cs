using System.Runtime.CompilerServices;

public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;

    private int endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public override string ToString()
    { //difference in output depending on the constructor type
        if (this.endVerse == this.startVerse)
        {
            return $"{this.book} {this.chapter}:{this.startVerse}";
        }
        else
        {
            return $"{this.book} {this.chapter}:{this.startVerse}-{this.endVerse}";
        }
    }

    public string GetBook()
    {
        return this.book;
    }

    public int GetChapter()
    {
        return this.chapter;
    }

    public int GetStartVerse()
    {
        return this.startVerse;
    }
    public int GetEndVerse()
    {
        return this.endVerse;        
    }

    public void SetBook(string book)
    {
        this.book = book;
    }

    public void SetChapter(int chapter)
    {
        this.chapter = chapter;
    }

    public void SetStartVerse(int verse)
    {
        this.startVerse = verse;
    }

    public void SetEndVerse(int endVerse)
    {
        this.endVerse = endVerse;
    }
}
