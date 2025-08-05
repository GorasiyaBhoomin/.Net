using Constructor;
using System;
using System.Net;

namespace Constructor
{
    // create a program book class which book id,book titile,book author,book prize use the default to
    // initiaze and display 5 book details in output(array of object)
    class Book_constructor
    {
        int bookid;
        string title;
        string author;
        int prize;

        public Book_constructor()//default constructor
        {
            bookid = 1;
            title = "Software engineering";
            author = "Ajay das";
            prize = 100;
        }
        public void showData()
        {
            Console.WriteLine("bookid: " + bookid);
            Console.WriteLine("title: " + title);
            Console.WriteLine("author: " + author);
            Console.WriteLine("prize: " + prize);
        }
    }
}
internal class demo
{
    public static void Main(string[] args)
    {
        //Book_constructor s1 = new Book_constructor();
        //s1.showData();

        //Book_constructor[] s = new Book_constructor[5];
        //for (int i = 0; i < s.length; i++)
        //{
        //    s[i] = new Book_constructor();
        //    s[i].showData();
        //}

                    
    }
}



