using System;

namespace YouTubeCommentTracker
{
    public class Comment
    {
        public string AuthorName { get; }
        public string Text { get; }

        public Comment(string authorName, string text)
        {
            AuthorName = authorName;
            Text = text;
        }

        public override string ToString()
        {
            return $"{AuthorName}: {Text}";
        }
    }
}
