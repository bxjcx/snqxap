using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snqxap
{


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
        public int to { get; set; } // all 1 ar 2 smg 3 no 0 
        public string name { get; set; } //名字
        public double hit { get; set; }//命中
        public double shotspeed { get; set; }//射速
        public double damage { get; set; }//伤害
        public double crit { get; set; }//暴击率
        public int hp { get; set; }//血量
        public double dodge { get; set; }//闪避
        public int what { get; set; }// 2 ar 3 smg 4 hg 5 rf 6 mg       
        public int belt { get; set; }//弹链
        public double index { get; set; }//伤害指数

        public int skilltype { get; set; }//   skilltype : 0 无 1 爆破榴弹/杀伤榴弹/瞄准/定点/阻断 2 downspeed 3 downonedamage 4 upalldamage 5 downalldamage 6 upmydamage 7downonehit 8downallhit 9upmyhit 10 力场盾 11闪光弹 12燃烧弹  15手榴弹 16 downoneshotspeed 17 downallshotspeed  18 upmyshotspeed 19 烟雾弹 20 downonedodge 21 upalldodge 22 downalldodge 23 upmydodge 24 upallhit 26 upallshotspeed
        public double skillcircle { get; set; }// 技能半径
        public double skilltime { get; set; }//持续时间
        public double skillrate { get; set; }//发动率
        public double skilldamage { get; set; }//固伤
        public string skillcontent { get; set; }//说明（十二个字）

        public double skillupmydodge { get; set;}
        public double skillupmyshotspeed { get; set; }
        public double skillupmydamage { get; set; }
        public double skillupmyhit { get; set; }
        public double skilldownonedodge { get; set; }
        public double skilldownonedamage { get; set; }
        public double skilldownoneshotspeed { get; set; }
        public double skilldownonehit { get; set; }
        public double skilldownallenemydamage { get; set; }
        public double skilldownallenemyhit { get; set; }
        public double skilldownallenemydodge { get; set; }
        public double skilldownallenemyshotspeed { get; set; }
        public double skillupalldamage { get; set; }
        public double skillupalldodge { get; set; }
        public double skillupallhit { get; set; }
        public double skillupallshotspeed { get; set; }

        public double ratiohp { get; set; }//hp
        public double ratiopow { get; set; }//伤害
        public double ratiohit { get; set; } //命中
        public double eatratio { get; set; }
        public double ratiorate { get; set; } //射速
        public double ratiododge { get; set; }//闪避

        public int probability {get;set;}
        public double skilleffect1 { get; set; }
        public double skilleffect2 { get; set; }
        public double skilleffect3 { get; set; }
        public double skilleffect4 { get; set; }
        public double growth { get; set; }
        public int growth_type { get;set;}
        public int type { get; set; }
        public string skillname { get; set; }

        

    }

    public class GunGrid
    {
        public double damageup { get; set; }
        public double shotspeedup { get; set; }
        public double hitup { get; set; }
        public double dodgeup { get; set; }
        public double critup { get; set; }
        public double rateup { get; set; }

        public void cleargg()
        {
            this.critup = 1.00;
            this.damageup = 1.00;
            this.dodgeup = 1.00;
            this.hitup = 1.00;
            this.shotspeedup = 1.00;
            this.rateup = 0.00;
        }
    }

}
