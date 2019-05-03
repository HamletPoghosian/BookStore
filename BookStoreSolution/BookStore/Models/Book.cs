﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public int AuthorID { get; set; }
        public DateTime PublishDate { get; set; }
        public int Price { get; set; }
        public int Popular { get; set; }

    }
}