using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _iniContent = new List<Word>();
    private List<Word> _altContent = new List<Word>();

    public Scripture()
    {
        Random nb_verse = new Random();
        int pick = nb_verse.Next(1,3);
        string myCont, phrase="";
        if (pick == 1)
        {
            Reference myRef = new Reference();
            myCont = myRef.GetReference();
            _reference = myRef;
        }
        else
        {
            Reference myRef = new Reference(true);
            myCont = myRef.GetReference();
            _reference = myRef;
        }

        if (myCont == "2 Nephi 2:25-26")
        {
            phrase = "Adam fell that men might be; and men care, that they might have joy. And the Messiah cometh in the fulness of time, that he may redeem the children of men from the fall. And because that they are redeemed from the fall they have become free forever, knowing good from evil; to act for themselves and not to be acted upon, save it be by the punishment of the law at the great and last day, according to the commandments which God hath given.";
        }
        else if (myCont == "Proverb 3:5-6")
        {
            phrase = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }
        else if (myCont == "1 Nephi 3:7")
        {
            phrase = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        }
        else if ( myCont == "Alma 34:32")
        {
            phrase = "For behold, this life is the time for men to prepare to meet God; yea, behold the day of this life is the day for men to perform their labors.";
        }else
        {
            phrase = String.Empty;
        }

        if (phrase != String.Empty)
        {
            string[] listWord = phrase.Split(" ");
            foreach (string word in listWord)
            {
                Word myWord = new Word();
                myWord.SetWord(word);
                _iniContent.Add(myWord);
                _altContent.Add(myWord);
            }
        }
    }

    public void Display()
    {
        string answer;
        
        do
        {
            this.Clear();
            this.Show();

            Console.Write("Press ENTER to continue or type 'quit' to finish ");

            int nb = 0 ;
            foreach (Word word in _altContent)
            {
                if (word.GetWord()[0] == '_')
                {
                    nb++;
                }
            }

            if (nb == _altContent.Count)
            {
                break;
            }
        
            this.Hide();

            answer = Console.ReadLine();
        }
        while (answer != "quit");
    }

    public void Show()
    {
        _reference.Display();

        foreach (Word word in _altContent)
        {
            word.Show();
        }
    
        Console.WriteLine();
        Console.WriteLine();
    }

    public void Hide()
    {
        Random hidden = new Random();
        List<int> nb = new List<int>();
        int i = hidden.Next(_altContent.Count);
        
        for (int j = 0; j < 3; j++)
        {
            do
            {
                i = hidden.Next(_altContent.Count);
            }
            while (_altContent[i].GetWord()[0] == '_');
            nb.Add(i);
        }

        foreach (int n in nb)
        {
            _altContent[n].Hide();
        }
    }

    public void Clear()
    {
        Console.Clear();
    }
}