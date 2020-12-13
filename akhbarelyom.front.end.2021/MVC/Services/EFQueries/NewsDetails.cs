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
    }
}
