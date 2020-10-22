namespace Core.Models
{
    public class Image
    {
        public int Id { get; set; }
        public int BlogId { get; set; }
        public string Path { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
