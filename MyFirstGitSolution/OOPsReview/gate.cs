using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    public class Gate
    {
       
        public double Height { get; set; }
        public double Width { get; set; }
        private string _Style;
        public double? Price;

        public Gate (){
            }

        public Gate(double width, double height, string style, double? price)
        {
            Width = width;
            Height = height;
            _Style = style;
            Price = price;
        }



        public string Style
        {
            get
            {
                return _Style;
            }

            set
            {

                if (String.IsNullOrEmpty(value)) 
                {
                    _Style = null;
                }
                else
                {    
                    _Style = value;
                }

            }
        }


        //Read only property
        //Contains no set()
        //Data used in this property is data that is currently within the instance of this class.

        public double GateArea
        {
            get
            {
                return (Height * Width);
            }
        }





    }
}
