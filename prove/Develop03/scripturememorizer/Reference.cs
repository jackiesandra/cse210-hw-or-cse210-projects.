using System.Collections.Generic;
using System.Linq;

class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public List<int> Verses { get; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verses = new List<int> { verse };
    }

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        Book = book;
        Chapter = chapter;
        Verses = Enumerable.Range(verseStart, verseEnd - verseStart + 1).ToList();
    }
}
