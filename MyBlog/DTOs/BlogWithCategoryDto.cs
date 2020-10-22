using Core.Models;
using System.Collections.Generic;

namespace MyBlog.DTOs
{
    public class BlogWithCategoryDto : BlogDto
    {
        public IEnumerable<CategoryDto> Category { get; set; }
    }
}
