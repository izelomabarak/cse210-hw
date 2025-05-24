using System;
using System.IO;
public class Scripture
{
    public int _randomNumber;
    private string _scripture;
    private List<string> _directoryScripture;
    public Scripture(int wholeNumber)
    {
        _randomNumber = wholeNumber;
        string[] lines = System.IO.File.ReadAllLines("Scriptures.txt");
        List<string> text = new List<string>();
        foreach (string line in lines)
        {
            text.Add(line);
        }
        _directoryScripture = text;
        _scripture = _directoryScripture[_randomNumber];
    }
    public Scripture(int wholeNumber, string scripture)
    {
        _scripture = scripture;
    }
    public Scripture(int wholeNumber, string scripture, string scriptureVerse)
    {
        _scripture = $"{scripture}. {scriptureVerse}";
    }
    public string GetScripture()
    {
        string scripture = _scripture;
        return scripture;
    }
}