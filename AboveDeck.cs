using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5
{
    class AboveDeck : Application
    {
        public int yearsBoating;
        public string nationality;


        public AboveDeck(int yearsBoating, string nationality, string firstName, string lastName, string birthDate, string address, string city, string state, int zip, string phoneNumber, string email) : base(firstName, lastName, birthDate, address, city, state, zip, phoneNumber, email)
        {
            this.yearsBoating = yearsBoating;
            this.nationality = nationality;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to \"Above Deck\"");
        }
    }
}
