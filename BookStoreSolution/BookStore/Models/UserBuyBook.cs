using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class UserBuyBook
    {
       public List<Book> bookForCart = new List<Book>();
        public void Add(Book bookFor)
        {
            bookForCart.Add(bookFor);
        }
        public List<Book> showAllCart()
        {
            return bookForCart;
        }
    }
}
