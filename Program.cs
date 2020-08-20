using System;

namespace Lab8_5
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseHunter hunter1 = new HouseHunter("Full Stack Web Developer", 100000, "6 Months", 3, 2, "Omar", "Smith", "2/4/1975", "111 Bravo Way", "Los Angeles", "CA", 90001, "888-233-1234", "omar.smith@hotmail.com");
            ParadiseIsland paradise1 = new ParadiseIsland("Female", "Carl", 2, "Patti", "Johnson", "5/4/1994", "211 Love Rd", "Los Angeles", "CA", 90001, "988-444-1234", "patt.johnson@gmail.com");
            AboveDeck deck1 = new AboveDeck(20, "American", "Captain", "Lee", "7/12/1964", "311 Bravo Way", "Los Angeles", "CA", 90001, "711-333-1234", "captain@gmail.com");

            hunter1.Submit();
            hunter1.Accept();
            paradise1.Submit();
            paradise1.Accept();
            deck1.Submit();
            deck1.Accept();

       
        }
    }
}
