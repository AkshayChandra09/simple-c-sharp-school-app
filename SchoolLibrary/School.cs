using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        //Auto property: useful if u want to add a encapsulation to ur property
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string phoneNumber { get; set; }

        //backing variable
        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure the twitter address starts with @symbol
            get { return _twitterAddress;  }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("The Twitter address must begin with @");
                }
            }
        }

        public School()
        {
            Name = "Untitled School";
            phoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            phoneNumber = SchoolPhoneNumber;
        }

        //method overloading-> polymorphism
        //public float AverageThreeScores(float a, float b, float c)
        //{
        //    return (a + b + c) / 3;
        //} 

        public static int AverageThreeScores(int a, int b, int c)
        {
           return (a + b + c) / 3;
        }

        //A fuction bodied expression
        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        //Overriding toString method
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(", ");
            sb.Append(State);
            sb.Append(" ");
            sb.Append(Zip);

            return sb.ToString();
        }



    }
}
