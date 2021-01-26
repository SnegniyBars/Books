using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public byte[] CoverImage { get; set; }
        public int PublishingYear { get; set; }
        public string Author { get; set; }
    }
}
