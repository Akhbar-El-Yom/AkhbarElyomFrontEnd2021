using Microsoft.EntityFrameworkCore;
using MVC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services.EFQueries
{
    public class Layout
    {
        private readonly AppDbContext _db;
        public Layout(AppDbContext dbContext)
        {
            _db = dbContext;
        }
        private List<int> GetChildrens (int ParentId) => _db.MainSections.Where(e=> e.ParentSectionId == ParentId).Select(S => S.SectionId).ToList();

        public List<MainSection> sections => _db.MainSections.Where(P => P.ParentSectionId == 0 && P.Hide == 0)
            .Include(e => e.ParentSection)
                .ThenInclude(ss => ss.SubSections.Where(SS => !SS.DisplayOrder.HasValue)).OrderBy(e => e.DisplayOrder)
            .ToList();

        //public List<MainSection> sections => _db.Set<MainSection>().Where(e => e.Hide == 0).ToList().Select(C =>
        //{
        //    _db.Entry(C)
        //    .Collection(p => p.SubSections)
        //    .Query()
        //    .Where(S => S.SectionId == 196)
        //    .Load();

        //    return C;
        //}).ToList();


        public List<NewsTicker> NewsTickers => _db.NewsTickers.Include(ms => ms.Section).Where(e => e.SectionId > 0 ).OrderByDescending(e => e.AddedDate).Take(10).ToList();

        //public List<NewsTicker> NewsTickers => _db.NewsTickers.Include(ms => ms.Section).Where(e => e.SectionId > 0 ).OrderByDescending(e => e.AddedDate).Take(10).ToList();

    }
}
