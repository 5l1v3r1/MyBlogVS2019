using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Yorum
    {
        public Yorum()
        {
            Yorums = new Collection<Yorum>();
        }
        public int Id { get; set; }
        public int UstYorumId { get; set; }
        public int BlogId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public ICollection<Yorum> Yorums { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
