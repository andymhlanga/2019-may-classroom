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
            string Type = "";
            Console.WriteLine("Hello Andy Mhlanga");    
    

            FencePanel anInstance = null;

            FencePanel data = new FencePanel();


            Console.WriteLine("Enter Style of Fence");
            data.Style = Console.ReadLine(); ;

            if(data == null)
            {
                Console.WriteLine("a variable has nothing in it");
            }

            if (anInstance == null)
            {
                Console.WriteLine("an instance has nothing in it");
            }

            Type = data.Style;

            Console.WriteLine("Fence Type cheosen is {0}",Type);


        } //eom
    }//eoc
}//eon
