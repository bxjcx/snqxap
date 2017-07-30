using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snqxap
{

    class Equip
    {
        public string name { get; set; }
  /*      public double critup { get; set; }
        public int breakarmor { get; set; }
        public int damage { get; set; }
        public int shotspeed { get; set; }
        public int hit { get; set; }
        public double nightsee { get; set; }
        public int dodge { get; set; }*/
        public int rank { get; set; }
   //     public int belt { get; set; }
        public string forwhat {get;set;}
        /// <summary>
        /// 1光瞄/2全息/3acog/4夜视/5穿甲/6空尖/7猎鹿or独头/8高速/9芯片/10外骨/11插板/12勋章/13消音器/14弹药箱
        /// </summary>
        public int type { get; set; }

        public string tooltip { get; set; }

        public string property1 { get; set; }
        public string property2 { get; set; }
        public string property3 { get; set; }
        public string property4 { get; set; }
        public double down1 { get; set; }
        public double down2 { get; set; }   
        public double down3 { get; set; }
        public double down4 { get; set; }
        public double up1 { get; set; }
        public double up2 { get; set; }
        public double up3 { get; set; }
        public double up4 { get; set; }

        public double bonus1 { get; set; } //强化系数
        public double bonus2 { get; set; } //强化系数
        public double bonus3 { get; set; } //强化系数
        public double bonus4 { get; set; } //强化系数
    }

    class Gun
    {
        public string image { get; set; }
        public int number { get; set; }
        public int effect0 { get; set; }
        public int effect1 { get; set; }
        public int effect2 { get; set; }
        public int effect3 { get; set; }
        public int effect4 { get; set; }
        public int effect5 { get; set; }
        public int effect6 { get; set; }
        public int effect7 { get; set; }
        public double damageup { get; set; }
        public double shotspeedup { get; set; }
        public double hitup { get; set; }
        public double dodgeup { get; set; }
        public double critup { get; set; }
        public double rateup { get; set; }
        public double armorup { get; set; }
        public int to { get; set; } // all 1 ar 2 smg 3 4 hg 6 mg 7 sg no 0 
        public string name { get; set; } //名字
        public double crit { get; set; }//暴击率
        public string equiptype1 { get; set; }//一栏装备类型
        public string equiptype2 { get; set; }//二栏装备类型
        public string equiptype3 { get; set; }//三栏装备类型
        public int grid_center { get; set; }//光环中心
        /// <summary>
        /// 2 ar 3 smg 4 hg 5 rf 6 mg 7 sg   
        /// </summary>
        public int what { get; set; }   
        public int belt { get; set; }//弹链
        public double cd { get; set; }//冷却
        public string startcd { get; set; }//初始cd
        public double ratiohp { get; set; }//hp
        public double ratiopow { get; set; }//伤害
        public double ratiohit { get; set; } //命中
        public double eatratio { get; set; }
        public double ratiorate { get; set; } //射速
        public double ratiododge { get; set; }//闪避
        public double ratioarmor { get; set; }//护甲

        //public int skillpool { get; set; }


        //public int probability {get;set;}
        //public double skilleffect1 { get; set; }
        //public double skilleffect2 { get; set; }
        //public double skilleffect3 { get; set; }
        //public double skilleffect4 { get; set; }
        //public double growth { get; set; }
        //public int growth_type { get;set;}
        public int type { get; set; } 
        //public Equip equip { get; set; }

    }

    public class GunGrid
    {
        public double damageup { get; set; }
        public double shotspeedup { get; set; }
        public double hitup { get; set; }
        public double dodgeup { get; set; }
        public double critup { get; set; }
        public double rateup { get; set; }
        public double armorup { get; set; }
        public void cleargg()
        {
            this.critup = 1.00;
            this.damageup = 1.00;
            this.dodgeup = 1.00;
            this.hitup = 1.00;
            this.shotspeedup = 1.00;
            this.rateup = 1.00;
            this.armorup = 1.00;
        }
    }

}
