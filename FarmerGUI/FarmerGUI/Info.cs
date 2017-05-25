using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//BY: NICK WASIK
namespace FarmerGUI
{
    class Info
    {
        public string DisplayInfo(string assign)
          {
            string authorinfo;
            string assignment;

            authorinfo = "Name: Nick Wasik \n";
            authorinfo = authorinfo + "\nClass: ITDEV115-501\n";
            assignment = "Assignment: " + assign;
            authorinfo = authorinfo + assignment + "\n";
            authorinfo = authorinfo + "Date: " + System.DateTime.Today.ToShortDateString() + "\n";

            return authorinfo;


        }
    }
}
