using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class Book
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public Genre Genres { get; set; }

        public override string ToString()
        {
            return ($"Id {Id} -- Name {Name} -- CostPrice {CostPrice} -- SalePrice {SalePrice}");
        }
    }
}
