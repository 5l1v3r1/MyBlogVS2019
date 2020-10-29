using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Core.Models
{
    public class Category
    {
        public Category()
        {
            Blogs = new Collection<Blog>();
            SubCategories = new Collection<Category>();
        }
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Category> SubCategories { get; set; }

    }
}