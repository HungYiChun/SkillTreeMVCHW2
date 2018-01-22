using System;
using System.ComponentModel.DataAnnotations;

namespace SkillTreeMVCHW2.Models
{
    public class Money
    {
        [Display(Name = "類別")]
        public int category { get; set; }
        public string categoryName
        {
            get
            {
                if (category == 1)
                    return "支出";
                else
                    return "收入";
            }
        }

        [Display(Name = "日期")]
        public DateTime date { get; set; }
        public string date_yyyyMMdd
        {
            get
            {
                return date.ToString("yyyy-MM-dd");
            }
        }

        [Display(Name = "金額")]
        public decimal money { get; set; }
        public string moneyShow
        {
            get
            {
                return money.ToString("#,0");
            }
        }

        [Display(Name = "備註")]
        public string PS { get; set; }
    }
}