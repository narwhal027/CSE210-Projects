using System;
using System.Collections.Generic;

namespace YouTubeCommentTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create sample videos
            var videos = new List<Video>
            {
                new Video("Understanding C#",      "Jane Doe",     360),
                new Video("Top 10 Programming Tips", "John Smith",  480),
                new Video("Async in .NET",          "Alice Johnson",300),
                new Video("LINQ Deep Dive",         "Bob Brown",    420)
            };

            // Add comments to each video
            videos[0].AddComment(new Comment("UserA", "Great explanation!"));
            videos[0].AddComment(new Comment("UserB", "Very helpful, thanks."));
            videos[0].AddComment(new Comment("UserC", "Could you cover more on delegates?"));

            videos[1].AddComment(new Comment("Viewer1", "Awesome tips."));
            videos[1].AddComment(new Comment("Viewer2", "My productivity improved!"));
            videos[1].AddComment(new Comment("Viewer3", "Loved the examples."));

            videos[2].AddComment(new Comment("DevGuy", "Clear and concise."));
            videos[2].AddComment(new Comment("CodeGal", "Informative."));
            videos[2].AddComment(new Comment("LearnerX", "More please!"));

            videos[3].AddComment(new Comment("ProfCoder", "Deep dive indeed."));
            videos[3].AddComment(new Comment("StudentY", "This helped me a lot."));
            videos[3].AddComment(new Comment("DevZ", "Thanks for sharing."));

            // Display each video and its comments
            foreach (var video in videos)
            {
                Console.WriteLine(new string('=', 30));
                Console.WriteLine(video);
                video.DisplayComments();
            }
        }
    }
}
