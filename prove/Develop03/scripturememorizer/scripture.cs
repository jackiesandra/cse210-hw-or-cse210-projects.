using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public Reference Reference { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{Reference.Book} {Reference.Chapter}:{string.Join("-", Reference.Verses)}");
        Console.WriteLine(string.Join(" ", Words.Select(w => w.IsHidden ? "_____" : w.Text)));
    }

    public void HideRandomWord()
    {
        var visibleWords = Words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        Random random = new Random();
        int index = random.Next(visibleWords.Count);
        visibleWords[index].IsHidden = true;
    }

    public bool AllWordsHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
