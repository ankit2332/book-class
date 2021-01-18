using System;

namespace book_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Class book1 = new Class("harry potter", "JK Rowling", 299);
            Class book2 = new Class("The bible", 1000);
            Class book3 = new Class("EE","aom","pat" ,1000);


            Console.WriteLine(book1.Getauthor());
            Console.WriteLine(book2.Getauthor());
            Console.WriteLine(book3.Getauthors());

        }
    }
}
