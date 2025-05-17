using System;
using System.IO;
public class Save
{
    public string _fileName;
    public string _userName;
    public string _aditionalInformation;
    public string _userInformation;
    public List<string> _text = new List<string>();

    public void WriteFile()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            Console.WriteLine("Please enter your name:");
            _userName = Console.ReadLine();
            Console.WriteLine("If you whant, enter information about you, your hobbies or activities, if you dont whant, only write no:");
            _aditionalInformation = Console.ReadLine();
            _userInformation = ($"Name: {_userName} - Information:{_aditionalInformation}");
            outputFile.WriteLine(_userInformation);
            foreach (string Line in _text)
            {
                outputFile.WriteLine(Line);
            }
        }
    }
}