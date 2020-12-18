using Microsoft.AspNetCore.Mvc;
using MVC.Data;
using MVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class NewsController : Controller
    {
        private readonly IDAL _dal;
        public NewsController(IDAL dal)
        {
            _dal = dal;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult newdetails(int Id)
        {
            News a;
            try
            {
                a = _dal.GetNews().GetNewsItem(Id);
            }
            catch (Exception)
            {
                return RedirectToAction("error404");
            }
            //3191945
            return View(a);
        }

        public IActionResult newssection(int Id)
        {
            List<News> a;
            MainSection b;
            try
            {
                b = _dal.GetNewsSection().GetSectionItem(Id);
                a = _dal.GetNewsSection().GetSectionItem2(Id);
            }
            catch (Exception e)
            {
                string es = e.Message;
                return RedirectToAction("error404");
            }
            return View(b.News.ToList());
        }
        public IActionResult error404()
        {
            return View();
        }

     }
}
