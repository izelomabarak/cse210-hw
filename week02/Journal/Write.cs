using System;
public class Write
{
    public int _randomNumber;
    public string _entry;
    public string _anser;
    public string _question;
    public string WriteEntry()
    {
        Random random = new Random();
        int _randomNumber = random.Next(6);
        if (_randomNumber == 1)
        {
            _question = "What was the funiest ting that I do this day?";
            Console.WriteLine(_question);
            _anser = Console.ReadLine();
        }

        else if (_randomNumber == 2)
        {
            _question = "How I improve my sefl this day?";
            Console.WriteLine(_question);
            _anser = Console.ReadLine();

        }

        else if (_randomNumber == 3)
        {
            _question = "What I do this day for be a better discipel of Jesus Christ?";
            Console.WriteLine(_question);
            _anser = Console.ReadLine();
        }

        else if (_randomNumber == 4)
        {
            _question = "What I do this day for reach or be more close of my goals?";
            Console.WriteLine(_question);
            _anser = Console.ReadLine();
        }

        else if (_randomNumber == 5)
        {
            _question = "With what person I pass more time this day?";
            Console.WriteLine(_question);
            _anser = Console.ReadLine();
        }
        DateTime currentTime = DateTime.Now;
        string date = currentTime.ToShortDateString();
        _entry = ($"Date: {date} - Prompt: {_question} - Anser: {_anser}");
        return _entry;
    }
}   
