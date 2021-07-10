using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthorsAndBooks.Models
{
    public class Book
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Descripcion
        /// </summary>
        public string Descripcion { get; set; }
        /// <summary>
        /// PageCount
        /// </summary>
        public int PageCount { get; set; }
        /// <summary>
        /// Excerpt
        /// </summary>
        public string Excerpt { get; set; }
        /// <summary>
        /// PublishDate
        /// </summary>
        public DateTime PublishDate { get; set; }
    }
}
