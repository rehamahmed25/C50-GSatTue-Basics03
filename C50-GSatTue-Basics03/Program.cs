using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace C50_GSatTue_Basics03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //            Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle.Print
            //both title and upperTitle to show that title did not change. 
            //string title = "clean code";
            //string uppertitle = title.ToUpper();

            //Console.WriteLine(title);
            //Console.WriteLine(uppertitle);

            #endregion

            #region Question 2 
            //            Declare two separate string variables, both set to the literal "Clean Code".Use ReferenceEquals()
            //to check if they point to the same object in memory.

            //string s1 = "Reham";
            //string s2 = "Reham";
            //Console.WriteLine(object.ReferenceEquals(s1,s2));
            #endregion

            #region Question 3
            //            Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            //StringBuilder sb = new StringBuilder(" ");
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);
            #endregion

            #region Question 4
            //            Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            //StringBuilder sb = new StringBuilder(" ");
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb);


            //sb.Replace("Book List" ,"Library");
            //Console.WriteLine(sb);

            #endregion

            #region Question 5
//            Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, 
//Pages: 464" using the + operator. 

            string title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book:" + title +" , " + pages);

            #endregion

            #region Question 6
            //Build the same sentence as above, but using string interpolation ($"..."). 

            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine($"Book: { title} ,  { pages}");

            #endregion

            #region Question 7
            //Build the same sentence again, but using string.Format().

            //string title = "Clean Code";
            //int pages = 464;
            //Console.WriteLine(string.Format("Book : {0} ,{1} ", title , pages));

            #endregion


            #region Question 8
            //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 
            //300, otherwise prints "Short Book".

            int pagess = 464;
            if (pages > 300)
                Console.WriteLine("Long Book");
            else
                Console.WriteLine("Short Book");

            #endregion

            #region Question 9
            //GGiven int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is 
            //greater than 300 and isAvailable is true.Use the && operator. 

            int pagesss = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable==true)
                Console.WriteLine("You can borrow this book");
            else
                Console.WriteLine("Cannot borrow ");

            #endregion
        }
    }
}
