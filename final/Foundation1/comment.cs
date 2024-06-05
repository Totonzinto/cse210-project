public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public override string ToString() // Method in TitleCase
    {
        return $"{_name}: {_text}";
    }
}