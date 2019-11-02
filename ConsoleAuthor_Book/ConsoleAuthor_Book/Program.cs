﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAuthor_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Author
            //Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor
            //Console.WriteLine(ahTeck);  // Test toString()
            //ahTeck.setEmail("paulTan@nowhere.com");  // Test setter
            //Console.WriteLine("name is: " + ahTeck.getName());     // Test getter
            //Console.WriteLine("eamil is: " + ahTeck.getEmail());   // Test getter
            //Console.WriteLine("gender is: " + ahTeck.getGender()); // Test gExerciseOOP_MyPolynomial.pngetter
            //Console.WriteLine();

            /////Book
            ////Construct an author instance
            //Author ahTeeckk = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm');
            //Console.WriteLine(ahTeck);  // Author's toString()

            //Book dummyBook = new Book("Java for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            //Console.WriteLine(dummyBook);  // Test Book's toString()
            //// Test Getters and Setters
            //dummyBook.setPrice(29.95);
            //dummyBook.setQty(28);
            //Console.WriteLine("name is: " + dummyBook.getName());
            //Console.WriteLine("price is: " + dummyBook.getPrice());
            //Console.WriteLine("qty is: " + dummyBook.getQty());
            //Console.WriteLine("Author is: " + dummyBook.getAuthor());  // Author's toString()
            //Console.WriteLine("Author's name is: " + dummyBook.getAuthor().getName());
            //Console.WriteLine("Author's email is: " + dummyBook.getAuthor().getEmail());
            //// Use an anonymous instance of Author to construct a Book instance
            //Book anotherBook = new Book("more Java", new Author("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            //Console.WriteLine(anotherBook);  // toString()


            /// Authors
            ///Declare and allocate an array of Authors
            Author[] authors = new Author[2];
            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            /// Declare and allocate a Book instance
            Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
            Console.WriteLine(javaDummy);  // toString()

        }
    }
}


