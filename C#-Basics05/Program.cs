namespace C__Basics05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region Ques 1
            //Console.WriteLine(Book.password);
            //cannot print because password is private.
            #endregion

            #region Ques 2
            //Console.WriteLine(book.copiesInStock);
            // yes , its compile because its internal access modifier.
            #endregion

            #region Ques 3
            //Console.WriteLine(book.title);
            #endregion

            #region Ques 4
            //Console.WriteLine(book.genre);
            #endregion

            #region Ques 5 
            //int x = (int)Genre.Fiction;
            //Console.WriteLine(x);

            //int y = (int)Genre.NonFiction;
            //Console.WriteLine(y);

            //int z = (int)Genre.Science;
            //Console.WriteLine(z);
            #endregion

            #region Ques 6
            //int genereValue = 1;
            //Genre genre = (Genre)genereValue;
            //Console.WriteLine(genre);
            #endregion

            #region Ques 7

            //Genre genre = Genre.Fiction;
            //string s = genre.ToString();
            //Console.WriteLine(s);

            #endregion

            #region Ques 8 

            #endregion

            #region Ques 9

            #endregion



        }
    }
}
