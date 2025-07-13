using System;
using System.Collections.Generic;

namespace YouTubeCommentTracker
{
    public class Video
    {
        public string Title { get; }
        public string Author { get; }
        public int LengthSeconds { get; }
        private readonly List<Comment> comments = new List<Comment>();

        public Video(string title, string author, int lengthSeconds)
        {
            Title = title;
            Author = author;
            LengthSeconds = lengthSeconds;
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetCommentCount()
        {
            return comments.Count;
        }

        public override string ToString()
        {
            TimeSpan ts = TimeSpan.FromSeconds(LengthSeconds);
            string lengthStr = ts.ToString(@"hh\:mm\:ss");
            return $"Title:   {Title}\n" +
                   $"Author:  {Author}\n" +
                   $"Length:  {lengthStr} ({LengthSeconds} sec)\n" +
                   $"Comments: {GetCommentCount()}";
        }

        public void DisplayComments()
        {
            foreach (var comment in comments)
            {
                Console.WriteLine($"  - {comment}");
            }
        }
    }
}
