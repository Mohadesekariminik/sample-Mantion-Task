using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project_03.Script;
namespace project_03
{
    public class KillTask : MassionTask
    {
        

        public KillTask()
        {
            var list = new List<string>();
            list.Add("SKin_1");
            list.Add("SKin_2");
            list.Add("SKin_3");
            reward = new Reward(100, 200, list);

            DailyTaskAmount = 5;
            WeeklyTaskAMount = 10;


        } 







    }
}
