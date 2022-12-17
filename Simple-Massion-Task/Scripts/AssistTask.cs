using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_03.Script
{
    public class AssistTask : MassionTask
    {

        public AssistTask()
        {
            var list = new List<string>();
            list.Add("skin_1");
            list.Add("skin_2");
            list.Add("SKin_3");
            reward = new Reward(20, 50, list);
        }

        




    }
}
