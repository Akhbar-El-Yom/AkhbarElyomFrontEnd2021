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

        public List<MainSection> sections => _db.MainSections.Include(ms => ms.SubSections).ToList();

    }
}
