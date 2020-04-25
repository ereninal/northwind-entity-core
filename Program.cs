using System;
using database_existing_entity.Data.EfCore;
using System.Linq;

namespace database_existing_entity
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new NorthwindContext())
            {
                var products = db.Customers.Select(c=>new {
                    c.ContactName,
                    c.ContactTitle
                });
                foreach (var item in products)
                {
                    Console.WriteLine(item.ContactName+" "+item.ContactTitle);
                }
            }
        }
    }
}
