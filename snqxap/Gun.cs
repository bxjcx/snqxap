using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snqxap
{


    class Gun
    {

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
        public int to { get; set; } // all 1 ar 2 smg 3 no 0 

        public string name { get; set; } //名字
        public double hit { get; set; }//命中
        public double shotspeed { get; set; }//射速
        public double damage { get; set; }//伤害
        public double crit { get; set; }//暴击率
        public int hp { get; set; }//血量
        public double dodge { get; set; }//闪避
    //    public Aura aura { get; set; }//光环
        public int what { get; set; }// 2 ar 3 smg 4 hg 5 rf 6 mg
        public int belt { get; set; }//弹链
        public double index { get; set; }//伤害指数

    //    public void traverse() { }
       
   /*     public Gun(string name,int hit,int shotspeed,int damage,int hp,int dodge,Aura aura,string what,int belt)
        {
            this.name = name;
            this.hit = hit;
            this.shotspeed = shotspeed;
            this.damage = damage;
            this.hp = hp;
            this.dodge = dodge;
            this.aura.critup = aura.critup;
            this.aura.damageup = aura.damageup;
            this.aura.shotspeedup = aura.shotspeedup;
            this.aura.dodgeup = aura.dodgeup;
            this.aura.hitup = aura.hitup;
            this.aura.number = aura.number;
            this.aura.effect = null;
            this.what = what;
            this.belt = belt;
        }*/
    }



    class Skill
    {
        public float skillrate { get; set; }//技能发动率
        public int skillfor { get; set; }//0 敌人 1 自身 2 全队
        public bool dayornight { get; set; }//0 day 1 night
    }




    class GunGrid
    {
        public double damageup { get; set; }
        public double shotspeedup { get; set; }
        public double hitup { get; set; }
        public double dodgeup { get; set; }
        public double critup { get; set; }

        public void cleargg()
        {
            this.critup = 1.00;
            this.damageup = 1.00;
            this.dodgeup = 1.00;
            this.hitup = 1.00;
            this.shotspeedup = 1.00;
        }
    }

}
