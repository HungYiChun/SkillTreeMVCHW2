using SkillTreeMVCHW2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SkillTreeMVCHW2.Services.Home
{
    public class HomeService
    {
        Random random = new Random();
        private readonly Model1 db = new Model1();

        // 記帳資料表
        public IEnumerable<Money> moneyList(int Count = 100)
        {
            IEnumerable<Money> moneyList = db.AccountBook.OrderByDescending(x => x.Dateee).Take(Count).Select(x => new Money()
            {
                category = (x.Categoryyy == 0) ? 1 : 2,
                date = x.Dateee,
                money = x.Amounttt,
                PS = x.Remarkkk
            });               
            
            return moneyList;
        }

        // 新增記帳資料
        public string createMoney(Money money)
        {
            AccountBook accountBook = new AccountBook
            {
                Id = Guid.NewGuid(),
                Categoryyy = (money.category == 1) ? 0 : 1,
                Amounttt = Convert.ToInt32(money.money),               
                Dateee = money.date,
                Remarkkk = money.PS
            };
                
            db.AccountBook.Add(accountBook);

            return "記帳成功";
        }

        // Save DB
        public void _SaveDB()
        {
            db.SaveChanges();
        }

        // 亂數產生記帳資料
        private Money RandomMoney()
        {
            Money item = new Money()
            {
                category = random.Next(1, 3),
                date = DateTime.Today.AddDays(-random.Next(365)),
                money = random.Next(1, 1000) * 100,
                PS = ""
            };

            return item;
        }
    }
}