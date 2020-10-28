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
                new Blog { Id = _ids[0], CategoryId = 1, UserId = "user777COlombo", Baslik = "Elektronik  Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "Unable to create an object of type 'AppDbContext'. For the different patterns supported at design time, see https://go.microsoft.com/fwlink/?linkid=851728" },
                new Blog { Id = _ids[0], CategoryId = 2, UserId = "user777COlombo", Baslik = "Kırtasiye Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "154 / 5000 AppDbContext türünde bir nesne oluşturulamıyor.Tasarım zamanında desteklenen farklı desenler için bkz. https://go.microsoft.com/fwlink/?linkid=851728" },
                new Blog { Id = _ids[0], CategoryId = 3, UserId = "user777COlombo", Baslik = "Bigisayar Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "makale içeriği" },
                new Blog { Id = _ids[0], CategoryId = 4, UserId = "user777COlombo", Baslik = "Notebook Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "mock makale mock mock" },
                new Blog { Id = _ids[0], CategoryId = 4, UserId = "user777COlombo", Baslik = "Laptop Makale Başlığımız burda yer alacak", Ozet = "Makale özetimiz. Kısaca özet diyebiliriz.", Text = "mock makale mock mock" }
            );
        }
    }
}