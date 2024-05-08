public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
            }
        }
    }
     public void LoadFromFile(string filename)
    {
        entries = new List<Entry>();
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Entry entry = new Entry(parts[1].Trim(), parts[2].Trim());
                    entry.Date = DateTime.Parse(parts[0].Trim().Substring(5));
                    entries.Add(entry);
                }
            }
        }
    }
}

