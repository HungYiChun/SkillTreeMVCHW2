﻿using SkillTreeMVCHW2.Services.Home;
using System.Web.Mvc;

namespace SkillTreeMVCHW2.Controllers
{
    public class HomeController : Controller
    {
        // Home Service
        HomeService homeService = new HomeService();

        // GET，Home，我的記帳本
        public ActionResult Index()
        {
            return View();
        }

        // GET，[ChildActionOnly] Home/MoneyList，記帳資料
        [ChildActionOnly]
        public ActionResult MoneyList()
        {
            return View(homeService.moneyList());
        }

        // GET，Home/About，關於
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        // GET，Home/Contact，聯絡
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}