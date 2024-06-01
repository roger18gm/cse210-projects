using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    private bool running = true;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture(){

        while (running)
        {
            Console.Clear();
            Console.WriteLine(this);
            Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            HideWords(3); // Hide 3 words each time

            if (AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(this);
                Console.WriteLine("All words are hidden. Program will exit.");
                running = false;
            }
        }
    }

    public void HideWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = words.Where(w => !w.IsHidden).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(visibleWords.Count); //chooses random index and hides word
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetRenderedText()
    {
        return string.Join(' ', words.Select(w => w.Display()));
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden); // each word is hidden
    }

    public override string ToString()
    {
        return $"{this.reference} '{GetRenderedText()}'"; // prints reference and verse
    }

    public Reference GetReference()
    {
        return this.reference;
    }

    public List<Word> GetWords()
    {
        return words;
    }
}
