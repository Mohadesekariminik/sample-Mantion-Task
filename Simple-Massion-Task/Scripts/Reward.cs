using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_03.Script
{
    public class Reward
    {

        private int gold;
        private List<string> skins;
        private int xp;

        public Reward(int gold, int xp, List<string> skins)
        {
            this.gold = gold;
            this.xp = xp;
            this.skins = skins;
        }




        public int GetGold()
        {
            return gold;
        }


        public string GetSkin()
        {
            return skins.ToString();
        }








    }
}
