using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using System.Data.Entity;
using NorthWindSystem.Data;
#endregion


namespace NorthWindSystem.DAL
{
    //we wish to restrict public access to this class to classes within this project
    //The defualt access is private set access type t internal
    //this class need to inherit the entity framework abilities 
    //for a class to enherit the ability it can use  OOP inheritance

    internal class NorthWindSystemContext:DbContext
    {

        //the contructor will pass to the inherited class DbContext your web connection string name

        public NorthWindSystemContext() : base("NWDB")
        {
           

        }
        //Set up the data collection set for each entity in your application
        //each Dbset<T> will hold the data transfer for that partivular entity class
        //each Dbset<t> definition is a property of this context class
        //course standard: Dbset<T> will be plural
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }

}

