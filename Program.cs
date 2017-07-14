using System;
using System.Collections.Generic;

namespace dreamteam
{
    class Program
    {
        public interface IDreamTeam
        {
            string Specialty { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
            string FullName { get;} 
            void Work();

        }
        public class Chaz : IDreamTeam
        {
            public string Specialty { get; set; } = "Crushing Code";
            public string FirstName { get; set; } = "Chaz";
            public string LastName { get; set; } = "Hendricks";

            public string FullName => $"{FirstName} {LastName}";


            public void Work()
            {
                Console.Write("Makes jokes but it's ok cause he's one step ahead of you.");
            }
        }

        public class Eliza : IDreamTeam
        {
            public string Specialty { get; set; } = "Managing";
            public string FirstName { get; set; } = "Eliza";
            public string LastName { get; set; } = "Meeks";

           public string FullName => $"{FirstName} {LastName}";

            public void Work()
            {
                Console.WriteLine("Breaks down the problems well with words, but understanding her code....");
            }
        }

        public class Ryan : IDreamTeam
        {
            public string Specialty { get; set; } = "";
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";

            public string FullName => $"{FirstName} {LastName}";

            public void Work()
            {
                Console.WriteLine("Ryan spins his figet spinner.");
            }
        }

        public class Jordan : IDreamTeam
        {
            public string Specialty { get; set; } = "";
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";

            public string FullName => $"{FirstName} {LastName}";

            public void Work()
            {
                Console.WriteLine("Makes sure everyone is getting along.");
            }
        }

        public class Jason : IDreamTeam
        {
            public string Specialty { get; set; } = "";
            public string FirstName { get; set; } = "";
            public string LastName { get; set; } = "";

            public string FullName => $"{FirstName} {LastName}";

            public void Work()
            {
                Console.WriteLine("Says the problem is stupid and pumps out the code anyways.");
            }
        }
        static void Main(string[] args)
        {
            // Your job is to pick 5 of your teammates in your cohort and build a class for each one. Each teammate should have the following properties/methods. Build one for yourself, as well.

            // Specialty property - This holds the technology that the person enjoys the most.
            // FirstName property
            // LastName property
            // FullName property - This property is a readonly property that returns the first and last name concatenated.
            // Work() method - This will write a comical message to the console that describes the work they will do on a group project, based on their speciality.
            // Once you're done, you should have 6 different types in total, each with the properties and methods above.
            Chaz chaz = new Chaz();
            Eliza eliza = new Eliza();
            Ryan ryan = new Ryan();
            Jordan jordan = new Jordan();
            Jason jason = new Jason();


            List<IDreamTeam> FeatureTeam = new List<IDreamTeam>();
            FeatureTeam.Add(chaz);
            FeatureTeam.Add(eliza);
            FeatureTeam.Add(jason);

            
            List<IDreamTeam> BugTeam = new List<IDreamTeam>();
            BugTeam.Add(ryan);
            BugTeam.Add(jordan);
            // Create two groups (i.e. List) that will hold three teammates each. These two lists represent one team that will be the server side team, and one that will be the client side team.
            // Instantiate one instance of each of your teammates.
            // Put your teammates into the appropriate team.


            //Write two foreach loops that iterate over each List and makes each of the teammates do their work.

            foreach (var i in FeatureTeam)
            {
                i.Work();
            }

            foreach(var n in BugTeam)
            {
                n.Work();
            }
        }
    }
}
