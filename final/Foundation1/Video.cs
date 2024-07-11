using System;
using System.Transactions;

class Video 
// Track the title, Author, and length(sec) of the video
// Store list of comments 
// Method return # of comments. 
{
        public string Title {get; set;}
        public string Author {get; set;}
        public int Length {get; set;}
        private List <Comment> comments;
        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }
        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }
        public int NomComments()
        {
            return comments.Count;
        }
        public List<Comment> GetComments()
        {
            return comments;
        }
}