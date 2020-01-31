using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Organisation
    {
        static protected string OrgName="LTI";
         public  int RegNo;

      internal  Organisation(int RegNo)
        {
            this.RegNo = RegNo;
            Console.WriteLine("Organisation COnstruction");
        }

        internal protected void DisplayOrgDetails()
        {
            Console.WriteLine("OrganizationName={0} ,RegistrationNumber={1}",OrgName,RegNo);
        }
        ~Organisation()
        {
            Console.WriteLine(" Organisation Destructor");
        }
    }


    class Employeedetails : Organisation
    {
        internal int Empid;
       internal string EmpName;


        internal Employeedetails(int RegNo, int Empid, string EmpName) : base(RegNo)
        {
            this.RegNo = RegNo;
            this.Empid = Empid;
            this.EmpName = EmpName;
            Console.WriteLine("Employee Details");

        }
        internal void Display()
        {
            Console.WriteLine("Company Register Name={0}, EmployeeId={1},EmployeeName={2}",RegNo,Empid,EmpName);
            
        }
        ~Employeedetails()
        {
            Console.WriteLine("Employeedetails destructor");
        }

    }

    class Project: Employeedetails
    {
        string Activity;
        internal Project(int RegNo, int Empid, string EmpName,string activity) : base(RegNo,Empid,EmpName)
        {
            this.RegNo = RegNo;
            this.Empid = Empid;
            this.EmpName = EmpName;
            this.Activity = activity;
            Console.WriteLine("Project Details");

        }
        ~Project()
        {
            Console.WriteLine("Project Destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Project p = new Project(1001, 1, "vivek", "play");
            p.Display();
            p.DisplayOrgDetails();
            Console.Read();
        }
    }
}
