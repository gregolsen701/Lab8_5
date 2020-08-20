using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5
{
    class HouseHunter : Application
    {

        public string jobTitle;
        public int income;
        public string buyDate;
        public int numBed;
        public int numBath;


        public HouseHunter(string jobTitle, int income, string buyDate, int numBed, int numBath, string firstName, string lastName, string birthDate, string address, string city, string state, int zip, string phoneNumber, string email) : base(firstName, lastName, birthDate, address, city, state, zip, phoneNumber, email)
        {
            this.jobTitle = jobTitle;
            this.income = income;
            this.buyDate = buyDate;
            this.numBed = numBed;
            this.numBath = numBath;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("You've been accepted to \"Dream House Hunters\"");
        }
    }
}

