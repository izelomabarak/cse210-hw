using System;

class Words
{
    public List<string> _oraition;
    public Words(string oration)
    {
        char U = ' ';
        string[] words = oration.Split(U);
        _oraition = words.ToList();
    }
    public List<string> Prove()
    {
        foreach (string word in _oraition)
        {
            Console.Write($" {word}");
        }
        return _oraition;
    }
    public List<string> ProveRemove()
    {
        int numberWords = _oraition.Count();
        Random random = new Random();
        int randomNumber = random.Next(0, numberWords);
        string selectWord = _oraition[randomNumber];
        int numberLeters = selectWord.Length;
        int cronometer = 0;
        List<string> underscoresList = new List<string>();
        do
        {
            underscoresList.Add("_");
            cronometer = cronometer + 1;
        } while (numberLeters != cronometer);
        string underscores = string.Join("", underscoresList.Select(n => n.ToString()));
        _oraition[randomNumber] = underscores;
        return _oraition;
    }
    public string StatusAnalisis()
    {
        int wordsUnderscore = 0;
        int numberWords = _oraition.Count();
        string finis = "no";
        foreach (string word in _oraition)
        {
            char extract = word[0];
            string sample = extract.ToString();
            if (sample == "_")
            {
                wordsUnderscore = wordsUnderscore + 1;
            }
            if (wordsUnderscore == numberWords)
            {
                finis = "quit";
            }
        }
        return finis;
    }
}