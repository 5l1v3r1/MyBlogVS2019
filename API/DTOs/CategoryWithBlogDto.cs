using System.Collections.Generic;

namespace API.DTOs
{
    public class CategoryWithBlogDto : CategoryDto
    {
        public IEnumerable<BlogDto> Blogs { get; set; }
    }
}
