using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Data
{
   public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
        public int Popular { get; set; }
    }
}
