// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private static readonly string[] Prompts = new string[]
    {
        "¿Quién fue la persona más interesante con la que interactué hoy?",
        "¿Cuál fue la mejor parte de mi día?",
        "¿Cómo vi la mano del Señor en mi vida hoy?",
        "¿Cuál fue la emoción más fuerte que sentí hoy?",
        "Si tuviera que hacer una cosa hoy, ¿qué sería?"
    };

    public void AddEntry(string response)
    {
        Random rand = new Random();
        string prompt = Prompts[rand.Next(Prompts.Length)];
        Entry entry = new Entry(prompt, response);
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split('|');
                if (parts.Length == 3)
                {
                    var entry = new Entry(parts[1].Trim(), parts[2].Trim())
                    {
                        Date = parts[0].Trim()
                    };
                    _entries.Add(entry);
                }
            }
        }
    }
}
