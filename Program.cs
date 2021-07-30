using System;

namespace resume
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instance of a resume
            var Newpeople = new resume();

            Console.WriteLine(" Welcome to your Resume ");
            Console.WriteLine(" ***************************");
            Console.WriteLine("Please enter your name:");
            Console.Write(" First name:");
            Newpeople.Fname = Console.ReadLine();
            Console.Write(" Last name:");
            Newpeople.Lname = Console.ReadLine();
            Console.Write("Please enter your address:");
            Newpeople.address = Console.ReadLine();
            Console.Write("Please enter your telephone number:");
            Newpeople.telenum = Console.ReadLine();
            Console.Write("Please enter your Email Address:");
            Newpeople.email = Console.ReadLine();
            Console.WriteLine("Your summary paragraph:");
            Newpeople.summary = Console.ReadLine();
            Console.WriteLine("Please enter your skills:");
            Console.WriteLine("Your summary paragraph:");
            Newpeople.summary = Console.ReadLine();
            Console.WriteLine("Your summary paragraph:");
            Newpeople.summary = Console.ReadLine();
            Console.WriteLine(Newpeople.GetDescription());

        }


        public class resume
        {
            public string Fname { get; set; }
            public string Lname { get; set; }
            public string telenum { get; set; }
            public string address { get; set; }
            public string email { get; set; }
            public string summary { get; set; }
            public string GetDescription()
            {

                return $"\n \n{Fname} {Lname}'s\nResume\n_____________________\nContact information: \n************** \nAddress: {address}\nTelephone: {telenum} \nEmail:{email} \nPersonal profile:\n {summary} .";


            }
        }
    }
}
