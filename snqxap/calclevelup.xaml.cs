﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace snqxap
{

    public class map
    {
        public string name;
        public int exp;
        public int downlevel;
    }


    /// <summary>
    /// calclevelup.xaml 的交互逻辑
    /// </summary>
    public partial class calclevelup : Window
    {
        public const int MAX_LEVEL = 100; 
        public const int MAP_NUMBER = 118; 
        int[] leveldata = new int[MAX_LEVEL-1];
        map[] allmap = new map[MAP_NUMBER];


        public calclevelup()
        {
            InitializeComponent();
            baka();
        }

        private void baka()
        {
            leveldata[0] = 100;
            leveldata[1] = 200;
            leveldata[2] = 300;
            leveldata[3] = 400;
            leveldata[4] = 500;
            leveldata[5] = 600;
            leveldata[6] = 700;
            leveldata[7] = 800;
            leveldata[8] = 900;
            leveldata[9] = 1000;
            leveldata[10] = 1100;
            leveldata[11] = 1200;
            leveldata[12] = 1300;
            leveldata[13] = 1400;
            leveldata[14] = 1500;
            leveldata[15] = 1600;
            leveldata[16] = 1700;
            leveldata[17] = 1800;
            leveldata[18] = 1900;
            leveldata[19] = 2000;
            leveldata[20] = 2100;
            leveldata[21] = 2200;
            leveldata[22] = 2300;
            leveldata[23] = 2400;
            leveldata[24] = 2500;
            leveldata[25] = 2600;
            leveldata[26] = 2800;
            leveldata[27] = 3100;
            leveldata[28] = 3400;
            leveldata[29] = 4200;
            leveldata[30] = 4600;
            leveldata[31] = 5000;
            leveldata[32] = 5400;
            leveldata[33] = 5800;
            leveldata[34] = 6300;
            leveldata[35] = 6700;
            leveldata[36] = 7200;
            leveldata[37] = 7700;
            leveldata[38] = 8200;
            leveldata[39] = 8800;
            leveldata[40] = 9300;
            leveldata[41] = 9900;
            leveldata[42] = 10500;
            leveldata[43] = 11100;
            leveldata[44] = 11800;
            leveldata[45] = 12500;
            leveldata[46] = 13100;
            leveldata[47] = 13900;
            leveldata[48] = 14600;
            leveldata[49] = 15400;
            leveldata[50] = 16100;
            leveldata[51] = 16900;
            leveldata[52] = 17800;
            leveldata[53] = 18600;
            leveldata[54] = 19500;
            leveldata[55] = 20400;
            leveldata[56] = 21300;
            leveldata[57] = 22300;
            leveldata[58] = 23300;
            leveldata[59] = 24300;
            leveldata[60] = 25300;
            leveldata[61] = 26300;
            leveldata[62] = 27400;
            leveldata[63] = 28500;
            leveldata[64] = 29600;
            leveldata[65] = 30800;
            leveldata[66] = 32000;
            leveldata[67] = 33200;
            leveldata[68] = 34400;
            leveldata[69] = 45100;
            leveldata[70] = 46800;
            leveldata[71] = 48600;
            leveldata[72] = 50400;
            leveldata[73] = 52200;
            leveldata[74] = 54000;
            leveldata[75] = 55900;
            leveldata[76] = 57900;
            leveldata[77] = 59800;
            leveldata[78] = 61800;
            leveldata[79] = 63900;
            leveldata[80] = 66000;
            leveldata[81] = 68100;
            leveldata[82] = 70300;
            leveldata[83] = 72600;
            leveldata[84] = 74800;
            leveldata[85] = 77100;
            leveldata[86] = 79500;
            leveldata[87] = 81900;
            leveldata[88] = 84300;
            leveldata[89] = 112600;
            leveldata[90] = 116100;
            leveldata[91] = 119500;
            leveldata[92] = 123100;
            leveldata[93] = 126700;
            leveldata[94] = 130400;
            leveldata[95] = 134100;
            leveldata[96] = 137900;
            leveldata[97] = 141800;
            leveldata[98] = 145700;
            for(int i = 0;i<MAP_NUMBER;i++)
                allmap[i] = new map();
            allmap[0].name = "01"; allmap[0].exp = 480; allmap[0].downlevel = 100;
            allmap[1].name = "02"; allmap[1].exp = 490; allmap[1].downlevel = 100;
            allmap[2].name = "03"; allmap[2].exp = 500; allmap[2].downlevel = 100;
            allmap[3].name = "04"; allmap[3].exp = 500; allmap[3].downlevel = 100;
            allmap[4].name = "11"; allmap[4].exp = 150; allmap[4].downlevel = 11;
            allmap[5].name = "12"; allmap[5].exp = 160; allmap[5].downlevel = 15;
            allmap[6].name = "13"; allmap[6].exp = 170; allmap[6].downlevel = 18;
            allmap[7].name = "14"; allmap[7].exp = 180; allmap[7].downlevel = 20;
            allmap[8].name = "15"; allmap[8].exp = 190; allmap[8].downlevel = 22;
            allmap[9].name = "16"; allmap[9].exp = 200; allmap[9].downlevel = 25;
            allmap[10].name = "11e"; allmap[10].exp = 200; allmap[10].downlevel = 22;
            allmap[11].name = "12e"; allmap[11].exp = 210; allmap[11].downlevel = 25;
            allmap[12].name = "13e"; allmap[12].exp = 220; allmap[12].downlevel = 30;
            allmap[13].name = "14e"; allmap[13].exp = 230; allmap[13].downlevel = 35;
            allmap[14].name = "21"; allmap[14].exp = 200; allmap[14].downlevel = 25;
            allmap[15].name = "22"; allmap[15].exp = 210; allmap[15].downlevel = 28;
            allmap[16].name = "23"; allmap[16].exp = 220; allmap[16].downlevel = 30;
            allmap[17].name = "24"; allmap[17].exp = 230; allmap[17].downlevel = 30;
            allmap[18].name = "25"; allmap[18].exp = 240; allmap[18].downlevel = 30;
            allmap[19].name = "26"; allmap[19].exp = 250; allmap[19].downlevel = 35;
            allmap[20].name = "21e"; allmap[20].exp = 250; allmap[20].downlevel = 35;
            allmap[21].name = "22e"; allmap[21].exp = 260; allmap[21].downlevel = 35;
            allmap[22].name = "23e"; allmap[22].exp = 270; allmap[22].downlevel = 40;
            allmap[23].name = "24e"; allmap[23].exp = 280; allmap[23].downlevel = 45;
            allmap[24].name = "31"; allmap[24].exp = 250; allmap[24].downlevel = 40;
            allmap[25].name = "32"; allmap[25].exp = 260; allmap[25].downlevel = 40;
            allmap[26].name = "33"; allmap[26].exp = 270; allmap[26].downlevel = 45;
            allmap[27].name = "34"; allmap[27].exp = 280; allmap[27].downlevel = 48;
            allmap[28].name = "35"; allmap[28].exp = 290; allmap[28].downlevel = 50;
            allmap[29].name = "36"; allmap[29].exp = 300; allmap[29].downlevel = 55;
            allmap[30].name = "31e"; allmap[30].exp = 300; allmap[30].downlevel = 55;
            allmap[31].name = "32e"; allmap[31].exp = 310; allmap[31].downlevel = 58;
            allmap[32].name = "33e"; allmap[32].exp = 320; allmap[32].downlevel = 60;
            allmap[33].name = "34e"; allmap[33].exp = 330; allmap[33].downlevel = 65;
            allmap[34].name = "41"; allmap[34].exp = 300; allmap[34].downlevel = 55;
            allmap[35].name = "42"; allmap[35].exp = 310; allmap[35].downlevel = 60;
            allmap[36].name = "43"; allmap[36].exp = 320; allmap[36].downlevel = 63;
            allmap[37].name = "44"; allmap[37].exp = 330; allmap[37].downlevel = 65;
            allmap[38].name = "45"; allmap[38].exp = 340; allmap[38].downlevel = 68;
            allmap[39].name = "46"; allmap[39].exp = 350; allmap[39].downlevel = 70;
            allmap[40].name = "41e"; allmap[40].exp = 350; allmap[40].downlevel = 70;
            allmap[41].name = "42e"; allmap[41].exp = 360; allmap[41].downlevel = 73;
            allmap[42].name = "43e"; allmap[42].exp = 370; allmap[42].downlevel = 75;
            allmap[43].name = "44e"; allmap[43].exp = 380; allmap[43].downlevel = 80;
            allmap[44].name = "51"; allmap[44].exp = 350; allmap[44].downlevel = 75;
            allmap[45].name = "52"; allmap[45].exp = 360; allmap[45].downlevel = 75;
            allmap[46].name = "53"; allmap[46].exp = 370; allmap[46].downlevel = 78;
            allmap[47].name = "54"; allmap[47].exp = 380; allmap[47].downlevel = 80;
            allmap[48].name = "55"; allmap[48].exp = 390; allmap[48].downlevel = 80;
            allmap[49].name = "56"; allmap[49].exp = 400; allmap[49].downlevel = 85;
            allmap[50].name = "51e"; allmap[50].exp = 400; allmap[50].downlevel = 85;
            allmap[51].name = "52e"; allmap[51].exp = 410; allmap[51].downlevel = 88;
            allmap[52].name = "53e"; allmap[52].exp = 420; allmap[52].downlevel = 90;
            allmap[53].name = "54e"; allmap[53].exp = 430; allmap[53].downlevel = 93;
            allmap[54].name = "11n"; allmap[54].exp = 280; allmap[54].downlevel = 45;
            allmap[55].name = "12n"; allmap[55].exp = 290; allmap[55].downlevel = 50;
            allmap[56].name = "13n"; allmap[56].exp = 300; allmap[56].downlevel = 55;
            allmap[57].name = "14n"; allmap[57].exp = 320; allmap[57].downlevel = 60;
            allmap[58].name = "21n"; allmap[58].exp = 330; allmap[58].downlevel = 65;
            allmap[59].name = "22n"; allmap[59].exp = 350; allmap[59].downlevel = 70;
            allmap[60].name = "23n"; allmap[60].exp = 360; allmap[60].downlevel = 75;
            allmap[61].name = "24n"; allmap[61].exp = 380; allmap[61].downlevel = 80;
            allmap[62].name = "31n"; allmap[62].exp = 400; allmap[62].downlevel = 83;
            allmap[63].name = "32n"; allmap[63].exp = 410; allmap[63].downlevel = 87;
            allmap[64].name = "33n"; allmap[64].exp = 420; allmap[64].downlevel = 91;
            allmap[65].name = "34n"; allmap[65].exp = 450; allmap[65].downlevel = 97;
            allmap[66].name = "41n"; allmap[66].exp = 450; allmap[66].downlevel = 97;
            allmap[67].name = "42n"; allmap[67].exp = 460; allmap[67].downlevel = 99;
            allmap[68].name = "43n"; allmap[68].exp = 470; allmap[68].downlevel = 100;
            allmap[69].name = "44n"; allmap[69].exp = 480; allmap[69].downlevel = 100;
            allmap[70].name = "61"; allmap[70].exp = 400; allmap[70].downlevel = 85;
            allmap[71].name = "62"; allmap[71].exp = 410; allmap[71].downlevel = 87;
            allmap[72].name = "63"; allmap[72].exp = 420; allmap[72].downlevel = 89;
            allmap[73].name = "64"; allmap[73].exp = 430; allmap[73].downlevel = 91;
            allmap[74].name = "65"; allmap[74].exp = 440; allmap[74].downlevel = 93;
            allmap[75].name = "66"; allmap[75].exp = 450; allmap[75].downlevel = 95;
            allmap[76].name = "61e"; allmap[76].exp = 450; allmap[76].downlevel = 95;
            allmap[77].name = "62e"; allmap[77].exp = 450; allmap[77].downlevel = 97;
            allmap[78].name = "63e"; allmap[78].exp = 460; allmap[78].downlevel = 99;
            allmap[79].name = "64e"; allmap[79].exp = 470; allmap[79].downlevel = 100;
            allmap[80].name = "71"; allmap[80].exp = 450; allmap[80].downlevel = 95;
            allmap[81].name = "72"; allmap[81].exp = 450; allmap[81].downlevel = 96;
            allmap[82].name = "73"; allmap[82].exp = 460; allmap[82].downlevel = 97;
            allmap[83].name = "74"; allmap[83].exp = 460; allmap[83].downlevel = 98;
            allmap[84].name = "75"; allmap[84].exp = 470; allmap[84].downlevel = 99;
            allmap[85].name = "76"; allmap[85].exp = 470; allmap[85].downlevel = 100;
            allmap[86].name = "71e"; allmap[86].exp = 470; allmap[86].downlevel = 97;
            allmap[87].name = "72e"; allmap[87].exp = 470; allmap[87].downlevel = 98;
            allmap[88].name = "73e"; allmap[88].exp = 480; allmap[88].downlevel = 100;
            allmap[89].name = "74e"; allmap[89].exp = 480; allmap[89].downlevel = 100;
            allmap[90].name = "51n"; allmap[90].exp = 480; allmap[90].downlevel = 100;
            allmap[91].name = "52n"; allmap[91].exp = 480; allmap[91].downlevel = 100;
            allmap[92].name = "53n"; allmap[92].exp = 490; allmap[92].downlevel = 100;
            allmap[93].name = "54n"; allmap[93].exp = 490; allmap[93].downlevel = 100;
            allmap[94].name = "81"; allmap[94].exp = 470; allmap[94].downlevel = 100;
            allmap[95].name = "82"; allmap[95].exp = 470; allmap[95].downlevel = 100;
            allmap[96].name = "83"; allmap[96].exp = 470; allmap[96].downlevel = 100;
            allmap[97].name = "84"; allmap[97].exp = 480; allmap[97].downlevel = 100;
            allmap[98].name = "85"; allmap[98].exp = 480; allmap[98].downlevel = 100;
            allmap[99].name = "86"; allmap[99].exp = 480; allmap[99].downlevel = 100;
            allmap[100].name = "81e"; allmap[100].exp = 480; allmap[100].downlevel = 100;
            allmap[101].name = "82e"; allmap[101].exp = 480; allmap[101].downlevel = 100;
            allmap[102].name = "83e"; allmap[102].exp = 490; allmap[102].downlevel = 100;
            allmap[103].name = "84e"; allmap[103].exp = 490; allmap[103].downlevel = 100;
            allmap[104].name = "61n"; allmap[104].exp = 490; allmap[104].downlevel = 100;
            allmap[105].name = "62n"; allmap[105].exp = 490; allmap[105].downlevel = 100;
            allmap[106].name = "63n"; allmap[106].exp = 500; allmap[106].downlevel = 100;
            allmap[107].name = "64n"; allmap[107].exp = 500; allmap[107].downlevel = 100;
            allmap[108].name = "91"; allmap[108].exp = 480; allmap[108].downlevel = 100;
            allmap[109].name = "92"; allmap[109].exp = 480; allmap[109].downlevel = 100;
            allmap[110].name = "93"; allmap[110].exp = 480; allmap[110].downlevel = 100;
            allmap[111].name = "94"; allmap[111].exp = 490; allmap[111].downlevel = 100;
            allmap[112].name = "95"; allmap[112].exp = 490; allmap[112].downlevel = 100;
            allmap[113].name = "96"; allmap[113].exp = 490; allmap[113].downlevel = 100;
            allmap[114].name = "91e"; allmap[114].exp = 490; allmap[114].downlevel = 100;
            allmap[115].name = "92e"; allmap[115].exp = 490; allmap[115].downlevel = 100;
            allmap[116].name = "93e"; allmap[116].exp = 500; allmap[116].downlevel = 100;
            allmap[117].name = "94e"; allmap[117].exp = 500; allmap[117].downlevel = 100;
            for (int i = 0; i < MAP_NUMBER; i++)
            {
                mapcb.Items.Add(allmap[i].name);
                mapcbl.Items.Add(allmap[i].name);
            }
        }

        /// <summary>
        /// 判断string是否为数字
        /// </summary>
        /// <param name="strNumber">string</param>
        /// <returns></returns>
        public bool IsNumber(String strNumber)
        {
            Regex objNotNumberPattern = new Regex("[^0-9.-]");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            Regex objTwoMinusPattern = new Regex("[0-9]*[-][0-9]*[-][0-9]*");
            String strValidRealPattern = "^([.]|[0-9])[0-9]*[.]*[0-9]+$";
            String strValidIntegerPattern = "^([0-9])[0-9]*$";
            Regex objNumberPattern = new Regex("(" + strValidRealPattern + ")|(" + strValidIntegerPattern + ")");
            return !objNotNumberPattern.IsMatch(strNumber) &&
                   !objTwoDotPattern.IsMatch(strNumber) &&
                   !objTwoMinusPattern.IsMatch(strNumber) &&
                   objNumberPattern.IsMatch(strNumber);
        }

        private void nowleveltb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nowleveltb.Text == "")
                return;
            if (IsNumber(nowleveltb.Text))
            {
                int nowlevel = int.Parse(nowleveltb.Text);
                if (nowlevel >= 100)
                    nowleveltb.Text = "99";
                else if (nowlevel < 1)
                    nowleveltb.Text = "1";
                nowdatatb.Text = "0";
            }
            else
                nowleveltb.Text = "0";
        }

        private void nowdatatb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nowdatatb.Text == "")
                return;
            if (IsNumber(nowdatatb.Text))
            {
                int nowdata = int.Parse(nowdatatb.Text);
                if (IsNumber(nowleveltb.Text))
                {
                    int nowlevel = int.Parse(nowleveltb.Text);
                    if (nowlevel < 0)
                        nowdatatb.Text = "0";
                    else if (nowdata >= leveldata[nowlevel - 1])
                        nowdatatb.Text = (leveldata[nowlevel - 1] - 1).ToString();
                }
                else
                    nowdatatb.Text = "0";
            }
            else
                nowdatatb.Text = "0";
        }

        private void toleveltb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (toleveltb.Text == "")
                return;
            if (IsNumber(toleveltb.Text))
            {
                int tolevel = int.Parse(toleveltb.Text);
                if (tolevel <= 0)
                    toleveltb.Text = "1";
                else if(tolevel > 100)
                    toleveltb.Text = "100";
            }
            else
                toleveltb.Text = "1";
        }

        private double switchteam(int nowlevel)
        {
            if (nowlevel < 10)
                return 1;
            else if (nowlevel < 30)
                return 1.5;
            else if (nowlevel < 70)
                return 2;
            else if (nowlevel < 90)
                return 2.5;
            else
                return 3;
        }

        private double switchdownlevel(int nowlevel,int downlevel)
        {
            if (nowlevel < downlevel)
                return 1;
            else if (nowlevel < downlevel + 10)
                return 0.8;
            else if (nowlevel < downlevel + 20)
                return 0.6;
            else if (nowlevel < downlevel + 30)
                return 0.4;
            else if (nowlevel < downlevel + 40)
                return 0.2;
            else if (nowlevel < downlevel + 50)
                return 0;
            else
                return -1;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int mapselect = mapcb.SelectedIndex;
            if (nowleveltb.Text == ""|| toleveltb.Text==""||nowdatatb.Text==""||mapselect==-1)
                return;
            int nowlevel = int.Parse(nowleveltb.Text);
            int tolevel = int.Parse(toleveltb.Text);
            int nowexp = int.Parse(nowdatatb.Text);

            int expbook = nowexp;
            for (int i = nowlevel; i < tolevel; i++)
            {
                expbook += leveldata[i - 1];
            }
            double book = double.Parse(expbook.ToString()) / 3000;

            int allcountpt = 0;
            int allcountdz = 0;
            int allcountmvp = 0;
            int allcountdzmvp = 0;
            double team = 1;
            double shengganri = 1;
            int exp = 0;
            double downlevel = 1;
            if (checkBox.IsChecked == true)
                shengganri = 1.5;

            for(int i = nowlevel; i < tolevel; i++)
            {
                team = switchteam(i);
                downlevel = switchdownlevel(i, allmap[mapselect].downlevel);
                    exp = leveldata[i - 1] - nowexp;
                if (exp < 0)
                {
                    exp += leveldata[i - 1];
                    nowexp -= leveldata[i - 1];
                    continue;
                }
                if (downlevel > 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / downlevel / allmap[mapselect].exp / shengganri / team);
                    nowexp = (int)(nowcount * allmap[mapselect].exp * shengganri * downlevel * team) - exp;
                    allcountpt += nowcount;
                }
                else if(downlevel == 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 5 / shengganri / team);
                    nowexp = (int)(nowcount  * shengganri * 5 * team) - exp;
                    allcountpt += nowcount;
                }
                else if (downlevel < 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 3 / shengganri / team);
                    nowexp = (int)(nowcount * shengganri * 3 * team) - exp;
                    allcountpt += nowcount;
                }
            }

            nowexp = int.Parse(nowdatatb.Text);

            for (int i = nowlevel; i < tolevel; i++)
            {
                team = switchteam(i);
                downlevel = switchdownlevel(i, allmap[mapselect].downlevel);
                exp = leveldata[i - 1] - nowexp;
                if (exp < 0)
                {
                    exp += leveldata[i - 1];
                    nowexp -= leveldata[i - 1];
                    continue;
                }
                if (downlevel > 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / downlevel / allmap[mapselect].exp / shengganri / team / 1.2);
                    nowexp = (int)(nowcount * allmap[mapselect].exp * shengganri * downlevel * 1.2 * team) - exp;
                    allcountdz += nowcount;
                }
                else if (downlevel == 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 5 / shengganri / team / 1.2);
                    nowexp = (int)(nowcount * shengganri * 5 * 1.2 * team) - exp;
                    allcountdz += nowcount;
                }
                else if (downlevel < 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 3 / shengganri / team / 1.2);
                    nowexp = (int)(nowcount * shengganri * 3 * 1.2 * team) - exp;
                    allcountdz += nowcount;
                }
            }

            nowexp = int.Parse(nowdatatb.Text);
            for (int i = nowlevel; i < tolevel; i++)
            {
                team = switchteam(i);
                downlevel = switchdownlevel(i, allmap[mapselect].downlevel);
                exp = leveldata[i - 1] - nowexp;
                if (exp < 0)
                {
                    exp += leveldata[i - 1];
                    nowexp -= leveldata[i - 1];
                    continue;
                }
                if (downlevel > 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / downlevel / allmap[mapselect].exp / shengganri / team / 1.3);
                    nowexp = (int)(nowcount * allmap[mapselect].exp * shengganri * downlevel * 1.3 * team) - exp;
                    allcountmvp += nowcount;
                }
                else if (downlevel == 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 5 / shengganri / team / 1.3);
                    nowexp = (int)(nowcount * shengganri * 5 * 1.3 * team) - exp;
                    allcountmvp += nowcount;
                }
                else if (downlevel < 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 3 / shengganri / team / 1.3);
                    nowexp = (int)(nowcount * shengganri * 3 * 1.3 * team) - exp;
                    allcountmvp += nowcount;
                }
            }

            nowexp = int.Parse(nowdatatb.Text);

            for (int i = nowlevel; i < tolevel; i++)
            {
                team = switchteam(i);
                downlevel = switchdownlevel(i, allmap[mapselect].downlevel);
                exp = leveldata[i - 1] - nowexp;
                if (exp < 0)
                {
                    exp += leveldata[i - 1];
                    nowexp -= leveldata[i - 1];
                    continue;
                }
                if (downlevel > 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / downlevel / allmap[mapselect].exp / shengganri / team / 1.2 / 1.3);
                    nowexp = (int)(nowcount * allmap[mapselect].exp * shengganri * downlevel * 1.2 * 1.3 * team) - exp;
                    allcountdzmvp += nowcount;
                }
                else if (downlevel == 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 5 / shengganri / team / 1.2 / 1.3);
                    nowexp = (int)(nowcount * shengganri * 5 * 1.2 * 1.3 * team) - exp;
                    allcountdzmvp += nowcount;
                }
                else if (downlevel < 0)
                {
                    int nowcount = (int)Math.Ceiling((double)exp / 3 / shengganri / team / 1.2 / 1.3);
                    nowexp = (int)(nowcount * shengganri * 3 * 1.2 * 1.3 * team) - exp;
                    allcountdzmvp += nowcount;
                }
            }

            calclbpt.Content = allcountpt.ToString() + "次";
                    calclbdz.Content = allcountdz.ToString() + "次";
                    calclbmvp.Content = allcountmvp.ToString() + "次";
                    calclbdzmvp.Content = allcountdzmvp.ToString() + "次";
            calclbbook.Content = book.ToString() + "本";
        }

        private void nowlovetb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (nowlovetb.Text == "")
                return;
            if (IsNumber(nowlovetb.Text))
            {
                int nowlove = int.Parse(nowlovetb.Text);
                if (nowlove >= 150)
                    nowlovetb.Text = "149";
                else if (nowlove < 0)
                    nowlovetb.Text = "0";
            }
            else
                nowlovetb.Text = "0";
        }

        private void tolovetb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tolovetb.Text == "")
                return;
            if (IsNumber(tolovetb.Text))
            {
                int tolove = int.Parse(tolovetb.Text);
                if (tolove <= 0)
                    tolovetb.Text = "1";
                else if (tolove > 150)
                    tolovetb.Text = "150";
            }
            else
                tolovetb.Text = "1";
        }

        private void buttonl_Click(object sender, RoutedEventArgs e)
        {
            int mapselect = mapcbl.SelectedIndex;
            if (nowlovetb.Text == "" || tolovetb.Text == "" || mapselect == -1)
                return;
            int nowlove = int.Parse(nowlovetb.Text);
            int tolove = int.Parse(tolovetb.Text);

            int allcountpt = 0;
            int allcountdz = 0;
            int allcountdzmvp = 0;
            double boss = 1;
            int dal = 1;
            int full = 1;
            if(checkBox2.IsChecked == true)
                boss = 2;
            if (checkBox3.IsChecked == true)
                full = 3;
            if (checkBox4.IsChecked == true)
                dal = 3;

            if (nowlove<50&&tolove<=50)
            {
                int allloveexp = (tolove - nowlove) * 10000;
                allcountpt += (int)Math.Ceiling(allloveexp / boss  / dal / allmap[mapselect].exp / full / 1);
                allcountdz += (int)Math.Ceiling(allloveexp / boss  / dal / allmap[mapselect].exp / full / 1);
                allcountdzmvp += (int)Math.Ceiling(allloveexp / boss  / dal / allmap[mapselect].exp / full / 1.7);
            }
            else if(nowlove < 50 && tolove > 50)
            {
                int oneloveexp = (50 - nowlove) * 10000;
                allcountpt += (int)Math.Ceiling(oneloveexp / boss  / dal / allmap[mapselect].exp / full / 1);
                allcountdz += (int)Math.Ceiling(oneloveexp / boss  / dal / allmap[mapselect].exp / full / 1);
                allcountdzmvp += (int)Math.Ceiling(oneloveexp / boss  / dal / allmap[mapselect].exp / full / 1.7);
                int nextexppt = int.Parse((allcountpt * boss * dal * allmap[mapselect].exp * full * 1 - oneloveexp).ToString());
                int twoloveexppt = (tolove - 50) * 10000 - nextexppt;
                int nextexpdz = int.Parse((allcountpt * boss * dal * allmap[mapselect].exp * full * 1 - oneloveexp).ToString());
                int twoloveexpdz = (tolove - 50) * 10000 - nextexpdz;
                int nextexpdzmvp = int.Parse((allcountpt * boss * dal * allmap[mapselect].exp * full * 1.7 - oneloveexp).ToString());
                int twoloveexpdzmvp = (tolove - 50) * 10000 - nextexpdzmvp;
                allcountpt += (int)Math.Ceiling(twoloveexppt / boss  / dal / allmap[mapselect].exp / full / 0.3);
                allcountdz += (int)Math.Ceiling(twoloveexpdz / boss  / dal / allmap[mapselect].exp / full / 1);
                allcountdzmvp += (int)Math.Ceiling(twoloveexpdzmvp / boss  / dal / allmap[mapselect].exp / full / 1.7);
            }
            else
            {
                int allloveexp = (tolove - nowlove) * 10000;
                allcountpt += (int)Math.Ceiling(allloveexp / boss  / dal / allmap[mapselect].exp / full / 0.3);
                allcountdz += (int)Math.Ceiling(allloveexp / boss  / dal / allmap[mapselect].exp / full / 1);
                allcountdzmvp += (int)Math.Ceiling(allloveexp / boss  / dal / allmap[mapselect].exp / full / 1.7);
            }
            calclbptl.Content = allcountpt.ToString() + "次";
            calclbdzl.Content = allcountdz.ToString() + "次";
            calclbdzmvpl.Content = allcountdzmvp.ToString() + "次";
        }
    }
}
