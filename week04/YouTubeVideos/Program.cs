using System;
using System.Collections.Generic;
using System.Net;
class Program
{
    static void Main(string[] args)
    {
        static void Main()
        {
            SortedList<string, string> videos = new SortedList<string, string>();
            SortedList<string, string> coments = new SortedList<string, string>();
            videos.Add("1", "New tings in the wep, Alfonso Amado, 5800");
            videos.Add("2", "Asowms News, Ector Ernandes, 4200");
            videos.Add("3", "INFORMATION OF FIRST HOURE, Ernest Esenhower, 9300");
            coments.Add("1", "Fernado Fernandez. Wow, this is so interesting, I wat to buy that. James Jover. I tink that the objet is interestink. Ian Ixehuatl. Were I make my order for one");
            coments.Add("2", "Oscar Omar. O, thats is a relly brilland idea. Maria Martines. I relly want one of that. Jose Juarez. I am rrelly interesting in the produc, mere I se more information");
            coments.Add("3", "Willian Willfred. Where I contact clihent suport. Arnol Mercado. Where I buy that. Muhamed Saiz. Hello, I want to buy that product, but I want to now if you sell by credyt");
            Console.WriteLine("First Video");
            Videos video1 = new Videos();
            video1._videoKey = "1";
            video1._videos = videos;
            video1.showVideo();
            Coments coment1 = new Coments();
            coment1._comentKey = "1";
            coment1._coments = coments;
            coment1.showComents();

            Console.WriteLine("Second Video");
            Videos video2 = new Videos();
            video2._videoKey = "2";
            video2._videos = videos;
            video2.showVideo();
            Coments coment2 = new Coments();
            coment2._comentKey = "2";
            coment2._coments = coments;
            coment2.showComents();

            Console.WriteLine("Third Video");
            Videos video3 = new Videos();
            video3._videoKey = "3";
            video3._videos = videos;
            video3.showVideo();
            Coments coment3 = new Coments();
            coment3._comentKey = "3";
            coment3._coments = coments;
            coment3.showComents();
        }
        Main();
    }
}