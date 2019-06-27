﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using NorthwindSystem.Data;
using NorthwindSystem.DAL;
using System.Data.SqlClient;
using System.ComponentModel; //to expose items for the ods configuring wizard 
#endregion

namespace NorthwindSystem.BLL
{//Expose the class to the ods wizard

    [DataObject]
    public class ProductController
    {

        //EntityFramework extension method will retreive all 
        //records for the DbSet<T>
        public List<Product> Product_List()
        {
            using (var context = new NorthwindSystemContext())
            {
                //ensure you add the .ToList() to your property
                //to convert the entityframe return datatype to
                // this method's return datatype
                //they MUST match
                return context.Products.ToList();
            }
        }
        //EntityFramework extension method will retreive a parrticular 
        //record from the DbSet<T> base on the records's primary key
        //field
        public List<Product> Products_GetByPartialProductName(string partialname)
        {
            using (var context = new NorthwindSystemContext())
            {
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetByPartialProductName @PartialName",
                                    new SqlParameter("PartialName", partialname));
                return results.ToList();
            }
        }

        public List<Product> Products_GetByCategories(int categoryid)
        {
            using (var context = new NorthwindSystemContext())
            {
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID",
                                    new SqlParameter("CategoryID", categoryid));
                return results.ToList();
            }
        }

        public List<Product> Products_GetBySupplierPartialProductName(int supplierid, string partialproductname)
        {
            using (var context = new NorthwindSystemContext())
            {
                //sometimes there may be a sql error that does not like the new SqlParameter()
                //       coded directly in the SqlQuery call
                //if this happens to you then code your parameters as shown below then
                //       use the parm1 and parm2 in the SqlQuery call instead of the new....
                //don't know why but its weird
                //var parm1 = new SqlParameter("SupplierID", supplierid);
                //var parm2 = new SqlParameter("PartialProductName", partialproductname);
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetBySupplierPartialProductName @SupplierID, @PartialProductName",
                                    new SqlParameter("SupplierID", supplierid),
                                    new SqlParameter("PartialProductName", partialproductname));
                return results.ToList();
            }
        }

        public List<Product> Products_GetForSupplierCategory(int supplierid, int categoryid)
        {
            using (var context = new NorthwindSystemContext())
            {
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetForSupplierCategory @SupplierID, @CategoryID",
                                    new SqlParameter("SupplierID", supplierid),
                                    new SqlParameter("CategoryID", categoryid));
                return results.ToList();
            }
        }

        public List<Product> Products_GetByCategoryAndName(int category, string partialname)
        {
            using (var context = new NorthwindSystemContext())
            {
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetByCategoryAndName @CategoryID, @PartialName",
                                    new SqlParameter("CategoryID", category),
                                    new SqlParameter("PartialName", partialname));
                return results.ToList();
            }
        }

        public Product Product_FindByID(int productid)
        {
            using (var context = new NorthwindSystemContext())
            {
                return context.Products.Find(productid);
            }
        }

        //out of System.Data.SqlClient, use the SqlQuery<T>() method to
        //   search for data that is NOT a) the entire list or b) by the primary
        //   key field

            //expose a method to the ODS Wizard you only have to expose the methods you want 
            //All quiries will be select
            // false is not making the method default
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Product> Product_FindByName(string productname)
        {
            using (var context = new NorthwindSystemContext())
            {
                //syntax
                //context.Database.SqlQuery<T>("sqlprocname [@parameterid[, @parameterid]]"[,
                //   new SqlParameter("paramerterid", methodvarible)
                //   [, new SqlParameter("paramerterid", methodvarible) ]])

                //Samples
                //context.Database.SqlQuery<T>("sqlprocname")
                //context.Database.SqlQuery<T>("sqlprocname @parameterid",
                //   new SqlParameter("paramerterid", methodvarible))
                //context.Database.SqlQuery<T>("sqlprocname @parameterid, @parameterid",
                //   new SqlParameter("paramerterid", methodvarible)
                //   , new SqlParameter("paramerterid", methodvarible))
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetByPartialProductName @PartialName",
                   new SqlParameter("PartialName", productname));
                return results.ToList();
            }
        }
    }
}
