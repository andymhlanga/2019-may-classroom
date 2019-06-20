using NorthWindSystem.DAL;
using NorthWindSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindSystem.BLL
{
   public class SupplierController
    {

        //Entity framework extension method will retrieve all records for the Dbset OF <t>

        public List<Product> Product_List()
        {
            using (var context = new NorthWindSystemContext())
            {

                //ensure you add the .TOList to your property.
                return context.Products.ToList();
            }
        }



        public Product Product_FindByID(int productid)
        {
            using (var context = new NorthWindSystemContext())
            {
                return context.Products.Find(productid);
            }
        }

    }
}
