using System;
using System.Transactions;

class Program
// create 3-4 videos, sets values, add list of 3-4comments
// Put each of these videos in a list. 
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Recurrent Neural Networks", "Author 1", 1538);
        Video video2 = new Video("Random Memes 2021", "Author 2", 423);
        Video video3 = new Video("Why English is a Useful Major", "Author 3", 38);
        
        video1.AddComment(new Comment("James Reese", "This video is so boring, stop!!!"));
        video1.AddComment(new Comment("Cameron Rod", "I Absolutely Love this video! What an intereesting concept"));
        video1.AddComment(new Comment("Jessica Chambers", "I like toast"));
        video2.AddComment(new Comment("Maia Walkens", "I hate this video"));
        video2.AddComment(new Comment("Drake", "Does anyone even think this is funny?"));
        video2.AddComment(new Comment("James", "I like pigs. "));
        video3.AddComment(new Comment("Cameron Rod", "My sister got this degree and is a waitress..."));
        video3.AddComment(new Comment("Ms. English", "I love being an english teacher!"));
        video3.AddComment(new Comment("Michael Jackson", "English waas my favorite subject growing up."));  
        
        List<Video> videos = new List<Video> {video1, video2, video3};

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.Author}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}