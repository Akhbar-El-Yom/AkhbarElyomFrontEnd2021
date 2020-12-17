using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services.EFQueries
{
    public class Section
    {
        private readonly AppDbContext _db;
        public Section(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        public MainSection GetSectionItem(int SectionID) => _db.MainSections
                .Include(e => e.News.OrderByDescending(e => e.AddedDate)) // 
                    .ThenInclude(e => e.Picture1)
                .Where(e => e.SectionId == SectionID).Single();

        public List<News> GetSectionItem2(int SectionID) => _db.News
                .Include(e => e.Section) // 
                .Include(e => e.Picture1)
                .Where(e => e.SectionId == SectionID).Take(15).ToList();
    }
}
