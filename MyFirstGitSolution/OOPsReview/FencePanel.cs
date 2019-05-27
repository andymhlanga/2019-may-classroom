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

   public class FencePanel    
    {

       
        //Properties.these are examples
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

        public double Height { get; set; } 
        public double Width { get; set; }

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

        // ? means it can hold numeric or null
        //a nullable numeric will contain a numebr or null 
        //nullable numerics do not need to be implemented unless you have additional criteria to cover.
        public double? Price { get; set; }

        //Contructors
        //Are exuted for the client caller during 
        //the execuion of the new command
        //if no constructors are coded then the default constructor is created 
        //data storage within the class definition is set
        //the system defaults string numeric  -> null or bool to false
        //if coder creates one constructor then the coder is responsible for ll constructors

        //default simulates the system initialization of your data storage type 
        public FencePanel()
        {
           //optionally you may wish to have your own default values for the storage items.
        }


        //Greedy Constructor this has a parameter list of all data storage items defined within the class definition. 
        public FencePanel(double width, double height, string style, double? price)
        {
            Width = width;
            Height = height;
            _Style = style;
            Price = price;
        }

        //Behavior (aka method)

        public double EstimateNumberOfPanels(double linearLength)
        {           
           
            double numberOfPanels = linearLength / Width;

            return numberOfPanels;
        }


    }  

}
