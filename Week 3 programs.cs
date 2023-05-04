using System;
namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");  
      Console.WriteLine();
    }
    // Design the Class
    class Job
    {
        // this responsibilities
        //Keeps track of the company, job title, start year, and end year.
        public string _companyName ="";
        public string _jobTitle ="";
        public int _startYear ="";
        public int _endYear ="";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Job()
        {
        }

        
        // Displays the job information in the format "Job Title (Company) StartYear-EndYear",
        // for example: "Software Engineer (Microsoft) 2019-2022".
        public void Job()
        {
            Console.WriteLine($"{_jobTitle}, {company}");
            Console.WriteLine($"{_startYear}");
            Console.WriteLine($"{_endYear}");
            Console.WriteLine();
        }


    }
    class Resume
    {
        //Responsibilities:
        //Keeps track of the person's name and a list of their jobs.
        public string _givenName = "";
        public string _familyName = "";
        public string _englishTeacher = "";
        public string _managerAssistant = "";
        public string _humanResources = "";
        public string _entrepreneurship = "";
        public string _partnership = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Resume()
        {
        }

        //Displays the resume, which shows the name first, followed by displaying each one of the jobs.
        //Based on these descriptions, you could create class diagrams like the following:

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }
        public void ResumeInformation()
        {
            Console.WriteLine($"{_englishTeacher}");
            Console.WriteLine($"{_managerAssistant}");
            Console.WriteLine($"{_humanResources}");
            Console.WriteLine($"{_entrepreneurship}");
            Console.WriteLine($"{_partnership}");
            Console.WriteLine();
        }

    }
  }
}


//1) Activity Instructions.
    // the principle of abstraction to create classes to represent a resume or an job history for a person like I being seen on LinkedIn.

// Design the Classes 
// this responsibility of a Person is to hold and display personal my Resume (information).
//    public class Person
    {
        // The C# convention is to start member variables with an underscore _
        public string _givenName = "";
        public string _familyName = "";

        // A special method, called a constructor that is invoked using the  
        // new keyword followed by the class name and parentheses.
        public Person()
        {
        }

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void ShowEasternName()
        {
            Console.WriteLine($"{_familyName}, {_givenName}");
        }

        // A method that displays the person's full name as used in western 
        // countries or <given name family name>.
        public void ShowWesternName()
        {
            Console.WriteLine($"{_givenName} {_familyName}");
        }
    }
    
