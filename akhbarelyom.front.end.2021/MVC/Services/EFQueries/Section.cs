using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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

        public MainSection GetSectionItem(int SectionID, int Page = 1, int Count = 15, int firstSkip = 0)
        { 
            var Q = _db.MainSections
                .Where(e => e.SectionId == SectionID).Single<MainSection>();

            _db.Entry(Q).Collection(q => q.News).Query().Include(n => n.Picture1)
                .OrderByDescending(N => N.AddedDate).Where(e => e.SectionId == SectionID).Skip(((Page - 1) * Count) + firstSkip).Take(Count).ToList<News>();
            return Q;
        }


        public List<News> GetSectionItem2(int SectionID, int Page = 1, int Count = 15, int firstSkip = 0) => _db.News.AsNoTracking()
                .Include(e => e.Section) // 
                .Include(e => e.Picture1)
                .Where(e => e.SectionId == SectionID)
                .OrderByDescending(e => e.AddedDate)
                .Skip(((Page-1) * Count) + firstSkip).Take(Count).ToList();
    }
}
