using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booksmangement.Models
{
    public class BookModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string DESCRIPTION { get; set; }
        public int TotalPages { get; set; }
        public string Language { get; set; }
        public int Ages { get; set; }
    }
}
