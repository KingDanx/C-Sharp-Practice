using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharpe_Practice
{
    internal class Book
    {
        public int pages;
        public string title;
        public string author;

        public Book(int aPages, string aTitle, string aAuthor)
        {
            pages = aPages;
            title = aTitle;
            author = aAuthor;
        }
    }
}
