using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services.EFQueries
{
    public class NewsDetails
    {
        private readonly AppDbContext _db;
        public NewsDetails(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public News GetNewsItem(int NewsId) => _db.News.Include(e => e.Section).Include(e => e.Picture1).Where(e => e.NewId == NewsId).Single();

    }
}
