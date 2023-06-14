using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{    internal  class Feature9 
    {
        public record Person_0(String FirestName, String LastName)
        {
            public override string ToString()
            {
                return base.ToString();
            }
        }

        public record Person_1
        {
            public string FirstName { get; init; }
            public string LastName { get; init; }
        }

        public record Person_2
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        public static bool isLetter( char c) =>
            c is >= 'a'
            and <= 'z'
            or >= 'A'
            and <= 'Z';

        static private List<sbyte> sbyteList = new();

        public static void test()
        {
            Person_0 person_0 = new("asd", "asd");

            Person_1 person_1 = new Person_1
            {
                FirstName = "asd",
                LastName = "asd"
            };

            Person_2 person_2 = new Person_2
            {
                FirstName = "asd",
                LastName = "asd"
            };

            //person_1.FirstName = "asd";
            person_2.FirstName = "qwe";

            if (person_0 is not null)
            {
                person_0.ToString();
            }


            isLetter('9');
            isLetter('a');
            isLetter('Z');

            List<sbyte> sbyteList2 = new();

        }


    }
}
