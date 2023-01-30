using System;
using System.IO;

class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void Save(string fileName, List<string> content)
    {
        Console.WriteLine("What is the name of the file?");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (string element in content)
            {
                outputFile.WriteLine($"{element}");
            }
            
        }
    }

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines)
        {
            string[] content = line.Split(",");
            Entry contents = new Entry();
            //Console.WriteLine($"{content[0].GetType()}")
            contents._date = DateTime.Parse(content[0]);
            contents._question = content[1];
            contents._answer = content[2];
            _entries.Add(contents);
        }
    }

    public void Display()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Sorry! You have not loaded any file yet");
        } else
        {
            foreach (Entry _entry in _entries)
            {
                _entry.Display();
            }
            
        }
        
        
    }
}