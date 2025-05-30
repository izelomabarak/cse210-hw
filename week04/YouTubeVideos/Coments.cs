using System;
using System.IO;
using System.Collections.Generic;
public class Coments
{
    public string _comentKey;
    public SortedList<string, string> _coments = new SortedList<string, string>();
    public void showComents()
    {

        List<string> videoComent;
        string coment = _coments[_comentKey];
        char U = '.';
        string[] data = coment.Split(U);
        videoComent = data.ToList();
        Console.WriteLine($"Coment Autor: {videoComent[0]}");
        Console.WriteLine($"Coment: {videoComent[1]}");
        Console.WriteLine(" ");
        Console.WriteLine($"Coment Autor:{videoComent[2]}");
        Console.WriteLine($"Coment: {videoComent[3]}");
        Console.WriteLine(" ");
        Console.WriteLine($"Coment Autor:{videoComent[4]}");
        Console.WriteLine($"Coment: {videoComent[5]}");
        Console.WriteLine(" ");
    }
}