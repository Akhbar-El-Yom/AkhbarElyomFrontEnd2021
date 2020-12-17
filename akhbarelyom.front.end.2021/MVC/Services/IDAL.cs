using MVC.Data;
using MVC.Services.EFQueries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Services
{
    public interface IDAL
    {
        Home GetHome();
        Layout GetLayout();
        NewsDetails GetNews();

        Section GetNewsSection();
    }
}
