using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace NorthWindSystem.Data
{
    //the default access type is private you must alter this to public or else it will be inaccessible
    //add refences Sys.Comp.Model.Data.Annot

    //use a data annotation to point this class to the appropiate sql table 
    [Table("Products")]
    public class Product
    {

        //private data members


        private string _QuantityPerUnit;
        //setup a property for each attribute on your sql table
        //Rules:
        // if your property name is the same as the sql attribute order of properties does not matter
        // sql data types do not always match c#, check for the correct C# datatype to match the SQl data type 

        //some properties wll need annotation
        //Primary Key
        //[Key] default sql identity field
        //[Key,DatabaseGenerated(DatabaseGeneratedOption.None)]) non identity pkey
        //[Key,Column(Order=1)][Key,Column(Order=2)].... compound pkey

        //Procudts is an sql identity pkey field

        [Key]
        public int ProductID { get; set; }

        //entity properties can have their own validation placed on the property


        [Required(ErrorMessage = "Product name is required")]
        [StringLength(160,ErrorMessage= "Product is limited to 160 characters")]
        public string ProductName { get; set; }
        
        public int? SupplierID { get; set; } // sql field is nullable rembmer ?
        public int? CategoryID { get; set; }

        //nullable strings must be fully implemented
        [StringLength(25, ErrorMessage = "Qty per unit is limited to 160 characters")]
        public string QuantityPerUnit
        {
            get
            {
                return _QuantityPerUnit;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _QuantityPerUnit = null;
                }
                else
                {
                    _QuantityPerUnit = value;
                }
            }
        }


        [Range(0.00,double.MaxValue,ErrorMessage ="Unit price must be 0.0 or greater")]
        public decimal? UnitPrice { get; set; }
        [Range(0, Int16.MaxValue, ErrorMessage = "Units in stock must be 0 or greater")]
        public Int16? UnitsInStock { get; set; }
        [Range(0, Int16.MaxValue, ErrorMessage = "Units on order must be 0 or greater")]
        public Int16? UnitsOnOrder { get; set; }
        [Range(0, Int16.MaxValue, ErrorMessage = "Reorder level  must be 0 or greater")]
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        //readonly display fields to be used within the application these properties are not mapped to ANY SQL table atr
        //to do this use the notmapped annotation
        [NotMapped]
        public string ProductDescription
        {
            get
            {
                return ProductName + "(" + ProductID + ")";
            }
        }

        //next bring in nuget pakage extitiy framework 6.2 on system
       // Enter Attribute reference system.data.entity responsibility is data transfer between sql and project
       //using what is called a db context gives you a front door for data access 
    }
}
