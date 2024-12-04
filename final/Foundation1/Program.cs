using System;

class Program
{
    static List<Video> _videos = new List<Video>{};

    static void Main(string[] args)
    {
        Video video1 = new("My first video", "Bryson Price", "01 December 2024", 600);
        video1.CreateComment("First.", "John Smith", "01 December 2024");
        video1.CreateComment("Great Video!", "Alex Dawson", "01 December 2024");
        video1.CreateComment("Cap.", "Rachel Bull", "02 December 2024");
        video1.CreateComment("Does this still work?", "John The Revelator", "04 December 2024");
        _videos.Add(video1);

        Video video2 = new("My second video", "Bryson Price", "01 December 2024", 60);
        video2.CreateComment("First.", "Blake Johnson", "01 December 2024");
        video2.CreateComment("Aight.", "Alex Dawson", "01 December 2024");
        video2.CreateComment("fr fr", "Emma1203", "02 December 2024");
        video2.CreateComment("Feed my sheep", "JC", "04 December 2024");
        _videos.Add(video2);

        Video video3 = new("1000 subscribers!!! Gone Wrong!!", "Bryson Price", "01 December 2024", 180);
        video3.CreateComment("First.", "Jose_Alvarez03", "01 December 2024");
        video3.CreateComment("Worse than the second video", "Alex Dawson", "01 December 2024");
        video3.CreateComment("Blasphemy", "John the Baptist", "04 December 2024");
        _videos.Add(video3);      

        foreach (Video v in _videos)
        {
            v.DisplayVideo();
        }  
    }
}