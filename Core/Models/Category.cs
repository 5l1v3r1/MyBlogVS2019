using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Category
    {
        public Category()
        {
            Blogs = new Collection<Blog>();
            Categories = new Collection<Category>();
        }
        public int Id { get; set; }
        public int UstCategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
