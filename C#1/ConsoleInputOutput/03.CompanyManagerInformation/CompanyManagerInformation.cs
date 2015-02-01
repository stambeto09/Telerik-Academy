using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CompanyManagerInformation
{
    class CompanyManagerInformation
    {
        static void Main()
        {
            Console.Write("Enter first name of the company: ");
            string companyName = Console.ReadLine();
            
            Console.Write("Enter adress of the company: ");
            string comanyAdress = Console.ReadLine();

            Console.Write("Enter number of the company: ");
            int phoneNumberCompany = int.Parse(Console.ReadLine());

            Console.Write("Enter fax number of the company: ");
            string faxNumberCompany = Console.ReadLine();

            Console.Write("Enter web page of the company: ");
            string webSiteCompany = Console.ReadLine();

            Console.Write("Enter name of the manager: ");
            string manager = Console.ReadLine();


            //Manager parameters

            Console.Write("Enter last name of the manager: ");
            string lastNameManager = Console.ReadLine();

            Console.Write("Enter age of the manager: ");
            uint ageManager = uint.Parse(Console.ReadLine());

            Console.Write("Enter phone number of the manager: ");
            int numberManager = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Printing
            Console.WriteLine("The information about the company:");
            Console.WriteLine(companyName);
            Console.WriteLine(comanyAdress);
            Console.WriteLine(phoneNumberCompany);
            Console.WriteLine(faxNumberCompany);
            Console.WriteLine(webSiteCompany);
            Console.WriteLine();

            Console.WriteLine("The information about manager: ");
            Console.WriteLine(manager);
            Console.WriteLine(lastNameManager);
            Console.WriteLine(ageManager);
            Console.WriteLine(numberManager);




        }
    }
}
