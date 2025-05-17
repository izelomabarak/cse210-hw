using System;
using System.IO;
public class Open
{
    public string _fileNameOpen;
    public void ReadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileNameOpen);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}