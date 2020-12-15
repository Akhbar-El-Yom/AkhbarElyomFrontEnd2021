using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services.EFQueries
{
    public class Home
    {
        private readonly AppDbContext _db;
        public Home(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        // Old Name  HomeTopStories
        public List<News> Slider => _db.News.Include(TN => TN.TopNews)   
                                    .Include(NS => NS.Section)
                                    .Include(N => N.Section)
                                    .Include(N => N.Picture1)
                                    .Include(N => N.Picture2)
                                    .Where(TN => TN.TopNews.JournalId == 1 && TN.TopNews.SecId == 0 && TN.TopNews.CatId == 1 && TN.Approved == 1 && TN.NewStatus == 7)
                                    .OrderBy(TN => TN.TopNews.DisplayOrder).Take(10).ToList();

        public List<TopNews> HomeLatestNews => _db.TopNews
                                    .Include(NS => NS.Section)
                                    .Include(e => e.NewsCategory)
                                    .Include(TN => TN.News)
                                        .ThenInclude(N => N.Section)
                                    .Include(TN => TN.News)
                                        .ThenInclude(N => N.Picture1)
                                    //.Include(TN => TN.News)
                                    //    .ThenInclude(N => N.Picture2)
                                    // .Select(TN => new { Title = TN.News.Title, Story = TN.News.Story })
                                    .Where(TN => TN.News.CategoryId == 1 && TN.DisplayOrder <= 5 && TN.Section.SectionId != 157 && TN.News.JournalId == 1 && TN.Section.Hide == 0 && TN.News.SectionId == TN.Section.SectionId)
                                    .OrderByDescending(TN => TN.News.PublishDate)
                                    .ToList();


    }
}
