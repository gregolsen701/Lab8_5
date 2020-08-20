using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5
{
    class ParadiseIsland : Application
    {
        public string gender;
        public string partnerName;
        public int yearsTogether;

        public ParadiseIsland(string gender, string partnerName, int yearsTogether, string firstName, string lastName, string birthDate, string address, string city, string state, int zip, string phoneNumber, string email) : base(firstName, lastName, birthDate, address, city, state, zip, phoneNumber, email)
        {
            this.gender = gender;
            this.partnerName = partnerName;
            this.yearsTogether = yearsTogether;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to \"Paradise Island\"");
        }
    }
}
