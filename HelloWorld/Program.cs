using System;
using System.Reflection;
using PrintMessage;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                //Load Assembly at run time
                Assembly AssemblyPrintMessage = Assembly.LoadFile(@"C:\C#\practical\PrintMessage\PrintMessage\bin\Debug\PrintMessage.dll");
                
                //Creating a reference of type Type
                Type TypeOfMessage = assembly.GetType("PrintMessage.Message");

                //create instance of Message Class
                var InstanceOfHelloPrint = Activator.CreateInstance(type);

                string Message = Console.ReadLine();

                //Invoke the PrintTheMessage method of Message Class passing the message local variable as parameter
                Console.WriteLine(type.InvokeMember("PrintTheMessage", BindingFlags.InvokeMethod, null, instanceOfHelloPrint, new object[] { Message }));
            }
            catch(System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TargetInvocationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();

        }
    }
}
