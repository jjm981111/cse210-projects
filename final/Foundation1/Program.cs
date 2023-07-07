using System;

class Program
{
    static void Main(string[] args)
    {
                List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment("User A", "Great video!");
        video1.AddComment("User B", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment("User C", "Nice content!");
        video2.AddComment("User D", "Could have been better.");
        video2.AddComment("User E", "I have a question.");
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment("User F", "Thanks for sharing!");
        video3.AddComment("User G", "This helped me a lot.");
        video3.AddComment("User H", "Looking forward to more videos.");
        video3.AddComment("User I", "Not impressed.");
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(" - " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }
    }
    }

    class Comment
{
    public string Name;
    public string Text;

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}

class Video
{
    public string Title;
    public string Author;
    public int Length;
    private List<Comment> comments;

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}