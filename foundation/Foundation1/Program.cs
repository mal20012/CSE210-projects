using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        List<Video> videosList = new List<Video>();

        Video video1 = new Video("Explore Tanzania's Hidden Gems: 5 Breathtaking Lakes You Must See!", "Africa Thrilling Safaris", 398);

        Comment video1Comment1 = new Comment("Lucia","Thank you for sharing this experience");
        Comment video1Comment2 = new Comment("Elias", "The Universe has memorny");
        Comment video1Comment3 = new Comment("Chirman", "Congratulations, this video is a bless for the ones who want to get ready for this country!");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        Video video2 = new Video("Vitumbua Laini Vya Mchele","Nanaaba's Kitchen", 473);

        Comment video2Comment1 = new Comment("Uzoa Makaoka", "Sis you delivered as usual");
        Comment video2Comment2 = new Comment("Fally Soona", "Good job sist, looks delicious");
        Comment video2Comment3 = new Comment("Esse", "I am adding this to my recipe list");

        video2.ListComment(video1Comment1);
        video2.ListComment(video1Comment2);
        video2.ListComment(video1Comment3);

        videosList.Add(video2);

        Video video3 = new Video("Tanzania's Dar es Salaam, the Largest City in East Africa", "African Insider", 242);

        Comment video3Comment1 = new Comment("Setwa", "Beautiful Country");
        Comment video3Comment2 = new Comment("Benjamin", "I spent 3 weeks there while in the Air Force.  Amazing people and a wonderful city!");
        Comment video3Comment3 = new Comment("Marc", "Beautiful city");

        video3.ListComment(video1Comment1);
        video3.ListComment(video1Comment2);
        video3.ListComment(video1Comment3);

        videosList.Add(video3);

         foreach (Video video in videosList)
        {
            video.DisplayVideo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}