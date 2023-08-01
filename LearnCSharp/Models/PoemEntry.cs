using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Models
{
    internal class PoemEntry
    {
        private string? PoetName { get; set; }
        private string? PoemTitle { get; set; }
        private string? Poem { get; set; }
        private bool IsOriginal { get; set; }
        private static int EntryCount { get; set; }
        public PoemEntry(string poetName, string poemTitle, string poem, bool isOriginal)
        {
            PoetName = poetName;
            PoemTitle = poemTitle;
            Poem = poem;
            IsOriginal = isOriginal;
            EntryCount++;
        }

        public static int getTotalEntries()
        {
            return EntryCount;
        }
    }
}
