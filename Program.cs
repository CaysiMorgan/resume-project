
using System;
using System.Collections.Generic;
using System.Text;
namespace resume
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instance of a resume
            var newpeople = new resume();

            Console.WriteLine(" Welcome to your Resume ");
            Console.WriteLine(" ***************************");
            Console.WriteLine("Please enter your name:");
            Console.Write(" First name:");
            newpeople.firstName = Console.ReadLine();
            Console.Write(" Last name:");
            newpeople.lastName = Console.ReadLine();
            Console.Write("Please enter your address:");
            newpeople.address = Console.ReadLine(); 
            Console.Write("Please enter your telephone number:");
            newpeople.telenumber = Console.ReadLine();
            Console.Write("Please enter your email address:");
            newpeople.email = Console.ReadLine();
            Console.WriteLine("Your Summary paragraph:");
            newpeople.Summary = Console.ReadLine();
            Console.WriteLine("Please enter your list of skills:");
            newpeople.skills.Add(Console.ReadLine());
            Console.WriteLine("Please enter your list of educational qualifications:");
            newpeople.education.Add(Console.ReadLine());
            Console.WriteLine("Please enter your list of work experince :");
            newpeople.WorkExperience.Add(Console.ReadLine());
            Console.WriteLine(newpeople.GetDescription());
        }
        public class resume
        {
            public resume()
            {
                skills = new List<string>();
                WorkExperience = new List<string>();
                education = new List<string>();
            }

            public string firstName { get; set; }
            public string lastName { get; set; }
            public string telenumber { get; set; }
            public string address { get; set; }
            public string email { get; set; }
            public string Summary { get; set; }
            public List<string>  skills { get; set; }
            
            public List<string> WorkExperience { get; set; }
            public List<string> education { get; set; }
            public string GetDescription() 
            {
                var stringBuilder = new StringBuilder();
                
                    stringBuilder.AppendLine($"{firstName} {lastName}");
                    stringBuilder.AppendLine($"Resume");
                    stringBuilder.AppendLine($"___________");
                    stringBuilder.AppendLine($"Contact Information");
                    stringBuilder.AppendLine($"*******************");
                    stringBuilder.AppendLine($"address:{address}");
                    stringBuilder.AppendLine($"Telephone: {telenumber}");
                    stringBuilder.AppendLine($"E" +
                        $"" +
                        $"mail: {email}");
                    stringBuilder.AppendLine($"Personal Profile:");
                    stringBuilder.AppendLine($"{Summary}");
                foreach (string Skill in 
                    skills) 
                {
                    stringBuilder.AppendLine($"Skills:{Skill}");
                }

                foreach (string educational in
                    education)
                {
                    stringBuilder.AppendLine($"educational qualifications:{educational}");
                }

                foreach (string work in
                    WorkExperience)
                {
                    stringBuilder.AppendLine($"Work Experience:{work}");
                }
                return stringBuilder.ToString();
                

            }

        } 
    }
        
}
   

