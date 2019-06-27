using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInformationAppWalkthrough2
{
    class Person
    {
        private string firstName;
        private string middleName;
        private string lastName;

        //public string GetFullName()
        //{
        //    return firstName + " " + middleName + " " + lastName;
        //}

        //public string FirstName
        //{
        //    get { return firstName; }
        //    set { firstName = value; }
        //}

        public string FirstName
        {
            get
            {
                string fs = "Mr " + firstName;
                return fs;
            }
            set { firstName = value; }
        }

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        //private string GetFullName()
        //{
        //    return firstName + " " + middleName + " " + lastName;
        //}

        private string GetFullName()
        {
            return FirstName + " " + middleName + " " + lastName;
        }

        //public string FirstName { get; set; }
        //public string MiddleName { get; set; }
        //public string LastName { get; set; }

        //private string GetFullName()
        //{
        //    return FirstName + " " + MiddleName + " " + LastName;
        //}

        public string FullName
        {
            get { return GetFullName(); }
        }

        //string GetReverseName()
        //{
        //    return null;
        //}
    }
}
