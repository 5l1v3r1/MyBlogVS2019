using Core.Models;
using System.Collections.Generic;

namespace MyBlog.DTOs
{
    public class CategoryWithBlogDto : CategoryDto
    {
        public IEnumerable<BlogDto> Blogs { get; set; }
    }
}
