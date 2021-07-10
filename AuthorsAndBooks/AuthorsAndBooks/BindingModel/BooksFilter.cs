using AuthorsAndBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorsAndBooks.BindingModel
{
    /// <summary>
    /// Book Filter Serach
    /// </summary>
    public class BooksFilter
    {
        public Author Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}
