using System;

class Comment 
// Track Name of person who made comment
// Track Text of the comment
{
        public string Author{get; set;}
        public string Text{get; set;}
        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
}