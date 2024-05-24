public class Scripture
{
    private ScriptureReference Reference { get; set; }
    private List<Word> Words { get; set; }

    public Scripture(ScriptureReference reference, string text)
    {
        Reference = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideRandomWords()
    {
        var random = new Random();
        var wordIndex = random.Next(Words.Count);
        Words[wordIndex].IsHidden = true;
    }
      //this shows the display 
    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"{Reference.Book} {Reference.Verse}");
        Console.WriteLine(string.Join(" ", Words.Select(w => w.IsHidden ? "_____" : w.Text)));
    }
}
