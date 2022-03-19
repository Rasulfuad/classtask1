using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa.Models
{
    class Book : Product
    {
        public string Genre;
        
        public Book(string genre,int no,string name,int price):base(no,name,price)
        {
            Genre = genre;
            this.No = no;
            this.Name = name;
            this.Price = price;
        }

 
    }
}
