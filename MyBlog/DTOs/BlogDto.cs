using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.DTOs
{
    public class BlogDto
    {
        public Guid UserId { get; set; }
        //public DateTime DateTime { get; set; }
        //public byte Points { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Text { get; set; }
    }
}
