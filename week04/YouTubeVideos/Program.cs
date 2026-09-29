using System;

class Program
{
    static void Main(string[] args)
    {
//VIDEO 1
        Video video1 = new Video("Laura Smith", "Making a chocolate cake", 350);

        Comment comment1 = new Comment("John", "I followed your recipe and it was perfect!");
        Comment comment2 = new Comment("Mia", "Thanks for the video!");
        Comment comment3 = new Comment("Lucas", "I would add less sugar.");

        video1.StoreComments(comment1);
        video1.StoreComments(comment2);
        video1.StoreComments(comment3);

//VIDEO 2
        Video video2 = new Video("Sarah Lee", "Lemon cupcakes", 280);

        Comment comment4 = new Comment("Jose", "It so helpful!");
        Comment comment5 = new Comment("Monica", "They are my favorites!");
        Comment comment6 = new Comment("Peter", "Thanks!!");
        Comment comment7 = new Comment("Miguel", "I am excited to make them");

        video2.StoreComments(comment4);
        video2.StoreComments(comment5);
        video2.StoreComments(comment6);
        video2.StoreComments(comment7);

//VIDEO 3
        Video video3 = new Video("Mike Palmer", "Apple pie", 600);

        Comment comment8 = new Comment("Lilly", "It is perfect for this season!");
        Comment comment9 = new Comment("Luis", "I am going to make it tomorrow");
        Comment comment10 = new Comment("Linda", "I like your pie, but I like to dice the apples smaller");
        Comment comment11 = new Comment("Fernando", "Amazing!!");

        video3.StoreComments(comment8);
        video3.StoreComments(comment9);
        video3.StoreComments(comment10);
        video3.StoreComments(comment11);

    

    //creating list of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            video.DisplayTracking();

            Console.WriteLine($"Number of comments: {video.NumberComments()}");

            foreach (Comment comment in video.Comments)
            {
                comment.DisplayComment();
            }

            Console.WriteLine();
        }

    }
}