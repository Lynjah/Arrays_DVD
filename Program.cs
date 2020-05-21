using System;
using System.Security.Cryptography.X509Certificates;

namespace DVD_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of 15 DVDs
            DVD[] dvdCollection = new DVD[15];
            DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");
            dvdCollection[7] = avengersDVD;
            //Console.WriteLine(avengersDVD.ToString());
            DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

            // Put "The Incredibles" into the 4th place: index 3.
            dvdCollection[3] = incrediblesDVD;

            // Put "Finding Dory" into the 10th place: index 9.
            dvdCollection[9] = findingDoryDVD;

            // Put "The Lion King" into the 3rd place: index 2.
            dvdCollection[2] = lionKingDVD;

            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");
            dvdCollection[3] = starWarsDVD;

            // Print out what's in indexes 7, 10, and 3.
            Console.WriteLine(dvdCollection[7].ToString());
            Console.WriteLine(dvdCollection[3].ToString());


            // Will print:

            // The Avengers, directed by Joss Whedon, released in 2012
            // null
            // Star Wars, directed by George Lucas, released in 1977
        }
    }

    class DVD
    {
        public String name;
        public int releaseYear;
        public String director;

        public DVD(String name, int releaseYear, String director)
        {
            this.name = name;
            this.releaseYear = releaseYear;
            this.director = director;
        }

        public override string ToString()
        {
            return this.name + ", directed by " + this.director + ", released in " + this.releaseYear;
        }
    }
}
