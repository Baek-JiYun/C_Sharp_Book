using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject
{
    public class Book
    {
        public string Isbn { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Page { get; set; }
        public string UserId { get; set; }
        public int isBorrowed { get; set; }
        public DateTime BorrowedAt { get; set; }
    }
}
