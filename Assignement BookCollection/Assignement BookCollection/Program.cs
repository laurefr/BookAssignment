using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_BookCollection
{// start of namespace
    public class Book
    {// start of book class
        // Create a struc for book collection
        public string title;
        public string author;
        public long ISBN;
        // price double ( not a single number)
        public double price;


        public static int numberOfBooks;
        public void addBooks(string title, string author, long ISBN, double price)
        {
            this.title = title;
            this.author = author;
            this.ISBN = ISBN;
            this.price = price;
            Book.numberOfBooks++;
        }// end of addBooks
        public void ListBooks()
        {

            List<string> Books = new List<string>() { };

            Console.WriteLine("They are " + numberOfBooks + " book in the collection :");
            Console.WriteLine();


            string UserInput = Console.ReadLine().ToUpper();
            char answer = Convert.ToChar(Console.ReadLine().ToUpper());

            // Create a do while loop for userInput
            do
            {// start of do

                switch (UserInput)
                {
                    case "A":

                        //ask the user to input a title and author of the book
                        Console.WriteLine(" Type the title and author of the book you would to add");
                        // Create a string to add the book to collection
                        string bookToAdd = Console.ReadLine();
                        Books.Add(bookToAdd);
                        numberOfBooks++;
                        break;
                    case "D":
                        Console.WriteLine("Type the name of the book you would like to delete:");
                        string bookToDelete = Console.ReadLine();
                        Books.Remove(bookToDelete);
                        numberOfBooks--;
                        break;
                    case "S":
                        for (int i = 0; i < Books.Count; i++)
                        {
                            Console.WriteLine(Books[i]);
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine("What would you like to do next: A, D, S or X?:");


            }

            while (answer != 'X');

        }//------------------------------end of list books----------------------------------------
    }//-------------------------------------end of Book Class--------------------------------
        class Program 
        {//start of Program


            static void Main(string[] args)
            {// start of if Main

            // tell the user what is it
            Console.WriteLine("Welcome to the book collection");
            //diplay the number of book


            //Ask the user they want to do
            Console.WriteLine(" what would you like to do? \n Press A for adding a book in the collection \n Press D to delete a book from the collection \n Press S to see the book collection");
                Console.WriteLine("Press x to exit the collection");
                // User intput 


                Book.numberOfBooks = 0;
                //adding Data in the book list
                Book book1 = new Book();
                book1.addBooks("About Face", "Dan Hill", 97888888870, 19.95);

                Book book2 = new Book();
                book2.addBooks("Advertising from the Mad Men Ear (The Fifties and Sixties)", " Jim Heimann and Steven Heller", 97815849457896, 40.95);

                Book book3 = new Book();
                book3.addBooks("Contemporary Graphic Design", "  Charlotte and Peter Fiell", 97815569455631, 25.75);

                Book book4 = new Book();
                book4.addBooks("Change the wordl for a fiver", "  We Are What We Do", 97815569479131, 5);

                Book book5 = new Book();
                book5.addBooks("The girl on the train", " Paula Hawkins", 97819173455908, 20);

                //Adding the book to the List
                book1.ListBooks();
                book2.ListBooks();
                book3.ListBooks();
                book4.ListBooks();
                book5.ListBooks();

                //display books 
                Console.WriteLine("The number of books in the collection: {0}", Book.numberOfBooks);
                Console.WriteLine();



            }//end of Main
        }//end of class program
    }
// end of namespace

