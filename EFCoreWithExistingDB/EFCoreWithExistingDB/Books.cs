using System;
using System.Collections.Generic;

namespace EFCoreWithExistingDB
{
    public partial class Books
    {
        public int BookId { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
    }
}
