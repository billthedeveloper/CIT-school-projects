using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_4._2

{
    class Program
    {
        //A menu method that proceses a menu in a loop
        static void Main(string[] args)

        {
            //four seperate simple types of declared parrallel arrays for each type of respective employee information
            // array that stores the names of the employees
            string[] names = new string[100];
            // array that stores the hours of the employees
            double[] hours = new double[100];
            // array that stores the payrates of the employees
            double[] payrates = new double[100];
            // array that store the grosspay of the employees
            double[] grossPay = new double[100];

           
            int counter = 0; 
            int menuchoice = 0;
            // a while loop that processes a menu that ends when 4 is selected by a user
            while (menuchoice != 4)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("Please enter the number that you want to do:");
                Console.WriteLine("1. Input employees’ information {0}", 1);
                Console.WriteLine("2. Compute pay for all employees {0}", 2);
                Console.WriteLine("3. Display payroll report {0}", 3);
                Console.WriteLine("4. Exit {0}", 4);
                Console.WriteLine();
                Console.WriteLine("Counter equals {0}", counter); 
                menuchoice = int.Parse(Console.ReadLine());

                // switch case statements that allows the user to access the methods so that they can input information 
                switch (menuchoice)
                {

                    case 1:
                        Console.WriteLine("Input employees’ information");
                        //this is where i call the method
                        counter = inputData(names, hours, payrates);
                        break;

                    case 2:
                        Console.WriteLine("Compute pay for all employees");
                        computePay(hours, payrates, grossPay);
                        Console.ReadLine();
                        break;
                        case 3:
                            Console.WriteLine("Display payroll report");
                            displayPay(names, hours, payrates, grossPay, counter);
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Thank you for using our payroll application");
                            Console.ReadLine();
                            break;

                      default: 
                          Console.WriteLine("invalid option");
                          Console.ReadLine();
                        break;


                }
            }
        }

        // This method receives the names, hours, and payrates arrays and the counter.
        static int inputData(string[] names, double[] hours, double[] payrates) 
        {
            int insideCounter = 0; 

            string response;
            Console.WriteLine("Are there any employee paycards to input ? y or n");
            response = Console.ReadLine();
            /*loop that has statements to input employee name, hours worked and pay rate for one employee and save them in the arrays.
             The loop should repeat until a user enters ‘n’ in response to the question */
            
            while (response != "n")
            {
                Console.WriteLine("Enter employee name");
                names[insideCounter] = Console.ReadLine(); 
                Console.WriteLine("Enter employee hours");
                hours[insideCounter] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter employee payrate");
                payrates[insideCounter] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you have more employee pay cards to enter ? y or n");
                response = Console.ReadLine();
                insideCounter++;


            }
            // there is where i return the counter
            return insideCounter; 
        }

        // this is my computePay that is supposed to recieve these paramters
        static void computePay(double[] hours, double[] payrates, double[] grossPay)
        {
            int insideCounter = 0;
            /*a loop to calculate the gross amount to be paid to
            each employee and save the amount in the grosspays array as follows */
            for (int empNumber = 0; empNumber < insideCounter; empNumber++)
            {
               
                if (hours[empNumber] <= 40)
                {
                    grossPay[empNumber] = hours[empNumber] * payrates[empNumber];
                }
                else if (hours[empNumber] > 40)
                {
                    grossPay[empNumber] = 40 * payrates[empNumber] + (hours[empNumber] - 40) * payrates[empNumber];
                }
            }
             
        }

        /* a method that receives all the arrays and the counter as parameters. */
        static void displayPay(string[] names, double[] hours, double[] payrates, double[] grossPay, int counter)
        {
            Console.WriteLine("DOODAD MANUFACTURING COMPANY APRIL PAYROLL");
            Console.ReadLine();
            
            for (int empNumber = 0; empNumber < counter; empNumber++)
            {

                Console.WriteLine("EMPLOYEE NAME: " + "{0}, " + "HOURS WORKED: " + "{1}, " + "PAY RATE: " + "{2}, " + "GROSS PAY: " + "{3}", names[empNumber], hours[empNumber], payrates[empNumber], grossPay[empNumber]);
                Console.ReadLine();
            }

        }

    }
}
 