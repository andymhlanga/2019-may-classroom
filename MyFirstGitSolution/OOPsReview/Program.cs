using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        static void Main(string[] args)
        {          

            //Console is a reference to a system static class
            //static classes are used by typing the class name
            //static classes do not store variable data
            //static classes are used by everyone
            //methods of a static class will be placed after
            //      the object dot operator
            Console.WriteLine("Hello World");

            //Create an instance of a non static class
            //If you create a declarative using JUST the
            //   class name then this is ONLY a pointer
            //   that can hold an instance of the class
            //   specified;
            //Current value of aVariable is null
           // FencePanel aVariable = null;

            //if you use the new command with the class
            //   the new command will physically create
            //   an instance of the class

            //when this statement is executed, the Default
            //   constructor of the FencePanel class will
            //   be called on your behave.
            FencePanel anInstance = new FencePanel();
            anInstance.Height = 5.8;
            anInstance.Width = 8.0;
            anInstance.Style = "Neighbour Friendly";

            Console.WriteLine("height is: " + anInstance.Height.ToString());
            Console.WriteLine("width is: " + anInstance.Width.ToString());
            Console.WriteLine("style is: " + anInstance.Style);
            Console.WriteLine("price is: " + anInstance.Price.ToString() + "\n");

            //when this statement is executed, the Greedy
            //   constructor of the FencePanel class will
            //   be called on your behave.
            FencePanel anGInstance = new FencePanel(4.0, 6.8, "private", 32.89);
            Console.WriteLine("height is: " + anGInstance.Height.ToString());
            Console.WriteLine("width is: " + anGInstance.Width.ToString());
            Console.WriteLine("style is: " + anGInstance.Style);
            Console.WriteLine("price is: " + anGInstance.Price.ToString() + "\n");
            
            //using instances of classes 

            Console.WriteLine("\n Entering Data \n");
            string menuItem = "0";

            FenceEstimate CustomerFence = new FenceEstimate();
            CustomerFence.Fence = anGInstance;

            CustomerFence.Gates = new List<Gate>();
            string inputValue;
            Gate theGate = null; // create an empty taxi both techniques will work



            do
            {
                theGate = new Gate();// taxi is being re-used
                Console.WriteLine("Height");
                inputValue = Console.ReadLine();
                theGate.Height = double.Parse(inputValue);



                Console.WriteLine("Width");
                inputValue = Console.ReadLine();
                theGate.Width = double.Parse(inputValue);

                Console.WriteLine("Style");
                theGate.Style = Console.ReadLine();


                Console.WriteLine("Price");
                inputValue = Console.ReadLine();

                if (string.IsNullOrEmpty(inputValue))
                {
                    theGate.Price = null;
                }
                else
                {
                    theGate.Price = double.Parse(inputValue);
                }


                //the local instance of gate needs to be saved to the Fence Estimate
                CustomerFence.Gates.Add(theGate);


                Console.WriteLine("Add another gate (Y / N)");
                inputValue = Console.ReadLine();

                //Ternary operator
                menuItem = inputValue.ToUpper().Equals("Y") ? "1" : "0";


            } while (menuItem != "0");

            Console.WriteLine("Fence length");
            inputValue = Console.ReadLine();
            double Linearlength = double.Parse(inputValue);


            //Using the customer fence data calculate the cost
            double numebrOfPanels = CustomerFence.Fence.EstimateNumberOfPanels(Linearlength);

            double FencePrice = Math.Ceiling(numebrOfPanels) * double.Parse(CustomerFence.Fence.Price.ToString());//+0.5 rounded and floor makes sure you go to the next highest numer of panels.

            double gatecost = 0.0;

            foreach (Gate item in CustomerFence.Gates)
            {
                gatecost = double.Parse(item.Price.ToString());
            }



            Console.WriteLine("Total Fence Extimate");
            Console.WriteLine("Style chosen:");
            Console.WriteLine("Number of Panels" + numebrOfPanels.ToString());
            Console.WriteLine("Cost of Panels" + FencePrice.ToString());
            Console.WriteLine("Number of Gates" + CustomerFence.Gates.Count.ToString());
            Console.WriteLine("Total" + (FencePrice + gatecost).ToString());




        } //eom
    }//eoc
}//eon



