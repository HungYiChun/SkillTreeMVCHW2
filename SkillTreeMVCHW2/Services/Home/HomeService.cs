using SkillTreeMVCHW2.Models;
using System;
using System.Collections.Generic;

namespace SkillTreeMVCHW2.Services.Home
{
    public class HomeService
    {
        Random random = new Random();

        // 記帳資料表
        public List<Money> moneyList(int Count = 100)
        {
            List<Money> moneyList = new List<Money>();
            for (int i = 0; i < Count; i++)
            {
                Money item = RandomMoney();
                moneyList.Add(item);
            }
            return moneyList;
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