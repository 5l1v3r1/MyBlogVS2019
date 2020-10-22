using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Data.Seed
{
    public class BlogSeed : IEntityTypeConfiguration<Blog>
    {
        private readonly int[] _ids;

        public BlogSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasData(
                new Blog { Id = 1, CategoryId = _ids[0], UserId = Guid.NewGuid(), Baslik = "Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "Unable to create an object of type 'AppDbContext'. For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728" },
                new Blog { Id = 2, CategoryId = _ids[0], UserId = Guid.NewGuid(), Baslik = "Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "154 / 5000 AppDbContext türünde bir nesne oluşturulamıyor.Tasarım zamanında desteklenen farklı desenler için bkz.Https://go.microsoft.com/fwlink/?linkid=851728" },
                new Blog { Id = 3, CategoryId = _ids[0], UserId = Guid.NewGuid(), Baslik = "Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "makale içeriği" },
                new Blog { Id = 4, CategoryId = _ids[0], UserId = Guid.NewGuid(), Baslik = "Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "mock makale mock mock" }
            );
        }
    }
}