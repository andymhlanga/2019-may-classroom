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


            try
            {
              
                Console.WriteLine("Hello Andy Mhlanga"); 
                
                //when this statement is executed the default constructor of the fence panel will be called.
                FencePanel data = new FencePanel();


                Console.WriteLine("Entering Fence Calculator");
                data.Style = "Private";
                
                data.Width = 8.0;
                
                data.Height = 5.8;

                //data.Price = double.Parse(Console.ReadLine());

                Console.WriteLine("Height is {0} \nWdth is {1} \nStyle is {2}",data.Width,data.Height,data.Style);

                //when this statement is executed the default constructor of the fence panel will be called.

                FencePanel gReedy = new FencePanel(4.0,6.8,"Neighbor Love",32.89);

                Console.WriteLine("Height is {0} \nWdth is {1} \nPrice is {2} \nStyle is {3}", gReedy.Width, gReedy.Height,gReedy.Price, gReedy.Style);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception was caught {0}",ex.Message);
            }

            
        

        } //eom
    }//eoc
}//eon
