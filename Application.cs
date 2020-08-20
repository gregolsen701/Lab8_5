using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_5
{
    class Application
    {
        protected string firstName;
        protected string lastName;
        protected string birthDate;
        protected string address;
        protected string city;
        protected string state;
        protected int zip;
        protected string phoneNumber;
        protected string email;
        protected bool isSubmitted;
        protected bool isAccepted;

        public Application(string firstName, string lastName, string birthDate, string address, string city, string state, int zip, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
            isSubmitted = false;
            isAccepted = false;
        }
        public void Submit()
        {
            isSubmitted = true;
            Console.WriteLine("Application has been submitted.");
        }

        public virtual void Accept()
        {
            isAccepted = true;
            Console.WriteLine("Application Accepted.");
        }
    }
}
