using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa.Models
{
    class Product
    {
        public int No;
        public string Name;
        public int Price;
        public int Count;

       


        public Product(int no,string name,int price)
        {
            this.No = no;  
            this.Name = name;   
            this.Price = price; 
        }
       

    }

}
