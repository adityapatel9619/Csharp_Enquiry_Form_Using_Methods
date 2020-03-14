using System;

namespace entry
{
    class Program
    {
        /// <summary>
        /// *******Enquiry Form*******
        /// This program is an simple enquiry form made using class and methods
        /// </summary>

        //***Variable declartion***
        public string name,fathername,mothername,email,course, phone;
        public int i,n;

        //***Class Enquiry***
        /// <summary>
        /// This class takes input from the user
        /// </summary>
        public void enquriy()
        {
            //This code ask how many enquiry user wants to enter
            Console.WriteLine("How Many Enteries You Want To Fill(*Note if entered 0 program will terminate):");
            n = Convert.ToInt32(Console.ReadLine());
            
            //for loop used here for multiple and single entries as well 
            for (i = 0; i < n; i++) { 
            Console.Write("Enter Name:");
            name = Console.ReadLine();
            Console.Write("Enter Fathername:");
            fathername = Console.ReadLine();
            Console.Write("Enter Mothername:");
            mothername = Console.ReadLine();
            Console.Write("Email:");
            email = Console.ReadLine();
            Console.Write("Enter Course Name:");
            course = Console.ReadLine();
            Console.Write("Enter Phone Number:");
            phone =Console.ReadLine();
                Console.WriteLine("\n");
            }

            //***Program exit***
            ///<summary>
            ///If user enters 0 the program will terminate
            /// </summary>
            if (n == 0)
            {
                System.Environment.Exit(0);
                
            }
        }

        //***For printing the input values***
        /// <summary>
        /// This program diplays the user input value to admin in invoice format
        /// </summary>
        public void print()
        {
            Console.WriteLine("\n");
            Console.WriteLine("*******Invoice*******");
            for (i = 0; i <n; i++) { 
            Console.WriteLine("Student Name:{0}",name);
            Console.WriteLine("Father Name:{0}", fathername);
            Console.WriteLine("Mother Name:{0}", mothername);
            Console.WriteLine("Email Id:{0}", email);
            Console.WriteLine("Contact No:{0}", phone);
            Console.WriteLine("Course for Enquiry:{0}", course);
                Console.WriteLine("");
                Console.WriteLine("Thanks! We will Contact You Soon ");
               
                
            }
            
        }
       
    }
}
