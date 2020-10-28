using System.Collections.Generic;

namespace API.DTOs
{
    public class BlogWithCategoryDto : BlogDto
    {
        public IEnumerable<CategoryDto> Category { get; set; }
    }
}
