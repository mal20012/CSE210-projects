using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> _video = new List<Video>();

        Video video1 = new Video("");

        Comment video1Comment1 = new Comment("");
        Comment video1Comment2 = new Comment("");
        Comment video1Comment3 = new Comment("");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        Video video2 = new Video("");

        Comment video2Comment1 = new Comment("");
        Comment video2Comment2 = new Comment("");
        Comment video2Comment3 = new Comment("");

        video2.ListComment(video1Comment1);
        video2.ListComment(video1Comment2);
        video2.ListComment(video1Comment3);

        videosList.Add(video2);

        Video video3 = new Video("");

        Comment video3Comment1 = new Comment("");
        Comment video3Comment2 = new Comment("");
        Comment video3Comment3 = new Comment("");

        video3.ListComment(video1Comment1);
        video3.ListComment(video1Comment2);
        video3.ListComment(video1Comment3);

        videosList.Add(video3);

         foreach (Video video in _video)
        {
            video.DisplayVideo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}