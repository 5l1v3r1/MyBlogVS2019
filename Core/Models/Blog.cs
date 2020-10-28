using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Blog
    {
        public Blog()
        {
            Images = new Collection<Image>();
            Etikets = new Collection<Etiket>();
            Yorums = new Collection<Yorum>();
            Videos = new Collection<Video>();
        }

        public int Id { get; set; }
        public string UserId { get; set; }
        public int CategoryId { get; set; }
        public DateTime DateTime { get; set; }
        public byte Points { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Text { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Video> Videos { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
        public ICollection<Etiket> Etikets { get; set; }
        public virtual Category Category { get; set; }

    }
}
