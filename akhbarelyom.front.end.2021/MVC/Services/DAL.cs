﻿// Data Access Layer Service
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Services.EFQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services
{
    public class DAL:IDAL
    {
        private readonly AppDbContext _db;
        private readonly Home home;
        private readonly Layout layout;
        private readonly NewsDetails news;

        private readonly Services.EFQueries.Section NSection;
        public DAL(AppDbContext dbContext)
        {
            _db = dbContext;
            // _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            home = new Home(_db);
            layout = new Layout(_db);
            news = new NewsDetails(_db);
            NSection = new Section(_db);
        }

        public Home GetHome()
        {
            return home;
        }

        public Layout GetLayout()
        {
            return layout;
        }

        public NewsDetails GetNews()
        {
            return news;
        }

        public Section GetNewsSection()
        {
            return NSection;
        }


    }
}
