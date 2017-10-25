using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreSample
{
    public class Book
    {
        public int BookId { get; set; }

        [StringLength(60)]
        public string Title { get; set; }
        public string Publisher { get; set; }
        [StringLength(20)]
        public string Isbn { get; set; }
    }
}
