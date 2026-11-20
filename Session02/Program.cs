using Session02.Models;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Session02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            ////-Q01. Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            ////variable of type object.Print it.
            //object bookObject = new Book("The Great Gatsby", 180);
            //// convert the object to a string using ToString() method and print it
            //Console.WriteLine(bookObject);
            #endregion

            #region Question 2
            ////-Q02. Using the Book class above, print the result of calling ToString(), Equals() (compare book withitself), GetHashCode(), and GetType() on book.
            //object bookObject = new Book("The Great Gatsby", 180);
            //Console.WriteLine("ToString():");
            //Console.WriteLine(bookObject.ToString());
            //Console.WriteLine("\nEquals():");
            //Console.WriteLine(bookObject.Equals(bookObject));
            //Console.WriteLine("\nGetHashCode():");
            //Console.WriteLine(bookObject.GetHashCode());
            //Console.WriteLine("\nGetType():");
            //Console.WriteLine(bookObject.GetType());
            #endregion

            #region Question 3
            //-Q03. Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            //int pages = "464";
            // Error Type: Compile-time error
            // Error: Cannot implicitly convert type 'string' to 'int'. Fix: Convert the string to an integer using int.Parse() or int.TryParse().
            //int pages = int.Parse("464");
            #endregion

            #region Question 4
            //-Q04. Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int divisor = 0;
            //    int result = 10 / divisor;
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion

            #region Question 5
            ////-Q05. Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //// Implicit conversion from int to double
            //double pagesDouble = pages;

            #endregion
            #region Question 6
            ////-Q06. Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //// Explicit conversion from double to int using a cast
            //int priceInt = (int)price;

            #endregion
            #region Question 7
            ////-Q07. Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //// Convert string to int using Convert class
            //int pagesInt = Convert.ToInt32(pagesText);

            #endregion

            #region Question 8
            ////-Q08. Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            //string yearText = "2023";
            //// Convert string to int using int.Parse()
            //int yearInt = int.Parse(yearText);
            //string badText = "abc";
            //// Safely convert string to int using int.TryParse()
            //if (int.TryParse(badText, out int badInt))
            //{
            //    Console.WriteLine(badInt);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region Question 9
            ////-Q09. Given int pages = 464;, convert it into a string using ToString() and print its type using GetType() to prove it's now a string.
            //int pages = 464;
            //// Convert int to string using ToString()
            //string pagesString = pages.ToString();
            //// Print the type of the converted string
            //Console.WriteLine(pagesString.GetType());
            #endregion

            #region Question 10
            //-Q10. Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
            int copies = 100;
            // Box the int into an object variable
            object copiesObject = copies;
            // Unbox the object back into a new int variable
            int copiesUnboxed = (int)copiesObject;
            Console.WriteLine(copies);
            Console.WriteLine(copiesUnboxed);
            #endregion

        }
    }
}
