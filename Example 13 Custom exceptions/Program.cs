using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProcessMultipleExceptions
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("***** Handling Multiple Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);

            #region Try/catch logic
            try
            {
                // Trip Arg out of range exception.
                //myCar.Accelerate(-5);
                myCar.Accelerate(1000);
                //int a = 2 - 2;
                //int b = 1 / a;
            }
            catch (CarIsDeadException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            // This will catch any other exception
            // beyond CarIsDeadException or
            // ArgumentOutOfRangeException.
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                // This will always occur. Exception or not.
                myCar.CrankTunes(false);
            }
            #endregion

            Console.ReadLine();
        }
    }
}
