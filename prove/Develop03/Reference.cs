using System;
class Reference
    {
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int[] Verses { get; set; }

        public Reference(string book, int chapter, int[] verses)
        {
            Book = book;
            Chapter = chapter;
            Verses = verses;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{string.Join(",", Verses)}";
        }
    }