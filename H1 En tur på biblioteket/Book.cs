using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_En_tur_på_biblioteket
{
    /// <summary>
    /// the class <c>Book</c> is a model of a book
    /// </summary>
    internal class Book
    {
        private string _title;

        private string _description;

        private string _author;

        private int _pageNumber;

        public string Title
        {
            get { return _title; }
            private set { _title = value; }
        }

        public string Description
        { 
            get { return _description; }
            private set { _description = value; }
        }

        public string Author
        {
            get { return _author; }
            private set { _author = value; }
        }

        public int PageNumber
        {
            get { return _pageNumber; }
            private set { _pageNumber = value; }
        }


        private Book()
        {

        }
        private Book(string title) : this()
        {
            Title = title;
        }
        private Book(string title, string description) : this(title)
        {
            Description = description;
        }
        private Book(string title, string description, string author) : this(title, description)
        {
            Author = author;
        }
        public Book(string title, string description, string author, int pageNumber) : this(title,description, author)
        {
            PageNumber = pageNumber;
        }
    }
}
