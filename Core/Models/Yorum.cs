using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Yorum
    {
        public Yorum()
        {
            SubYorums = new Collection<Yorum>();
        }
        public int Id { get; set; }
        public int ParentId { get; set; }
        public int BlogId { get; set; }
        public string UserId { get; set; }
        public string Text { get; set; }
        public ICollection<Yorum> SubYorums { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
