using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview

{

    //the default access permissions is private
    //if an outside user of this class wanted access to  the class contents
    //then the access permissions needs to be public
    //if this class was static the class would not hold data (Then it would have methods with algz pub static)
    //for a class to hold data Do Not Make it static unless you want everyone to have access to that data.(Read and change the data)

    class FencePanel
    {
        //Properties
        //A property is associated with a single piece of data
        //A property has two sub components Get and Set
        //Get rerurns a value to the calling client
        //Set sets a value to the property.
        //Method can also use the object 
        //Treat a property loosely like it is a var
        //There are two ways to code a property one is Fully Implemented and the other is called Auto Implemented
        //Auto Implemented property the property does not need a private data member to hold the actual data.
        //The data storage will create its own data member and will be hidden 

        // now an auto implpemented  property

        public int Height { get; set; } 
        public int Width { get; set; }

        //Fully Implemented property
        //Since the property will be doing some actions against the data you must supply
        //a storage area
        //This storage area is referred to as a private data member

        private string _Style;

        //_ underscore hide the variable from access from the internet
        //Private member with underscore is more of a coding style. 


        public string  Style
        {
            get
            {
                return _Style; 
            }

            set
            {               
                if (String.IsNullOrEmpty(value)) //bool test
                {
                    _Style = null;
                }
                else
                {     //value contains the incoming data of the property
                      //the contents of the value need to be stored.
                    _Style = value;
                }
            }
        }

    }
}
