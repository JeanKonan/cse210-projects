using System;

public class Reference
{
    private List<string> _book = new List<string>();
    private List<int> _chapter = new List<int>();
    private List<string> _verse = new List<string>();

    private string _refContent;

    public Reference()
    {
        _book.Add("1 Nephi");
        _book.Add("Alma");

        _chapter.Add(3);
        _chapter.Add(34);

        _verse.Add("7");
        _verse.Add("32");
    }

    public Reference(Boolean multiple = true)
    {
        _book.Add("2 Nephi");
        _book.Add("Proverb");

        _chapter.Add(2);
        _chapter.Add(3);

        _verse.Add("25-26");
        _verse.Add("5-6");
    }

    public string GetReference()
    {
        Random book = new Random();
        int i = book.Next(_book.Count);

        _refContent = $"{_book[i]} {_chapter[i]}:{_verse[i]}";
        return _refContent;
    }

    // public void SetReference(string wholeRef)
    // {
    //     char[] separatorList = {' ', ':'};
    //     string[] myref = wholeRef.Split(separatorList);
    //     int i = myref.Length, j;
    //     int indexB = 0, indexC = 0, indexV = 0;
    //     string myBook;

    //     foreach (string book in _book)
    //     {
    //         if (i > 3)
    //         {
    //             myBook = myref[i-3] + " " + myref[i-2];
    //         }
    //         else
    //         {
    //             myBook = myref[i-3];
    //         }
    //         if (myBook == book)
    //         {
    //             j = indexB;
    //             break;
    //         }
    //         indexB++;
    //     }

    //     foreach (int chapter in _chapter)
    //     {
    //         if (int.Parse(myref[i-2]) == chapter)
    //         {
    //             j = indexC;
    //             break;
    //         }
    //         indexC++;
    //     }

    //     foreach (string verse in _verse)
    //     {
    //         if (myref[i-1] == verse)
    //         {
    //             j = indexV;
    //             break;
    //         }
    //         indexV++;
    //     }

    //     _refContent = $"{_book[indexB]} {_chapter[indexC]} : {_verse[indexV]}";
    // }

    public void Display()
    {
    
            Console.Write($"{_refContent} ");
        
    }
}