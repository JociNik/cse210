public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public int _entryCount = 0;
    public int _wordCount = 0;

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void LoadFromFile(string file)
    {
        string[] linesToRead = File.ReadAllLines(file);

        _entries.Clear();

        foreach (string line in linesToRead)
        {
            string[] parts = line.Split(" | ");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
    public void SaveToFile(string file)
    {
        List<string> linesToWrite = new List<string>();
        foreach (Entry entry in _entries)
        {
            linesToWrite.Add($"{entry._date} | {entry._promptText} | {entry._entryText}");
        }

        File.WriteAllLines(file, linesToWrite);
    }

    public void UpdateStatistics()
    {
        _entryCount = _entries.Count();
        _wordCount = 0;

        foreach (Entry entry in _entries)
        {
            int wordsInEntry = entry._entryText.Split(' ').Length;
            _wordCount += wordsInEntry;
        }
    }
}