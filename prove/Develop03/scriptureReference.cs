using System.Collections.Generic;

public class ScriptureReference
{
    public string Book { get; set; }
    public string Verse { get; set; }

    public ScriptureReference(string book, string verse)
    {
        Book = book;
        Verse = verse;
    }

    public ScriptureReference(string book, int startVerse, int endVerse)
    {
        Book = book;
        Verse = $"{startVerse}-{endVerse}";
    }
}
