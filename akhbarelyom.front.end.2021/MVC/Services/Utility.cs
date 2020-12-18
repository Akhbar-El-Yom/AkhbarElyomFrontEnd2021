using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MVC.Services
{
    public class Utility
    {
        
        // var sql = ((System.Data.Entity.Core.Objects.ObjectQuery)query).ToTraceString();

        public string GetEFQuerySQL(EntityEntry objectQuery)
        {
            return "";
        }
    }
}
