using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public partial class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public Category(int id, string name)
        {
            this.CategoryID = id;
            this.CategoryName = name;
        }
    }
}
