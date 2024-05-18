using System;
using System.Xml.Schema;
using System.IO;

public class Journal {

    Entry newEntry = new Entry();
    string currentDirectory;
    string textFile;

    public Journal()
    {
        currentDirectory = Directory.GetCurrentDirectory();
    }
    public bool loadedJournal = false;
    string choice;
    string journalName;

    public void SaveJournal(string fileName){

        Console.WriteLine("What would you like to save the file name as? (ex:filename.txt)");
        Console.Write("Journal name: ");
        journalName = Console.ReadLine();

        string copyFileName = journalName;
        File.Copy(fileName, copyFileName);
        File.Copy(copyFileName, journalName);
        File.Delete(journalName);
        File.Delete(fileName);

    }

    public string LoadJournal() {

        Console.WriteLine("Enter filename of the journal you would like to load. (ex:filename.txt)");
        Console.Write("Journal name: ");
        textFile = Console.ReadLine();
        
        string filePath = Path.Combine(currentDirectory, textFile);

        if (File.Exists(filePath))
        {
            loadedJournal = true;
        }   
        else
        {
            Console.WriteLine("File doesn't exist.");
        }
        return textFile;
    }


    public void MenuPrompt() {

        while (choice != "5") {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();


            if (choice == "1")
            {
                newEntry.DisplayMenuPrompt();
                newEntry.WriteEntry(loadedJournal, textFile);
            } 
            else if (choice == "2")
            {
                newEntry.DisplayEntry(loadedJournal, textFile);
            }     
            else if (choice == "3")
            {
                LoadJournal();
            }   
            else if (choice == "4")
            {
                SaveJournal(newEntry.fileName);
                //exiting program needs to clear/delete the default.txt file
            }
        }
    }
}