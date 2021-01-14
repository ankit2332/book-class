using System;
using System.Collections.Generic;
using System.Text;

namespace book_class
{
    class Class
    {
        private string title;
        private string author;
        private bool borrowed;
        private int pages;
        public static int numberofbooks = 0;

        public Book(string title, string author, int pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
            this.borrowed = false;
            numberofbooks = numberofbooks + 1;
        }

        public string Gettitle()
        {
            return title;
        }

        public string Getauthor()
        {
            return author;
        }

        public int Getpages()
        {
            return pages;
        }

        public bool Isborrowed()
        {
            return borrowed;
        }

        public void Borrowbook()
        {
            if (borrowed == false)
            {
                borrowed = true;
            }
            else
            {
                Console.WriteLine(title + " is not available");
            }

        }


        public void Returnbook()
        {
            if (borrowed == true)
            {
                borrowed = false;
            }
            else
            {
                Console.WriteLine(title + " cannot be returned because it has not been borrowed");
            }
        }
    }