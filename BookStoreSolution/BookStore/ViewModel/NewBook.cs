using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.ViewModel
{
    public class NewBook
    {
       
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
        public int Popular { get; set; }
    }
}
