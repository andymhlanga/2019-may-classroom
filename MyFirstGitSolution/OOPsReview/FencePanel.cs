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

        public int Height;
        public int Width;


    }
}
