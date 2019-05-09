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
                string Type = "";
                Console.WriteLine("Hello Andy Mhlanga");


                FencePanel anInstance = null;

                FencePanel data = new FencePanel();


                Console.WriteLine("Enter Style of Fence");
                data.Style = Console.ReadLine();
                Console.WriteLine("Enter Width");
                data.Width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height");
                data.Height = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Price");
                data.Price = double.Parse(Console.ReadLine());


                if (data == null)
                {
                    Console.WriteLine("a variable has nothing in it");
                }

                if (anInstance == null)
                {
                    Console.WriteLine("an instance has nothing in it");
                }

                Type = data.Style;

                Console.WriteLine("Fence Type cheosen is {0}", Type);

            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception was caught {0}",ex.Message);
            }

            
        

        } //eom
    }//eoc
}//eon
