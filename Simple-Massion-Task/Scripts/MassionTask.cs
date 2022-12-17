using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace project_03.Script
{
    public class MassionTask
    {

        protected Reward reward;

        public int DailyTaskAmount { get; set; }
        public int WeeklyTaskAMount { get; set; }
        public int SeasonalTaskAmount { get; set; }
        public int Daily(int dailyAmount)
        {
            if (dailyAmount >= 5)
            {
                reward.GetGold();
            }
            return 0;
        }

        public int GetGold()
        {
            return reward.GetGold();
        }






















    }
}



















