using Core.Models;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repositories
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(AppDbContext context) : base(context)
        {
        }
    }
}
