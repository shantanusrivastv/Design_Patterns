using System;
using System.Collections.Generic;

namespace Bridge_Pattern
{
    public class FAQ : Manuscript
    {
        public FAQ(IFormatter formatter) : base(formatter)
        {
            Questions = new Dictionary<string, string>();
        }

        public string Title { get; set; }
        public Dictionary<string, string> Questions { get; }

        public override void Print()
        {
            Console.WriteLine(_formatter.Format("Title", Title));
            foreach (var (key, value) in Questions)
            {
                Console.WriteLine(_formatter.Format("   Question", key));
                Console.WriteLine(_formatter.Format("   Answer", value));
            }

            Console.WriteLine();
        }
    }
}