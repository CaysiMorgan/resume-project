using System;
using System.Text;
using System.Collections.Generic;
namespace ConsoleApp3

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    **WElCOME**");
            Console.WriteLine(" To The Resume Maker");
            Console.WriteLine("_____________________");
            Console.Write("Press 'Enter' to continue...\n");
            // here it asks to press the enter key to exit
            Console.ReadKey();
            Console.Clear();

            int choice;
            var newpeople = new Resume();
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());
            //loop condition

            while (choice >= 1 && choice <= 10)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter first name:");
                        newpeople.FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write(" Enter Last name:");
                        newpeople.LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("Enter your address:");
                        newpeople.Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Enter telephone number:");
                        newpeople.Telenum = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Enter email address:");
                        newpeople.Email = Console.ReadLine();
                        break;
                    case 6:
                        Console.WriteLine("Your Summary paragraph:");
                        newpeople.Summary = Console.ReadLine();
                        break;
                    case 7:
                        Console.WriteLine("Add skills:");
                        newpeople.Skills.Add(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("Add educational qualifications:");
                        newpeople.Education.Add(Console.ReadLine());
                        break;
                    case 9:
                        Console.WriteLine("Add work experience:");
                        newpeople.WorkExperience.Add(Console.ReadLine());
                        break;
                    case 10:
                        Console.WriteLine("Display Resume:");
                        Console.WriteLine(newpeople.GetDescription());
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Invalid option!!");
                        Console.Clear();
                        DisplayMenu();
                        break;
                        //end of default
                }//end of switch
                Console.Clear();
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());
            }//end while loop
        }
        static void DisplayMenu()
        {
            Console.WriteLine("***Menu***");
            Console.WriteLine("_____________________");
            Console.WriteLine("");
            Console.WriteLine("1-Enter first name:");

            Console.WriteLine("2-Enter last name:");

            Console.WriteLine("3-Enter address:");

            Console.WriteLine("4-Enter Telephone number:");

            Console.WriteLine("5-Enter Email:");

            Console.WriteLine("6-Enter Summary:");

            Console.WriteLine("7-Add skills:");

            Console.WriteLine("8-Add educational qualifications:");

            Console.WriteLine("9-Add work experience:");

            Console.WriteLine("10-Display Resume:");

            Console.WriteLine("_____________________");

            Console.WriteLine("Enter 0 to exit");

            Console.WriteLine("_____________________");

            Console.WriteLine("");

            Console.WriteLine("Please select a number from the menu to continue");

        }//end of display menu

    }



    public class Resume
    {
        public Resume()
        {
            Skills = new List<string>();
            WorkExperience = new List<string>();
            Education = new List<string>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telenum { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Summary { get; set; }
        public List<string> Skills { get; set; }

        public List<string> WorkExperience { get; set; }
        public List<string> Education { get; set; }
        public string GetDescription()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"{FirstName} {LastName}");
            stringBuilder.AppendLine($"Resume");
            stringBuilder.AppendLine($"___________");
            stringBuilder.AppendLine($"Contact Information");
            stringBuilder.AppendLine($"*******************");
            stringBuilder.AppendLine($"Address:{Address}");
            stringBuilder.AppendLine($"Telephone: {Telenum}");
            stringBuilder.AppendLine($"Email: {Email}");
            stringBuilder.AppendLine($"*******************");
            stringBuilder.AppendLine($"");
            stringBuilder.AppendLine($"Personal Profile:");
            stringBuilder.AppendLine($"{Summary}");
            stringBuilder.AppendLine($"Skills:");
            foreach (string Skill in Skills) { stringBuilder.AppendLine($"-{Skill}"); }
            stringBuilder.AppendLine($"Educational qualifications:");
            foreach (string educational in Education) { stringBuilder.AppendLine($"-{educational}"); }
            stringBuilder.AppendLine($"Work experience:");
            foreach (string work in WorkExperience) { stringBuilder.AppendLine($"-{work}"); }
            return stringBuilder.ToString();
        }

    }//end of resume 

}//end of namespace

