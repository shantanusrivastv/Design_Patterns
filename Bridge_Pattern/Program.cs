using System;
using System.Collections.Generic;

namespace Bridge_Pattern
{
    public static class Program
    {
        private static void Main()
        {
            var documents = new List<Manuscript>();

            //We can also use BasicFormatter, BackwardsFormatter
            var formatter = new FancyFormatter();

            var faq = InitialiseFaq(formatter);
            documents.Add(faq);

            var book = InitialiseBook(formatter);
            documents.Add(book);

            var paper = InitialiseTermPaper(formatter);
            documents.Add(paper);

            foreach (var doc in documents) doc.Print();

            Console.ReadKey();
        }

        private static TermPaper InitialiseTermPaper(IFormatter formatter)
        {
            if (formatter == null) throw new ArgumentNullException(nameof(formatter));
            var paper = new TermPaper(formatter)
            {
                Class = "Design Patterns",
                Student = "Joe N00b",
                Text = "Blah blah blah...",
                References = "GOF"
            };
            return paper;
        }

        private static Book InitialiseBook(IFormatter formatter)
        {
            var book = new Book(formatter)
            {
                Title = "Lots of Patterns",
                Author = "John Sonmez",
                Text = "Blah blah blah..."
            };
            return book;
        }

        private static FAQ InitialiseFaq(IFormatter formatter)
        {
            var faq = new FAQ(formatter) {Title = "The Bridge Pattern FAQ"};
            faq.Questions.Add("What is it?", "A design pattern");
            faq.Questions.Add("When do we use it?", "When you need to separate an abstraction from an implementation.");
            return faq;
        }
    }
}