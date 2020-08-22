﻿using System;

namespace Bridge_Pattern
{
    public class Book : Manuscript
    {
        public Book(IFormatter formatter) : base(formatter)
        {
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Title", Title));
            Console.WriteLine(_formatter.Format("Author", Author));
            Console.WriteLine(_formatter.Format("Text", Text));
            Console.WriteLine();
        }
    }
}