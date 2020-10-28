using System;

namespace API.DTOs
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
