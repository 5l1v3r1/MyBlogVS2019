using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Seed
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = _ids[0], Name = "Elektronik", ParentId = 0, Description = "ParentId = 0" },
                new Category { Id = _ids[1], Name = "Kırtasiye", ParentId = 0, Description = "ParentId = 0" },
                new Category { Id = _ids[2], Name = "Bilgisayar", ParentId = 1, Description = "ParentId = 1" },
                new Category { Id = _ids[3], Name = "Notebook", ParentId = 3, Description = "ParentId = 3" },
                new Category { Id = _ids[4], Name = "Lpatop", ParentId = 4, Description = "ParentId = 4" }
            );
        }

        //public List<Category> GetAllCategoriesWithChilds(int categoryId)
        //{
        //    List<Category> result = new List<Category>();
        //    GetChilds(categoryId, result);
        //    return result;
        //}

        //private void GetChilds(int categoryId, List<Category> listCategories)
        //{
        //    var categories = DBCategories.Where(p => p.ParentId == categoryId).ToList();
        //    if (categories.Any())
        //    {
        //        foreach (var cat in categories)
        //        {
        //            if (cat.SubCategories == null)
        //                cat.SubCategories = new List<Category>();

        //            GetChilds(cat.Id, cat.SubCategories);
        //            if (!listCategories.Contains(cat))
        //                listCategories.Add(cat);
        //        }
        //    }
        //}

    }
}