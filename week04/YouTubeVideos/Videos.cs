using System;
using System.IO;
using System.Collections.Generic;
public class Videos
{
    public string _videoKey;
    public SortedList<string, string> _videos = new SortedList<string, string>();
    public void showVideo()
    {

        List<string> videoData;
        string prove = _videos[_videoKey];
        char U = ',';
        string[] data = prove.Split(U);
        videoData = data.ToList();
        Console.WriteLine($"Video Name: {videoData[0]}");
        Console.WriteLine($"Autor Name: {videoData[1]}");
        Console.WriteLine($"Duration: {videoData[2]}");
        Console.WriteLine(" ");
    }
}