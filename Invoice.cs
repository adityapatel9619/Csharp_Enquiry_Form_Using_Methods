using System;
using System.Collections.Generic;
using System.Text;

namespace entry
{
    class Invoice
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("********Enquiry Form********");
            ///<summary>
            ///This section is calling methods by creating objects or instance
            /// </summary>
            Program p = new Program();
            p.enquriy();
            p.print();




            ///This section is under development phase
            ///<summary>
            ///This section will work after submittng the for systemm will ask for one more chance for new entries
            /// </summary>

            /*int a;
            Console.WriteLine("Do you wnat to enter");
            a = Convert.ToInt32(Console.ReadLine());
            do
            {
                p.enquriy();
                p.print();

            } while (a == 1);

            if (a == 0)
            {
                System.Environment.Exit(0);
            }*/

        }

    }
}
