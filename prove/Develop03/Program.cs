using System;

class Program
{
    static void Main(string[] args)
    {
        List<List<string>> ScripList = new List<List<string>> ();
    
        ScripList.Add(new List<string> {"John", "3", "16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."});
        ScripList.Add(new List<string> {"Matthew", "6", "33", "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."});
        ScripList.Add(new List<string> {"2 Nephi", "26", "33", "For none of these iniquities come from the Lord for He loves all black or white, bond or free, male or female, all are alike unto God."});
        ScripList.Add(new List<string> {"Ether", "12", "27", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."});
        ScripList.Add(new List<string> {"Proverbs", "3", "5", "Trust in the Lord with all thine heart; and lean not unto thine own understanding."});
        
        Random rand = new Random();

        int ranChoice = rand.Next(ScripList.Count);

        List<string> chosenScrip = ScripList[ranChoice]; 

        string ranBook = chosenScrip[0];
        string ranStrChap = chosenScrip[1];
        string ranStrVerse = chosenScrip[2];
        string ranSentence = chosenScrip[3];

        int ranIntChap = int.Parse(ranStrChap);
        int ranIntVerse = int.Parse(ranStrVerse);

        Reference reference = new Reference("John", 3, 16, 17);
        Reference reference2 = new Reference("John", 3, 16);

        Reference ranReference = new Reference(ranBook, ranIntChap, ranIntVerse);
        
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        string scriptureText2 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        Scripture scripture = new Scripture(reference, scriptureText);
        Scripture scripture2 = new Scripture(reference2, scriptureText2);
        
        Scripture ranScripture = new Scripture(ranReference, ranSentence);

        // scripture.DisplayScripture();
        // scripture2.DisplayScripture();

        ranScripture.DisplayScripture();
    }
}

