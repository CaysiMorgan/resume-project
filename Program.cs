
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
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


            string work = null;
            var listOfWork = new List<string>();
            Console.WriteLine("Please enter your list of work experience:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("-");
                work = Console.ReadLine();
                listOfWork.Add(work);

            }


            string education = null;
            var listOfedu = new List<string>();
            Console.WriteLine("Please enter your educational qualifications:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("-");
                education = Console.ReadLine();
                listOfedu.Add(education);

            }
            string skill = null;
            var listOfSkills = new List<string>();
            Console.WriteLine("Please enter your list of skills:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("-");
                skill = Console.ReadLine();
                listOfSkills.Add(skill);

            }
            Console.WriteLine(Newpeople.GetDescription());

            
            Console.WriteLine("\n\nEducation: \n*********** ");
            for (int i = (listOfedu.Count - 1); i >= 0; i--)
            {
                var item = listOfedu[i];
                Console.WriteLine($"-{item}");
            }
            Console.WriteLine("\n\nWork Experience: \n*********** ");
            for (int i = (listOfWork.Count - 1); i >= 0; i--)
            {
                var item = listOfWork[i];
                Console.WriteLine($"-{item}");
            }
            Console.WriteLine("\n\nSkills: \n*********** ");
            for (int i = (listOfSkills.Count - 1); i >= 0; i--)
            {
                var item = listOfSkills[i];
                Console.WriteLine($"-{item}");
            }
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
