using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintMessage
{
    public class Message
    {
        //method to print the message
        public string PrintTheMessage(string message)
        {
            //Check for empty message
            if (message.Count() == 0)
            {
                return "Enter valid string-";
            }
            
            else
                return "Hello " + message;

        }
    }
}
