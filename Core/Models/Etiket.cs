namespace Core.Models
{
    public class Etiket
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Text { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
