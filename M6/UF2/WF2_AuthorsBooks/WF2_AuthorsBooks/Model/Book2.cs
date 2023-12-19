using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WF2_AuthorsBooks.Model
{
    public partial class Book
    {
        public Book()
        {

        }
        public Book(int? authorId, string title, string description, decimal? price)
        {
            AuthorId = authorId;
            Title = title;
            Description = description;
            Price = price;
        }
        public void Update(Book b)
        {
            AuthorId = b.AuthorId;
            Title = b.Title;
            Description = b.Description;
            Price = b.Price;
        }
    }
}
