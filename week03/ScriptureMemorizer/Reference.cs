using System;
using System.IO;
public class Reference
{
    public int _randomNumber;
    private string _reference;
    private List<string> _directory;
    public Reference(int wholeNumber)
    {
        _randomNumber = wholeNumber;
        string[] lines = System.IO.File.ReadAllLines("Scriptures-Reference.txt");
        List<string> text = new List<string>();
        foreach (string line in lines)
        {
            text.Add(line);
        }
        _directory = text;
        _reference = _directory[_randomNumber];
    }
    public Reference(int wholeNumber, string reference)
    {
        _reference = reference;
    }
    public string GetReference()
    {
        string reference = _reference;
        return _reference;
    }
}