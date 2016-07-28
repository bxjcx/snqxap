using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace snqxap
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        Gun[] gun = new Gun[101];
        GunGrid[] gg = new GunGrid[9];

        int[] lastgunindex = new int[9];

        public MainWindow()
        {


          
            InitializeComponent();

            baka();
       //     MessageBox.Show(gun[88].effect3.ToString());
            

        }

       public void baka() {



           for (int i = 0; i < 101; i++)
           {gun[i] = new Gun();
               gun[i].index = 0.00;
           }

               gun[0].name = "TOMPSEN"; gun[0].what = 3; gun[0].hp = 238; gun[0].damage = 31; gun[0].hit = 12; gun[0].dodge = 54; gun[0].shotspeed = 81; gun[0].crit = 0.05; gun[0].belt = 0; gun[0].number = 2; gun[0].effect0 = 1; gun[0].effect1 = 7; gun[0].damageup = 0.12; gun[0].hitup = 0; gun[0].shotspeedup = 0; gun[0].critup = 0; gun[0].dodgeup = 0.15; gun[0].to = 2;
          //  MessageBox.Show(gun[0].name);
           gun[1].name = "stengunsMK.II"; gun[1].what = 3; gun[1].hp = 185; gun[1].damage = 26; gun[1].hit = 15; gun[1].dodge = 75; gun[1].shotspeed = 78; gun[1].crit = 0.05; gun[1].belt = 0; gun[1].number = 3; gun[1].effect0 = 1; gun[1].effect1 = 4; gun[1].effect2 = 7; gun[1].damageup = 0; gun[1].hitup = 0.1; gun[1].shotspeedup = 0; gun[1].critup = 0; gun[1].dodgeup = 0.3; gun[1].to = 2;
            gun[2].name = "UMP9"; gun[2].what = 3; gun[2].hp = 176; gun[2].damage = 26; gun[2].hit = 14; gun[2].dodge = 76; gun[2].shotspeed = 87; gun[2].crit = 0.05; gun[2].belt = 0; gun[2].number = 3; gun[2].effect0 = 1; gun[2].effect1 = 4; gun[2].effect2 = 7; gun[2].damageup = 0; gun[2].hitup = 0.3; gun[2].shotspeedup = 0.12; gun[2].critup = 0; gun[2].dodgeup = 0; gun[2].to = 2;
            gun[3].name = "vector"; gun[3].what = 3; gun[3].hp = 185; gun[3].damage = 30; gun[3].hit = 11; gun[3].dodge = 71; gun[3].shotspeed = 101; gun[3].crit = 0.05; gun[3].belt = 0; gun[3].number = 1; gun[3].effect0 = 4; gun[3].damageup = 0; gun[3].hitup = 0; gun[3].shotspeedup = 0.25; gun[3].critup = 0; gun[3].dodgeup = 0; gun[3].to = 2;
            gun[4].name = "Scorpion"; gun[4].what = 3; gun[4].hp = 159; gun[4].damage = 24; gun[4].hit = 13; gun[4].dodge = 83; gun[4].shotspeed = 95; gun[4].crit = 0.05; gun[4].belt = 0; gun[4].number = 1; gun[4].effect0 = 4; gun[4].damageup = 0; gun[4].hitup = 0.5; gun[4].shotspeedup = 0.15; gun[4].critup = 0; gun[4].dodgeup = 0; gun[4].to = 2;
            gun[5].name = "M3"; gun[5].what = 3; gun[5].hp = 185; gun[5].damage = 29; gun[5].hit = 13; gun[5].dodge = 67; gun[5].shotspeed = 68; gun[5].crit = 0.05; gun[5].belt = 0; gun[5].number = 1; gun[5].effect0 = 4; gun[5].damageup = 0; gun[5].hitup = 0.4; gun[5].shotspeedup = 0; gun[5].critup = 0; gun[5].dodgeup = 0.3; gun[5].to = 2;
            gun[6].name = "IDW"; gun[6].what = 3; gun[6].hp = 150; gun[6].damage = 26; gun[6].hit = 15; gun[6].dodge = 85; gun[6].shotspeed = 75; gun[6].crit = 0.05; gun[6].belt = 0; gun[6].number = 3; gun[6].effect0 = 1; gun[6].effect1 = 4; gun[6].effect2 = 7; gun[6].damageup = 0; gun[6].hitup = 0; gun[6].shotspeedup = 0; gun[6].critup = 0; gun[6].dodgeup = 0.2; gun[6].to = 2;
            gun[7].name = "MiniUzi"; gun[7].what = 3; gun[7].hp = 159; gun[7].damage = 24; gun[7].hit = 11; gun[7].dodge = 79; gun[7].shotspeed = 104; gun[7].crit = 0.05; gun[7].belt = 0; gun[7].number = 2; gun[7].effect0 = 2; gun[7].effect1 = 8; gun[7].damageup = 0.18; gun[7].hitup = 0; gun[7].shotspeedup = 0; gun[7].critup = 0; gun[7].dodgeup = 0; gun[7].to = 2;
            gun[8].name = "fmp9"; gun[8].what = 3; gun[8].hp = 141; gun[8].damage = 26; gun[8].hit = 13; gun[8].dodge = 90; gun[8].shotspeed = 92; gun[8].crit = 0.05; gun[8].belt = 0; gun[8].number = 2; gun[8].effect0 = 1; gun[8].effect1 = 7; gun[8].damageup = 0.1; gun[8].hitup = 0; gun[8].shotspeedup = 0; gun[8].critup = 0; gun[8].dodgeup = 0.12; gun[8].to = 2;
            gun[9].name = "mac10"; gun[9].what = 3; gun[9].hp = 176; gun[9].damage = 28; gun[9].hit = 11; gun[9].dodge = 68; gun[9].shotspeed = 91; gun[9].crit = 0.05; gun[9].belt = 0; gun[9].number = 3; gun[9].effect0 = 1; gun[9].effect1 = 4; gun[9].effect2 = 7; gun[9].damageup = 0.12; gun[9].hitup = 0; gun[9].shotspeedup = 0; gun[9].critup = 0; gun[9].dodgeup = 0; gun[9].to = 2;
            gun[10].name = "m45"; gun[10].what = 3; gun[10].hp = 185; gun[10].damage = 30; gun[10].hit = 12; gun[10].dodge = 62; gun[10].shotspeed = 74; gun[10].crit = 0.05; gun[10].belt = 0; gun[10].number = 2; gun[10].effect0 = 1; gun[10].effect1 = 7; gun[10].damageup = 0; gun[10].hitup = 0; gun[10].shotspeedup = 0.1; gun[10].critup = 0; gun[10].dodgeup = 0.1; gun[10].to = 2;
            gun[11].name = "SpectreM4"; gun[11].what = 3; gun[11].hp = 176; gun[11].damage = 25; gun[11].hit = 12; gun[11].dodge = 66; gun[11].shotspeed = 88; gun[11].crit = 0.05; gun[11].belt = 0; gun[11].number = 1; gun[11].effect0 = 4; gun[11].damageup = 0.2; gun[11].hitup = 0; gun[11].shotspeedup = 0; gun[11].critup = 0; gun[11].dodgeup = 0; gun[11].to = 2;
            gun[12].name = "PPS43"; gun[12].what = 3; gun[12].hp = 176; gun[12].damage = 33; gun[12].hit = 13; gun[12].dodge = 65; gun[12].shotspeed = 74; gun[12].crit = 0.05; gun[12].belt = 0; gun[12].number = 3; gun[12].effect0 = 1; gun[12].effect1 = 4; gun[12].effect2 = 7; gun[12].damageup = 0.12; gun[12].hitup = 0; gun[12].shotspeedup = 0; gun[12].critup = 0; gun[12].dodgeup = 0; gun[12].to = 2;
            gun[13].name = "PP2000"; gun[13].what = 3; gun[13].hp = 159; gun[13].damage = 29; gun[13].hit = 11; gun[13].dodge = 74; gun[13].shotspeed = 80; gun[13].crit = 0.05; gun[13].belt = 0; gun[13].number = 2; gun[13].effect0 = 1; gun[13].effect1 = 7; gun[13].damageup = 0.1; gun[13].hitup = 0.25; gun[13].shotspeedup = 0; gun[13].critup = 0; gun[13].dodgeup = 0; gun[13].to = 2;
            gun[14].name = "MP5"; gun[14].what = 3; gun[14].hp = 168; gun[14].damage = 30; gun[14].hit = 13; gun[14].dodge = 68; gun[14].shotspeed = 89; gun[14].crit = 0.05; gun[14].belt = 0; gun[14].number = 2; gun[14].effect0 = 1; gun[14].effect1 = 7; gun[14].damageup = 0; gun[14].hitup = 0; gun[14].shotspeedup = 0; gun[14].critup = 0.2; gun[14].dodgeup = 0.4; gun[14].to = 2;
            gun[15].name = "BERETTA38"; gun[15].what = 3; gun[15].hp = 203; gun[15].damage = 32; gun[15].hit = 10; gun[15].dodge = 52; gun[15].shotspeed = 75; gun[15].crit = 0.05; gun[15].belt = 0; gun[15].number = 2; gun[15].effect0 = 1; gun[15].effect1 = 7; gun[15].damageup = 0.05; gun[15].hitup = 0; gun[15].shotspeedup = 0.1; gun[15].critup = 0; gun[15].dodgeup = 0; gun[15].to = 2;
            gun[16].name = "MP40"; gun[16].what = 3; gun[16].hp = 185; gun[16].damage = 29; gun[16].hit = 13; gun[16].dodge = 58; gun[16].shotspeed = 76; gun[16].crit = 0.05; gun[16].belt = 0; gun[16].number = 2; gun[16].effect0 = 1; gun[16].effect1 = 7; gun[16].damageup = 0; gun[16].hitup = 0.25; gun[16].shotspeedup = 0; gun[16].critup = 0; gun[16].dodgeup = 0.2; gun[16].to = 2;
            gun[17].name = "PPSH41"; gun[17].what = 3; gun[17].hp = 185; gun[17].damage = 26; gun[17].hit = 11; gun[17].dodge = 56; gun[17].shotspeed = 93; gun[17].crit = 0.05; gun[17].belt = 0; gun[17].number = 2; gun[17].effect0 = 2; gun[17].effect1 = 8; gun[17].damageup = 0.1; gun[17].hitup = 0; gun[17].shotspeedup = 0.05; gun[17].critup = 0; gun[17].dodgeup = 0; gun[17].to = 2;
            gun[18].name = "64"; gun[18].what = 3; gun[18].hp = 176; gun[18].damage = 27; gun[18].hit = 11; gun[18].dodge = 59; gun[18].shotspeed = 93; gun[18].crit = 0.05; gun[18].belt = 0; gun[18].number = 1; gun[18].effect0 = 4; gun[18].damageup = 0; gun[18].hitup = 0; gun[18].shotspeedup = 0.2; gun[18].critup = 0; gun[18].dodgeup = 0; gun[18].to = 2;
            gun[19].name = "UMP45"; gun[19].what = 3; gun[19].hp = 185; gun[19].damage = 27; gun[19].hit = 13; gun[19].dodge = 73; gun[19].shotspeed = 82; gun[19].crit = 0.05; gun[19].belt = 0; gun[19].number = 2; gun[19].effect0 = 1; gun[19].effect1 = 7; gun[19].damageup = 0; gun[19].hitup = 0.3; gun[19].shotspeedup = 0.15; gun[19].critup = 0; gun[19].dodgeup = 0; gun[19].to = 2;
            gun[20].name = "KP31"; gun[20].what = 3; gun[20].hp = 220; gun[20].damage = 28; gun[20].hit = 15; gun[20].dodge = 56; gun[20].shotspeed = 92; gun[20].crit = 0.05; gun[20].belt = 0; gun[20].number = 3; gun[20].effect0 = 1; gun[20].effect1 = 4; gun[20].effect2 = 7; gun[20].damageup = 0.15; gun[20].hitup = 0; gun[20].shotspeedup = 0; gun[20].critup = 0.5; gun[20].dodgeup = 0; gun[20].to = 2;
            gun[21].name = "ots12"; gun[21].what = 2; gun[21].hp = 105; gun[21].damage = 42; gun[21].hit = 54; gun[21].dodge = 54; gun[21].shotspeed = 72; gun[21].crit = 0.2; gun[21].belt = 0; gun[21].number = 2; gun[21].effect0 = 3; gun[21].effect1 = 6; gun[21].damageup = 0.15; gun[21].hitup = 0; gun[21].shotspeedup = 0.2; gun[21].critup = 0; gun[21].dodgeup = 0; gun[21].to = 3;
            gun[22].name = "G36"; gun[22].what = 2; gun[22].hp = 127; gun[22].damage = 47; gun[22].hit = 44; gun[22].dodge = 41; gun[22].shotspeed = 72; gun[22].crit = 0.2; gun[22].belt = 0; gun[22].number = 2; gun[22].effect0 = 6; gun[22].effect1 = 9; gun[22].damageup = 0.3; gun[22].hitup = 0; gun[22].shotspeedup = 0.15; gun[22].critup = 0; gun[22].dodgeup = 0; gun[22].to = 3;
            gun[23].name = "FAL"; gun[23].what = 2; gun[23].hp = 132; gun[23].damage = 57; gun[23].hit = 40; gun[23].dodge = 38; gun[23].shotspeed = 70; gun[23].crit = 0.2; gun[23].belt = 0; gun[23].number = 3; gun[23].effect0 = 3; gun[23].effect1 = 6; gun[23].effect2 = 9; gun[23].damageup = 0; gun[23].hitup = 0; gun[23].shotspeedup = 0; gun[23].critup = 0; gun[23].dodgeup = 0.2; gun[23].to = 3;
            gun[24].name = "HK416"; gun[24].what = 2; gun[24].hp = 121; gun[24].damage = 51; gun[24].hit = 46; gun[24].dodge = 43; gun[24].shotspeed = 76; gun[24].crit = 0.2; gun[24].belt = 0; gun[24].number = 1; gun[24].effect0 = 6; gun[24].damageup = 0.4; gun[24].hitup = 0; gun[24].shotspeedup = 0; gun[24].critup = 0; gun[24].dodgeup = 0; gun[24].to = 3;
            gun[25].name = "G41"; gun[25].what = 2; gun[25].hp = 127; gun[25].damage = 50; gun[25].hit = 48; gun[25].dodge = 40; gun[25].shotspeed = 77; gun[25].crit = 0.2; gun[25].belt = 0; gun[25].number = 2; gun[25].effect0 = 3; gun[25].effect1 = 9; gun[25].damageup = 0; gun[25].hitup = 0.5; gun[25].shotspeedup = 0; gun[25].critup = 0; gun[25].dodgeup = 0.15; gun[25].to = 3;
            gun[26].name = "56-1"; gun[26].what = 2; gun[26].hp = 138; gun[26].damage = 52; gun[26].hit = 35; gun[26].dodge = 35; gun[26].shotspeed = 69; gun[26].crit = 0.2; gun[26].belt = 0; gun[26].number = 1; gun[26].effect0 = 6; gun[26].damageup = 0; gun[26].hitup = 0; gun[26].shotspeedup = 0; gun[26].critup = 0.1; gun[26].dodgeup = 0.15; gun[26].to = 3;
            gun[27].name = "m4a1"; gun[27].what = 2; gun[27].hp = 110; gun[27].damage = 46; gun[27].hit = 48; gun[27].dodge = 48; gun[27].shotspeed = 79; gun[27].crit = 0.2; gun[27].belt = 0; gun[27].number = 1; gun[27].effect0 = 1; gun[27].damageup = 0.18; gun[27].hitup = 0; gun[27].shotspeedup = 0; gun[27].critup = 0; gun[27].dodgeup = 0; gun[27].to = 2;
            gun[28].name = "M16A1"; gun[28].what = 2; gun[28].hp = 116; gun[28].damage = 47; gun[28].hit = 46; gun[28].dodge = 44; gun[28].shotspeed = 75; gun[28].crit = 0.2; gun[28].belt = 0; gun[28].number = 1; gun[28].effect0 = 7; gun[28].damageup = 0.18; gun[28].hitup = 0; gun[28].shotspeedup = 0; gun[28].critup = 0; gun[28].dodgeup = 0; gun[28].to = 2;
            gun[29].name = "star15"; gun[29].what = 2; gun[29].hp = 105; gun[29].damage = 48; gun[29].hit = 50; gun[29].dodge = 50; gun[29].shotspeed = 77; gun[29].crit = 0.2; gun[29].belt = 0; gun[29].number = 1; gun[29].effect0 = 3; gun[29].damageup = 0; gun[29].hitup = 0; gun[29].shotspeedup = 0; gun[29].critup = 0; gun[29].dodgeup = 0.36; gun[29].to = 2;
            gun[30].name = "FAMAS"; gun[30].what = 2; gun[30].hp = 121; gun[30].damage = 44; gun[30].hit = 48; gun[30].dodge = 40; gun[30].shotspeed = 81; gun[30].crit = 0.2; gun[30].belt = 0; gun[30].number = 1; gun[30].effect0 = 9; gun[30].damageup = 0.25; gun[30].hitup = 0.6; gun[30].shotspeedup = 0; gun[30].critup = 0; gun[30].dodgeup = 0; gun[30].to = 3;
            gun[31].name = "ak47"; gun[31].what = 2; gun[31].hp = 132; gun[31].damage = 52; gun[31].hit = 35; gun[31].dodge = 34; gun[31].shotspeed = 65; gun[31].crit = 0.2; gun[31].belt = 0; gun[31].number = 1; gun[31].effect0 = 8; gun[31].damageup = 0; gun[31].hitup = 0; gun[31].shotspeedup = 0; gun[31].critup = 0; gun[31].dodgeup = 0.18; gun[31].to = 3;
            gun[32].name = "STG44"; gun[32].what = 2; gun[32].hp = 127; gun[32].damage = 53; gun[32].hit = 46; gun[32].dodge = 36; gun[32].shotspeed = 61; gun[32].crit = 0.2; gun[32].belt = 0; gun[32].number = 1; gun[32].effect0 = 6; gun[32].damageup = 0; gun[32].hitup = 0.6; gun[32].shotspeedup = 0; gun[32].critup = 0; gun[32].dodgeup = 0.2; gun[32].to = 3;
            gun[33].name = "CZ805"; gun[33].what = 2; gun[33].hp = 116; gun[33].damage = 43; gun[33].hit = 49; gun[33].dodge = 41; gun[33].shotspeed = 75; gun[33].crit = 0.2; gun[33].belt = 0; gun[33].number = 2; gun[33].effect0 = 3; gun[33].effect1 = 9; gun[33].damageup = 0; gun[33].hitup = 0.5; gun[33].shotspeedup = 0.25; gun[33].critup = 0; gun[33].dodgeup = 0; gun[33].to = 3;
            gun[34].name = "m4sop"; gun[34].what = 2; gun[34].hp = 110; gun[34].damage = 47; gun[34].hit = 49; gun[34].dodge = 44; gun[34].shotspeed = 78; gun[34].crit = 0.2; gun[34].belt = 0; gun[34].number = 1; gun[34].effect0 = 9; gun[34].damageup = 0; gun[34].hitup = 0; gun[34].shotspeedup = 0; gun[34].critup = 0; gun[34].dodgeup = 0.36; gun[34].to = 2;
            gun[35].name = "tar21"; gun[35].what = 2; gun[35].hp = 105; gun[35].damage = 49; gun[35].hit = 48; gun[35].dodge = 44; gun[35].shotspeed = 79; gun[35].crit = 0.2; gun[35].belt = 0; gun[35].number = 2; gun[35].effect0 = 3; gun[35].effect1 = 9; gun[35].damageup = 0; gun[35].hitup = 0; gun[35].shotspeedup = 0; gun[35].critup = 0; gun[35].dodgeup = 0.18; gun[35].to = 3;
            gun[36].name = "Galil"; gun[36].what = 2; gun[36].hp = 105; gun[36].damage = 50; gun[36].hit = 44; gun[36].dodge = 43; gun[36].shotspeed = 66; gun[36].crit = 0.2; gun[36].belt = 0; gun[36].number = 1; gun[36].effect0 = 6; gun[36].damageup = 0; gun[36].hitup = 0.5; gun[36].shotspeedup = 0; gun[36].critup = 0; gun[36].dodgeup = 0.1; gun[36].to = 3;
            gun[37].name = "SIG510"; gun[37].what = 2; gun[37].hp = 116; gun[37].damage = 54; gun[37].hit = 41; gun[37].dodge = 37; gun[37].shotspeed = 59; gun[37].crit = 0.2; gun[37].belt = 0; gun[37].number = 2; gun[37].effect0 = 3; gun[37].effect1 = 9; gun[37].damageup = 0.2; gun[37].hitup = 0; gun[37].shotspeedup = 0.1; gun[37].critup = 0; gun[37].dodgeup = 0; gun[37].to = 3;
            gun[38].name = "G3"; gun[38].what = 2; gun[38].hp = 110; gun[38].damage = 55; gun[38].hit = 46; gun[38].dodge = 38; gun[38].shotspeed = 61; gun[38].crit = 0.2; gun[38].belt = 0; gun[38].number = 1; gun[38].effect0 = 2; gun[38].damageup = 0; gun[38].hitup = 0.5; gun[38].shotspeedup = 0.2; gun[38].critup = 0; gun[38].dodgeup = 0; gun[38].to = 3;
            gun[39].name = "f2000"; gun[39].what = 2; gun[39].hp = 105; gun[39].damage = 42; gun[39].hit = 44; gun[39].dodge = 40; gun[39].shotspeed = 81; gun[39].crit = 0.2; gun[39].belt = 0; gun[39].number = 1; gun[39].effect0 = 6; gun[39].damageup = 0.2; gun[39].hitup = 0; gun[39].shotspeedup = 0; gun[39].critup = 0; gun[39].dodgeup = 0.1; gun[39].to = 3;
            gun[40].name = "FNC"; gun[40].what = 2; gun[40].hp = 110; gun[40].damage = 51; gun[40].hit = 46; gun[40].dodge = 37; gun[40].shotspeed = 73; gun[40].crit = 0.2; gun[40].belt = 0; gun[40].number = 1; gun[40].effect0 = 3; gun[40].damageup = 0; gun[40].hitup = 0.5; gun[40].shotspeedup = 0; gun[40].critup = 0; gun[40].dodgeup = 0.12; gun[40].to = 3;
            gun[41].name = "L85A1"; gun[41].what = 2; gun[41].hp = 94; gun[41].damage = 46; gun[41].hit = 43; gun[41].dodge = 43; gun[41].shotspeed = 78; gun[41].crit = 0.2; gun[41].belt = 0; gun[41].number = 1; gun[41].effect0 = 2; gun[41].damageup = 0.2; gun[41].hitup = 0.5; gun[41].shotspeedup = 0; gun[41].critup = 0; gun[41].dodgeup = 0; gun[41].to = 3;
            gun[42].name = "9a91"; gun[42].what = 2; gun[42].hp = 116; gun[42].damage = 41; gun[42].hit = 48; gun[42].dodge = 50; gun[42].shotspeed = 78; gun[42].crit = 0.2; gun[42].belt = 0; gun[42].number = 2; gun[42].effect0 = 3; gun[42].effect1 = 9; gun[42].damageup = 0; gun[42].hitup = 0; gun[42].shotspeedup = 0.1; gun[42].critup = 0; gun[42].dodgeup = 0.15; gun[42].to = 3;
            gun[43].name = "ASVAL"; gun[43].what = 2; gun[43].hp = 132; gun[43].damage = 39; gun[43].hit = 46; gun[43].dodge = 49; gun[43].shotspeed = 75; gun[43].crit = 0.2; gun[43].belt = 0; gun[43].number = 1; gun[43].effect0 = 2; gun[43].damageup = 0.25; gun[43].hitup = 0; gun[43].shotspeedup = 0.1; gun[43].critup = 0; gun[43].dodgeup = 0; gun[43].to = 3;
            gun[44].name = "Veldemark2"; gun[44].what = 4; gun[44].hp = 80; gun[44].damage = 27; gun[44].hit = 71; gun[44].dodge = 89; gun[44].shotspeed = 51; gun[44].crit = 0.2; gun[44].belt = 0; gun[44].number = 4; gun[44].effect0 = 1; gun[44].effect1 = 2; gun[44].effect2 = 4; gun[44].effect3 = 7; gun[44].damageup = 0.18; gun[44].hitup = 0; gun[44].shotspeedup = 0.1; gun[44].critup = 0; gun[44].dodgeup = 0; gun[44].to = 1;
            gun[45].name = "Nagant"; gun[45].what = 4; gun[45].hp = 70; gun[45].damage = 32; gun[45].hit = 46; gun[45].dodge = 92; gun[45].shotspeed = 44; gun[45].crit = 0.2; gun[45].belt = 0; gun[45].number = 2; gun[45].effect0 = 2; gun[45].effect1 = 8; gun[45].damageup = 0.25; gun[45].hitup = 0; gun[45].shotspeedup = 0; gun[45].critup = 0.1; gun[45].dodgeup = 0; gun[45].to = 1;
            gun[46].name = "Colt"; gun[46].what = 4; gun[46].hp = 80; gun[46].damage = 36; gun[46].hit = 49; gun[46].dodge = 76; gun[46].shotspeed = 47; gun[46].crit = 0.2; gun[46].belt = 0; gun[46].number = 4; gun[46].effect0 = 2; gun[46].effect1 = 4; gun[46].effect2 = 6; gun[46].effect3 = 8; gun[46].damageup = 0.15; gun[46].hitup = 0.5; gun[46].shotspeedup = 0; gun[46].critup = 0; gun[46].dodgeup = 0; gun[46].to = 1;
            gun[47].name = "Grizzly"; gun[47].what = 4; gun[47].hp = 86; gun[47].damage = 38; gun[47].hit = 51; gun[47].dodge = 66; gun[47].shotspeed = 54; gun[47].crit = 0.2; gun[47].belt = 0; gun[47].number = 5; gun[47].effect0 = 1; gun[47].effect1 = 2; gun[47].effect2 = 6; gun[47].effect3 = 7; gun[47].effect4 = 8; gun[47].damageup = 0.18; gun[47].hitup = 0; gun[47].shotspeedup = 0; gun[47].critup = 0; gun[47].dodgeup = 0.2; gun[47].to = 1;
            gun[48].name = "Tokarev"; gun[48].what = 4; gun[48].hp = 86; gun[48].damage = 31; gun[48].hit = 47; gun[48].dodge = 66; gun[48].shotspeed = 52; gun[48].crit = 0.2; gun[48].belt = 0; gun[48].number = 4; gun[48].effect0 = 2; gun[48].effect1 = 3; gun[48].effect2 = 8; gun[48].effect3 = 9; gun[48].damageup = 0; gun[48].hitup = 0.5; gun[48].shotspeedup = 0.12; gun[48].critup = 0; gun[48].dodgeup = 0; gun[48].to = 1;
            gun[49].name = "Glock17"; gun[49].what = 4; gun[49].hp = 63; gun[49].damage = 29; gun[49].hit = 58; gun[49].dodge = 97; gun[49].shotspeed = 61; gun[49].crit = 0.2; gun[49].belt = 0; gun[49].number = 5; gun[49].effect0 = 1; gun[49].effect1 = 3; gun[49].effect2 = 6; gun[49].effect3 = 7; gun[49].effect4 = 9; gun[49].damageup = 0; gun[49].hitup = 0.5; gun[49].shotspeedup = 0; gun[49].critup = 0; gun[49].dodgeup = 0.25; gun[49].to = 1;
            gun[50].name = "Makarov"; gun[50].what = 4; gun[50].hp = 63; gun[50].damage = 26; gun[50].hit = 61; gun[50].dodge = 96; gun[50].shotspeed = 61; gun[50].crit = 0.2; gun[50].belt = 0; gun[50].number = 4; gun[50].effect0 = 1; gun[50].effect1 = 4; gun[50].effect2 = 6; gun[50].effect3 = 7; gun[50].damageup = 0.12; gun[50].hitup = 0; gun[50].shotspeedup = 0.1; gun[50].critup = 0; gun[50].dodgeup = 0; gun[50].to = 1;
            gun[51].name = "Stechkin"; gun[51].what = 4; gun[51].hp = 83; gun[51].damage = 28; gun[51].hit = 44; gun[51].dodge = 66; gun[51].shotspeed = 65; gun[51].crit = 0.2; gun[51].belt = 0; gun[51].number = 4; gun[51].effect0 = 2; gun[51].effect1 = 3; gun[51].effect2 = 8; gun[51].effect3 = 9; gun[51].damageup = 0.1; gun[51].hitup = 0; gun[51].shotspeedup = 0.15; gun[51].critup = 0; gun[51].dodgeup = 0; gun[51].to = 1;
            gun[52].name = "Astra"; gun[52].what = 4; gun[52].hp = 80; gun[52].damage = 33; gun[52].hit = 45; gun[52].dodge = 68; gun[52].shotspeed = 52; gun[52].crit = 0.2; gun[52].belt = 0; gun[52].number = 4; gun[52].effect0 = 1; gun[52].effect1 = 3; gun[52].effect2 = 7; gun[52].effect3 = 9; gun[52].damageup = 0; gun[52].hitup = 0; gun[52].shotspeedup = 0.15; gun[52].critup = 0; gun[52].dodgeup = 0.15; gun[52].to = 1;
            gun[53].name = "p08"; gun[53].what = 4; gun[53].hp = 70; gun[53].damage = 31; gun[53].hit = 46; gun[53].dodge = 80; gun[53].shotspeed = 55; gun[53].crit = 0.2; gun[53].belt = 0; gun[53].number = 2; gun[53].effect0 = 2; gun[53].effect1 = 8; gun[53].damageup = 0.2; gun[53].hitup = 0.6; gun[53].shotspeedup = 0; gun[53].critup = 0; gun[53].dodgeup = 0; gun[53].to = 1;
            gun[54].name = "mk23"; gun[54].what = 4; gun[54].hp = 80; gun[54].damage = 29; gun[54].hit = 53; gun[54].dodge = 66; gun[54].shotspeed = 63; gun[54].crit = 0.2; gun[54].belt = 0; gun[54].number = 4; gun[54].effect0 = 3; gun[54].effect1 = 4; gun[54].effect2 = 6; gun[54].effect3 = 9; gun[54].damageup = 0.25; gun[54].hitup = 0; gun[54].shotspeedup = 0; gun[54].critup = 0; gun[54].dodgeup = 0; gun[54].to = 1;
            gun[55].name = "M1911"; gun[55].what = 4; gun[55].hp = 73; gun[55].damage = 27; gun[55].hit = 50; gun[55].dodge = 74; gun[55].shotspeed = 57; gun[55].crit = 0.2; gun[55].belt = 0; gun[55].number = 4; gun[55].effect0 = 2; gun[55].effect1 = 4; gun[55].effect2 = 6; gun[55].effect3 = 8; gun[55].damageup = 0; gun[55].hitup = 0.5; gun[55].shotspeedup = 0.1; gun[55].critup = 0; gun[55].dodgeup = 0; gun[55].to = 1;
            gun[56].name = "PPK"; gun[56].what = 4; gun[56].hp = 57; gun[56].damage = 25; gun[56].hit = 59; gun[56].dodge = 100; gun[56].shotspeed = 63; gun[56].crit = 0.2; gun[56].belt = 0; gun[56].number = 4; gun[56].effect0 = 1; gun[56].effect1 = 4; gun[56].effect2 = 6; gun[56].effect3 = 7; gun[56].damageup = 0; gun[56].hitup = 0; gun[56].shotspeedup = 0.2; gun[56].critup = 0.1; gun[56].dodgeup = 0; gun[56].to = 1;
            gun[57].name = "C96"; gun[57].what = 4; gun[57].hp = 83; gun[57].damage = 29; gun[57].hit = 41; gun[57].dodge = 61; gun[57].shotspeed = 62; gun[57].crit = 0.2; gun[57].belt = 0; gun[57].number = 3; gun[57].effect0 = 1; gun[57].effect1 = 6; gun[57].effect2 = 7; gun[57].damageup = 0; gun[57].hitup = 0.5; gun[57].shotspeedup = 0; gun[57].critup = 0; gun[57].dodgeup = 0.25; gun[57].to = 1;
            gun[58].name = "m950A"; gun[58].what = 4; gun[58].hp = 76; gun[58].damage = 30; gun[58].hit = 55; gun[58].dodge = 68; gun[58].shotspeed = 72; gun[58].crit = 0.2; gun[58].belt = 0; gun[58].number = 4; gun[58].effect0 = 1; gun[58].effect1 = 3; gun[58].effect2 = 7; gun[58].effect3 = 9; gun[58].damageup = 0; gun[58].hitup = 0.5; gun[58].shotspeedup = 0.18; gun[58].critup = 0; gun[58].dodgeup = 0; gun[58].to = 1;
            gun[59].name = "p38"; gun[59].what = 4; gun[59].hp = 66; gun[59].damage = 28; gun[59].hit = 49; gun[59].dodge = 81; gun[59].shotspeed = 57; gun[59].crit = 0.2; gun[59].belt = 0; gun[59].number = 4; gun[59].effect0 = 2; gun[59].effect1 = 3; gun[59].effect2 = 8; gun[59].effect3 = 9; gun[59].damageup = 0; gun[59].hitup = 0.5; gun[59].shotspeedup = 0.1; gun[59].critup = 0; gun[59].dodgeup = 0; gun[59].to = 1;
            gun[60].name = "m9"; gun[60].what = 4; gun[60].hp = 76; gun[60].damage = 29; gun[60].hit = 56; gun[60].dodge = 66; gun[60].shotspeed = 61; gun[60].crit = 0.2; gun[60].belt = 0; gun[60].number = 4; gun[60].effect0 = 1; gun[60].effect1 = 2; gun[60].effect2 = 7; gun[60].effect3 = 8; gun[60].damageup = 0; gun[60].hitup = 0; gun[60].shotspeedup = 0; gun[60].critup = 0; gun[60].dodgeup = 0.4; gun[60].to = 1;
            gun[61].name = "p7"; gun[61].what = 4; gun[61].hp = 63; gun[61].damage = 32; gun[61].hit = 62; gun[61].dodge = 83; gun[61].shotspeed = 61; gun[61].crit = 0.2; gun[61].belt = 0; gun[61].number = 6; gun[61].effect0 = 1; gun[61].effect1 = 2; gun[61].effect2 = 3; gun[61].effect3 = 7; gun[61].effect4 = 8; gun[61].effect5 = 9; gun[61].damageup = 0; gun[61].hitup = 0; gun[61].shotspeedup = 0.1; gun[61].critup = 0; gun[61].dodgeup = 0.2; gun[61].to = 1;
            gun[62].name = "92"; gun[62].what = 4; gun[62].hp = 63; gun[62].damage = 31; gun[62].hit = 46; gun[62].dodge = 80; gun[62].shotspeed = 61; gun[62].crit = 0.2; gun[62].belt = 0; gun[62].number = 8; gun[62].effect0 = 1; gun[62].effect1 = 2; gun[62].effect2 = 3; gun[62].effect3 = 4; gun[62].effect4 = 6; gun[62].effect5 = 7; gun[62].effect6 = 8; gun[62].effect7 = 9; gun[62].damageup = 0; gun[62].hitup = 0.35; gun[62].shotspeedup = 0; gun[62].critup = 0; gun[62].dodgeup = 0.25; gun[62].to = 1;
            gun[63].name = "fnp-9"; gun[63].what = 4; gun[63].hp = 60; gun[63].damage = 28; gun[63].hit = 53; gun[63].dodge = 83; gun[63].shotspeed = 61; gun[63].crit = 0.2; gun[63].belt = 0; gun[63].number = 5; gun[63].effect0 = 2; gun[63].effect1 = 3; gun[63].effect2 = 6; gun[63].effect3 = 8; gun[63].effect4 = 9; gun[63].damageup = 0; gun[63].hitup = 0; gun[63].shotspeedup = 0.1; gun[63].critup = 0; gun[63].dodgeup = 0; gun[63].to = 1;
            gun[64].name = "MP446"; gun[64].what = 4; gun[64].hp = 66; gun[64].damage = 29; gun[64].hit = 51; gun[64].dodge = 72; gun[64].shotspeed = 59; gun[64].crit = 0.2; gun[64].belt = 0; gun[64].number = 5; gun[64].effect0 = 1; gun[64].effect1 = 2; gun[64].effect2 = 4; gun[64].effect3 = 7; gun[64].effect4 = 8; gun[64].damageup = 0.2; gun[64].hitup = 0; gun[64].shotspeedup = 0; gun[64].critup = 0; gun[64].dodgeup = 0; gun[64].to = 1;
            gun[65].name = "Simonov"; gun[65].what = 5; gun[65].hp = 93; gun[65].damage = 100; gun[65].hit = 59; gun[65].dodge = 34; gun[65].shotspeed = 34; gun[65].crit = 0.4; gun[65].belt = 0; gun[65].number = 0; gun[65].damageup = 0; gun[65].hitup = 0; gun[65].shotspeedup = 0; gun[65].critup = 0; gun[65].dodgeup = 0; gun[65].to = 0;
            gun[66].name = "FN-49"; gun[66].what = 5; gun[66].hp = 93; gun[66].damage = 111; gun[66].hit = 61; gun[66].dodge = 32; gun[66].shotspeed = 32; gun[66].crit = 0.4; gun[66].belt = 0; gun[66].number = 0; gun[66].damageup = 0; gun[66].hitup = 0; gun[66].shotspeedup = 0; gun[66].critup = 0; gun[66].dodgeup = 0; gun[66].to = 0;
            gun[67].name = "Lee-Enfield"; gun[67].what = 5; gun[67].hp = 80; gun[67].damage = 135; gun[67].hit = 78; gun[67].dodge = 40; gun[67].shotspeed = 36; gun[67].crit = 0.4; gun[67].belt = 0; gun[67].number = 0; gun[67].damageup = 0; gun[67].hitup = 0; gun[67].shotspeedup = 0; gun[67].critup = 0; gun[67].dodgeup = 0; gun[67].to = 0;
            gun[68].name = "ntw-20"; gun[68].what = 5; gun[68].hp = 93; gun[68].damage = 165; gun[68].hit = 75; gun[68].dodge = 29; gun[68].shotspeed = 30; gun[68].crit = 0.4; gun[68].belt = 0; gun[68].number = 0; gun[68].damageup = 0; gun[68].hitup = 0; gun[68].shotspeedup = 0; gun[68].critup = 0; gun[68].dodgeup = 0; gun[68].to = 0;
            gun[69].name = "PTRD"; gun[69].what = 5; gun[69].hp = 93; gun[69].damage = 159; gun[69].hit = 75; gun[69].dodge = 29; gun[69].shotspeed = 28; gun[69].crit = 0.4; gun[69].belt = 0; gun[69].number = 0; gun[69].damageup = 0; gun[69].hitup = 0; gun[69].shotspeedup = 0; gun[69].critup = 0; gun[69].dodgeup = 0; gun[69].to = 0;
            gun[70].name = "SVT-38"; gun[70].what = 5; gun[70].hp = 84; gun[70].damage = 110; gun[70].hit = 59; gun[70].dodge = 34; gun[70].shotspeed = 34; gun[70].crit = 0.4; gun[70].belt = 0; gun[70].number = 0; gun[70].damageup = 0; gun[70].hitup = 0; gun[70].shotspeedup = 0; gun[70].critup = 0; gun[70].dodgeup = 0; gun[70].to = 0;
            gun[71].name = "wa2000"; gun[71].what = 5; gun[71].hp = 88; gun[71].damage = 130; gun[71].hit = 82; gun[71].dodge = 30; gun[71].shotspeed = 39; gun[71].crit = 0.4; gun[71].belt = 0; gun[71].number = 0; gun[71].damageup = 0; gun[71].hitup = 0; gun[71].shotspeedup = 0; gun[71].critup = 0; gun[71].dodgeup = 0; gun[71].to = 0;
            gun[72].name = "M14"; gun[72].what = 5; gun[72].hp = 93; gun[72].damage = 108; gun[72].hit = 71; gun[72].dodge = 27; gun[72].shotspeed = 43; gun[72].crit = 0.4; gun[72].belt = 0; gun[72].number = 0; gun[72].damageup = 0; gun[72].hitup = 0; gun[72].shotspeedup = 0; gun[72].critup = 0; gun[72].dodgeup = 0; gun[72].to = 0;
            gun[73].name = "m21"; gun[73].what = 5; gun[73].hp = 93; gun[73].damage = 118; gun[73].hit = 74; gun[73].dodge = 27; gun[73].shotspeed = 35; gun[73].crit = 0.4; gun[73].belt = 0; gun[73].number = 0; gun[73].damageup = 0; gun[73].hitup = 0; gun[73].shotspeedup = 0; gun[73].critup = 0; gun[73].dodgeup = 0; gun[73].to = 0;
            gun[74].name = "BM59"; gun[74].what = 5; gun[74].hp = 93; gun[74].damage = 118; gun[74].hit = 73; gun[74].dodge = 27; gun[74].shotspeed = 35; gun[74].crit = 0.4; gun[74].belt = 0; gun[74].number = 0; gun[74].damageup = 0; gun[74].hitup = 0; gun[74].shotspeedup = 0; gun[74].critup = 0; gun[74].dodgeup = 0; gun[74].to = 0;
            gun[75].name = "M1Garand"; gun[75].what = 5; gun[75].hp = 88; gun[75].damage = 120; gun[75].hit = 62; gun[75].dodge = 28; gun[75].shotspeed = 37; gun[75].crit = 0.4; gun[75].belt = 0; gun[75].number = 0; gun[75].damageup = 0; gun[75].hitup = 0; gun[75].shotspeedup = 0; gun[75].critup = 0; gun[75].dodgeup = 0; gun[75].to = 0;
            gun[76].name = "SV98"; gun[76].what = 5; gun[76].hp = 84; gun[76].damage = 122; gun[76].hit = 74; gun[76].dodge = 28; gun[76].shotspeed = 37; gun[76].crit = 0.4; gun[76].belt = 0; gun[76].number = 0; gun[76].damageup = 0; gun[76].hitup = 0; gun[76].shotspeedup = 0; gun[76].critup = 0; gun[76].dodgeup = 0; gun[76].to = 0;
            gun[77].name = "G43"; gun[77].what = 5; gun[77].hp = 80; gun[77].damage = 111; gun[77].hit = 58; gun[77].dodge = 28; gun[77].shotspeed = 40; gun[77].crit = 0.4; gun[77].belt = 0; gun[77].number = 0; gun[77].damageup = 0; gun[77].hitup = 0; gun[77].shotspeedup = 0; gun[77].critup = 0; gun[77].dodgeup = 0; gun[77].to = 0;
            gun[78].name = "MauserM1888"; gun[78].what = 5; gun[78].hp = 102; gun[78].damage = 108; gun[78].hit = 60; gun[78].dodge = 37; gun[78].shotspeed = 31; gun[78].crit = 0.4; gun[78].belt = 0; gun[78].number = 0; gun[78].damageup = 0; gun[78].hitup = 0; gun[78].shotspeedup = 0; gun[78].critup = 0; gun[78].dodgeup = 0; gun[78].to = 0;
            gun[79].name = "K298k"; gun[79].what = 5; gun[79].hp = 84; gun[79].damage = 135; gun[79].hit = 78; gun[79].dodge = 41; gun[79].shotspeed = 34; gun[79].crit = 0.4; gun[79].belt = 0; gun[79].number = 0; gun[79].damageup = 0; gun[79].hitup = 0; gun[79].shotspeedup = 0; gun[79].critup = 0; gun[79].dodgeup = 0; gun[79].to = 0;
            gun[80].name = "mosin-nagant"; gun[80].what = 5; gun[80].hp = 88; gun[80].damage = 131; gun[80].hit = 85; gun[80].dodge = 38; gun[80].shotspeed = 30; gun[80].crit = 0.4; gun[80].belt = 0; gun[80].number = 0; gun[80].damageup = 0; gun[80].hitup = 0; gun[80].shotspeedup = 0; gun[80].critup = 0; gun[80].dodgeup = 0; gun[80].to = 0;
            gun[81].name = "SpringField"; gun[81].what = 5; gun[81].hp = 84; gun[81].damage = 128; gun[81].hit = 72; gun[81].dodge = 40; gun[81].shotspeed = 32; gun[81].crit = 0.4; gun[81].belt = 0; gun[81].number = 0; gun[81].damageup = 0; gun[81].hitup = 0; gun[81].shotspeedup = 0; gun[81].critup = 0; gun[81].dodgeup = 0; gun[81].to = 0;
            gun[82].name = "M60"; gun[82].what = 6; gun[82].hp = 182; gun[82].damage = 92; gun[82].hit = 26; gun[82].dodge = 26; gun[82].shotspeed = 111; gun[82].crit = 0.05; gun[82].belt = 9; gun[82].number = 0; gun[82].damageup = 0; gun[82].hitup = 0; gun[82].shotspeedup = 0; gun[82].critup = 0; gun[82].dodgeup = 0; gun[82].to = 0;
            gun[83].name = "65"; gun[83].what = 6; gun[83].hp = 198; gun[83].damage = 85; gun[83].hit = 27; gun[83].dodge = 25; gun[83].shotspeed = 120; gun[83].crit = 0.05; gun[83].belt = 11; gun[83].number = 0; gun[83].damageup = 0; gun[83].hitup = 0; gun[83].shotspeedup = 0; gun[83].critup = 0; gun[83].dodgeup = 0; gun[83].to = 0;
            gun[84].name = "M1918"; gun[84].what = 6; gun[84].hp = 157; gun[84].damage = 96; gun[84].hit = 31; gun[84].dodge = 33; gun[84].shotspeed = 114; gun[84].crit = 0.05; gun[84].belt = 8; gun[84].number = 0; gun[84].damageup = 0; gun[84].hitup = 0; gun[84].shotspeedup = 0; gun[84].critup = 0; gun[84].dodgeup = 0; gun[84].to = 0;
            gun[85].name = "63"; gun[85].what = 6; gun[85].hp = 198; gun[85].damage = 85; gun[85].hit = 26; gun[85].dodge = 21; gun[85].shotspeed = 130; gun[85].crit = 0.05; gun[85].belt = 10; gun[85].number = 0; gun[85].damageup = 0; gun[85].hitup = 0; gun[85].shotspeedup = 0; gun[85].critup = 0; gun[85].dodgeup = 0; gun[85].to = 0;
            gun[86].name = "M1919A4"; gun[86].what = 6; gun[86].hp = 174; gun[86].damage = 96; gun[86].hit = 26; gun[86].dodge = 22; gun[86].shotspeed = 99; gun[86].crit = 0.05; gun[86].belt = 9; gun[86].number = 0; gun[86].damageup = 0; gun[86].hitup = 0; gun[86].shotspeedup = 0; gun[86].critup = 0; gun[86].dodgeup = 0; gun[86].to = 0;
            gun[87].name = "PK"; gun[87].what = 6; gun[87].hp = 190; gun[87].damage = 93; gun[87].hit = 21; gun[87].dodge = 22; gun[87].shotspeed = 83; gun[87].crit = 0.05; gun[87].belt = 11; gun[87].number = 0; gun[87].damageup = 0; gun[87].hitup = 0; gun[87].shotspeedup = 0; gun[87].critup = 0; gun[87].dodgeup = 0; gun[87].to = 0;
            gun[88].name = "Negev"; gun[88].what = 6; gun[88].hp = 174; gun[88].damage = 84; gun[88].hit = 35; gun[88].dodge = 36; gun[88].shotspeed = 139; gun[88].crit = 0.05; gun[88].belt = 9; gun[88].number = 0; gun[88].damageup = 0; gun[88].hitup = 0; gun[88].shotspeedup = 0; gun[88].critup = 0; gun[88].dodgeup = 0; gun[88].to = 0;
            gun[89].name = "rpd"; gun[89].what = 6; gun[89].hp = 165; gun[89].damage = 82; gun[89].hit = 34; gun[89].dodge = 34; gun[89].shotspeed = 121; gun[89].crit = 0.05; gun[89].belt = 8; gun[89].number = 0; gun[89].damageup = 0; gun[89].hitup = 0; gun[89].shotspeedup = 0; gun[89].critup = 0; gun[89].dodgeup = 0; gun[89].to = 0;
            gun[90].name = "M2HB"; gun[90].what = 6; gun[90].hp = 215; gun[90].damage = 102; gun[90].hit = 18; gun[90].dodge = 16; gun[90].shotspeed = 100; gun[90].crit = 0.05; gun[90].belt = 9; gun[90].number = 0; gun[90].damageup = 0; gun[90].hitup = 0; gun[90].shotspeedup = 0; gun[90].critup = 0; gun[90].dodgeup = 0; gun[90].to = 0;
            gun[91].name = "LWMMG"; gun[91].what = 6; gun[91].hp = 174; gun[91].damage = 92; gun[91].hit = 23; gun[91].dodge = 22; gun[91].shotspeed = 89; gun[91].crit = 0.05; gun[91].belt = 9; gun[91].number = 0; gun[91].damageup = 0; gun[91].hitup = 0; gun[91].shotspeedup = 0; gun[91].critup = 0; gun[91].dodgeup = 0; gun[91].to = 0;
            gun[92].name = "M249 SAW"; gun[92].what = 6; gun[92].hp = 157; gun[92].damage = 79; gun[92].hit = 35; gun[92].dodge = 36; gun[92].shotspeed = 139; gun[92].crit = 0.05; gun[92].belt = 8; gun[92].number = 0; gun[92].damageup = 0; gun[92].hitup = 0; gun[92].shotspeedup = 0; gun[92].critup = 0; gun[92].dodgeup = 0; gun[92].to = 0;
            gun[93].name = "aat-52"; gun[93].what = 6; gun[93].hp = 182; gun[93].damage = 79; gun[93].hit = 22; gun[93].dodge = 22; gun[93].shotspeed = 118; gun[93].crit = 0.05; gun[93].belt = 10; gun[93].number = 0; gun[93].damageup = 0; gun[93].hitup = 0; gun[93].shotspeedup = 0; gun[93].critup = 0; gun[93].dodgeup = 0; gun[93].to = 0;
            gun[94].name = "DP28"; gun[94].what = 6; gun[94].hp = 141; gun[94].damage = 88; gun[94].hit = 28; gun[94].dodge = 31; gun[94].shotspeed = 114; gun[94].crit = 0.05; gun[94].belt = 9; gun[94].number = 0; gun[94].damageup = 0; gun[94].hitup = 0; gun[94].shotspeedup = 0; gun[94].critup = 0; gun[94].dodgeup = 0; gun[94].to = 0;
            gun[95].name = "642"; gun[95].what = 6; gun[95].hp = 165; gun[95].damage = 87; gun[95].hit = 23; gun[95].dodge = 26; gun[95].shotspeed = 132; gun[95].crit = 0.05; gun[95].belt = 10; gun[95].number = 0; gun[95].damageup = 0; gun[95].hitup = 0; gun[95].shotspeedup = 0; gun[95].critup = 0; gun[95].dodgeup = 0; gun[95].to = 0;
            gun[96].name = "634"; gun[96].what = 6; gun[96].hp = 157; gun[96].damage = 85; gun[96].hit = 22; gun[96].dodge = 25; gun[96].shotspeed = 120; gun[96].crit = 0.05; gun[96].belt = 10; gun[96].number = 0; gun[96].damageup = 0; gun[96].hitup = 0; gun[96].shotspeedup = 0; gun[96].critup = 0; gun[96].dodgeup = 0; gun[96].to = 0;
            gun[97].name = "Bren"; gun[97].what = 6; gun[97].hp = 174; gun[97].damage = 81; gun[97].hit = 29; gun[97].dodge = 28; gun[97].shotspeed = 102; gun[97].crit = 0.05; gun[97].belt = 8; gun[97].number = 0; gun[97].damageup = 0; gun[97].hitup = 0; gun[97].shotspeedup = 0; gun[97].critup = 0; gun[97].dodgeup = 0; gun[97].to = 0;
            gun[98].name = "FG42"; gun[98].what = 6; gun[98].hp = 149; gun[98].damage = 80; gun[98].hit = 25; gun[98].dodge = 30; gun[98].shotspeed = 116; gun[98].crit = 0.05; gun[98].belt = 8; gun[98].number = 0; gun[98].damageup = 0; gun[98].hitup = 0; gun[98].shotspeedup = 0; gun[98].critup = 0; gun[98].dodgeup = 0; gun[98].to = 0;
            gun[99].name = "mk48"; gun[99].what = 6; gun[99].hp = 174; gun[99].damage = 90; gun[99].hit = 24; gun[99].dodge = 26; gun[99].shotspeed = 111; gun[99].crit = 0.05; gun[99].belt = 10; gun[99].number = 0; gun[99].damageup = 0; gun[99].hitup = 0; gun[99].shotspeedup = 0; gun[99].critup = 0; gun[99].dodgeup = 0; gun[99].to = 0;


            for (int i = 0; i < 101; i++)
            {
                Combo0.Items.Add(gun[i].name);
                Combo1.Items.Add(gun[i].name);
                Combo2.Items.Add(gun[i].name);
                Combo3.Items.Add(gun[i].name);
                Combo4.Items.Add(gun[i].name);
                Combo5.Items.Add(gun[i].name);
                Combo6.Items.Add(gun[i].name);
                Combo7.Items.Add(gun[i].name);
                Combo8.Items.Add(gun[i].name);
            }


            for (int i = 0; i < 9; i++)
            {
                gg[i] = new GunGrid();
                gg[i].critup = 1.00;
                gg[i].damageup = 1.00;
                gg[i].dodgeup = 1.00;
                gg[i].hitup = 1.00;
                gg[i].shotspeedup = 1.00;
                lastgunindex[i] = -1;
            }

          //  Gun tar-21 = new Gun();

          //  汤姆森.ToString();
        
        }



        public void othercombochange(int nextselect,int select,int grid,int ggi,int combo){


            changeeffect(grid, ggi, combo, nextselect, select);

            switch (gun[nextselect].number)
            {
                      
                case 1:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                          
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                   //         MessageBox.Show(lastgunindex[combo].ToString());
                        }
                        break;
                    }
                case 2:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                 //           changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                    //        changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        break;
                    }
                case 3:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                  //          changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                    //        changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        else if (gun[nextselect].effect2 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                   //         changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[2] == -1)
                            {
                                lastgunindex[2] = select;
                            }
                        }
                        break;
                    }
                case 4:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                     //       changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        else if (gun[nextselect].effect2 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[2] == -1)
                            {
                                lastgunindex[2] = select;
                            }
                        }
                        else if (gun[nextselect].effect3 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[3] == -1)
                            {
                                lastgunindex[3] = select;
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                    //        changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        else if (gun[nextselect].effect2 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[2] == -1)
                            {
                                lastgunindex[2] = select;
                            }
                        }
                        else if (gun[nextselect].effect3 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[3] == -1)
                            {
                                lastgunindex[3] = select;
                            }
                        }
                        else if (gun[nextselect].effect4 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[4] == -1)
                            {
                                lastgunindex[4] = select;
                            }
                        }
                        break;
                    }
                case 6:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                    //        changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        else if (gun[nextselect].effect2 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[2] == -1)
                            {
                                lastgunindex[2] = select;
                            }
                        }
                        else if (gun[nextselect].effect3 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                     //       changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[3] == -1)
                            {
                                lastgunindex[3] = select;
                            }
                        }
                        else if (gun[nextselect].effect4 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                     //       changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[4] == -1)
                            {
                                lastgunindex[4] = select;
                            }
                        }
                        else if (gun[nextselect].effect5 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[5] == -1)
                            {
                                lastgunindex[5] = select;
                            }
                        }
                        break;
                    }
                case 7:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        else if (gun[nextselect].effect2 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[2] == -1)
                            {
                                lastgunindex[2] = select;
                            }
                        }
                        else if (gun[nextselect].effect3 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[3] == -1)
                            {
                                lastgunindex[3] = select;
                            }
                        }
                        else if (gun[nextselect].effect4 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[4] == -1)
                            {
                                lastgunindex[4] = select;
                            }
                        }
                        else if (gun[nextselect].effect5 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[5] == -1)
                            {
                                lastgunindex[5] = select;
                            }
                        }
                        else if (gun[nextselect].effect6 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[6] == -1)
                            {
                                lastgunindex[6] = select;
                            }
                        }
                        break;
                    }
                case 8:
                    {
                        if (gun[nextselect].effect0 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[0] == -1)
                            {
                                lastgunindex[0] = select;
                            }
                        }
                        else if (gun[nextselect].effect1 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[1] == -1)
                            {
                                lastgunindex[1] = select;
                            }
                        }
                        else if (gun[nextselect].effect2 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[2] == -1)
                            {
                                lastgunindex[2] = select;
                            }
                        }
                        else if (gun[nextselect].effect3 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[3] == -1)
                            {
                                lastgunindex[3] = select;
                            }
                        }
                        else if (gun[nextselect].effect4 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[4] == -1)
                            {
                                lastgunindex[4] = select;
                            }
                        }
                        else if (gun[nextselect].effect5 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[5] == -1)
                            {
                                lastgunindex[5] = select;
                            }
                        }
                        else if (gun[nextselect].effect6 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                      //      changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[6] == -1)
                            {
                                lastgunindex[6] = select;
                            }
                        }
                        else if (gun[nextselect].effect7 == grid && (gun[nextselect].to == gun[select].what || gun[nextselect].to == 1))
                        {
                            gg[ggi].critup += gun[nextselect].critup;
                            gg[ggi].damageup += gun[nextselect].damageup;
                            gg[ggi].dodgeup += gun[nextselect].dodgeup;
                            gg[ggi].shotspeedup += gun[nextselect].shotspeedup;
                            gg[ggi].hitup += gun[nextselect].hitup;
                       //     changeeffect(grid,ggi, combo, nextselect, select);
                            if (lastgunindex[7] == -1)
                            {
                                lastgunindex[7] = select;
                            }
                        }
                        break;
                    }
                default:
                    break;
            }


        }


        public void renewindex(int comboi)
        {
            int select = 0;
            switch(comboi)
            {
                case 0:
                    {
                        select = Combo0.SelectedIndex;
                        Ldamage0.Content = gun[select].damage * gg[0].damageup;
                        Lhit0.Content = gun[select].hit * gg[0].hitup;
                        Lshotspeed0.Content = gun[select].shotspeed * gg[0].shotspeedup;
                        Lcrit0.Content = gun[select].crit * gg[0].critup;
                        Ldodge0.Content = gun[select].dodge * gg[0].dodgeup;
                        Lindex0.Content = (Index((double)Lshotspeed0.Content, (double)Ldamage0.Content, (double)Lcrit0.Content, Int32.Parse(enemydodge.Text), (double)Lhit0.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 1:
                    {
                        select = Combo1.SelectedIndex;
                        Ldamage1.Content = gun[select].damage * gg[1].damageup;
                        Lhit1.Content = gun[select].hit * gg[1].hitup;
                        Lshotspeed1.Content = gun[select].shotspeed * gg[1].shotspeedup;
                        Lcrit1.Content = gun[select].crit * gg[1].critup;
                        Ldodge1.Content = gun[select].dodge * gg[1].dodgeup;
                        Lindex1.Content = (Index((double)Lshotspeed1.Content, (double)Ldamage1.Content, (double)Lcrit1.Content, Int32.Parse(enemydodge.Text), (double)Lhit1.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 2:
                    {
                        select = Combo2.SelectedIndex;
                        Ldamage2.Content = gun[select].damage * gg[2].damageup;
                        Lhit2.Content = gun[select].hit * gg[2].hitup;
                        Lshotspeed2.Content = gun[select].shotspeed * gg[2].shotspeedup;
                        Lcrit2.Content = gun[select].crit * gg[2].critup;
                        Ldodge2.Content = gun[select].dodge * gg[2].dodgeup;
                        Lindex2.Content = (Index((double)Lshotspeed2.Content, (double)Ldamage2.Content, (double)Lcrit2.Content, Int32.Parse(enemydodge.Text), (double)Lhit2.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 3:
                    {
                        select = Combo3.SelectedIndex;
                        Ldamage3.Content = gun[select].damage * gg[3].damageup;
                        Lhit3.Content = gun[select].hit * gg[3].hitup;
                        Lshotspeed3.Content = gun[select].shotspeed * gg[3].shotspeedup;
                        Lcrit3.Content = gun[select].crit * gg[3].critup;
                        Ldodge3.Content = gun[select].dodge * gg[3].dodgeup;
                        Lindex3.Content = (Index((double)Lshotspeed3.Content, (double)Ldamage3.Content, (double)Lcrit3.Content, Int32.Parse(enemydodge.Text), (double)Lhit3.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 4:
                    {
                        select = Combo4.SelectedIndex;
                        Ldamage4.Content = gun[select].damage * gg[4].damageup;
                        Lhit4.Content = gun[select].hit * gg[4].hitup;
                        Lshotspeed4.Content = gun[select].shotspeed * gg[4].shotspeedup;
                        Lcrit4.Content = gun[select].crit * gg[4].critup;
                        Ldodge4.Content = gun[select].dodge * gg[4].dodgeup;
                        Lindex4.Content = (Index((double)Lshotspeed4.Content, (double)Ldamage4.Content, (double)Lcrit4.Content, Int32.Parse(enemydodge.Text), (double)Lhit4.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 5:
                    {
                        select = Combo5.SelectedIndex;
                        Ldamage5.Content = gun[select].damage * gg[5].damageup;
                        Lhit5.Content = gun[select].hit * gg[5].hitup;
                        Lshotspeed5.Content = gun[select].shotspeed * gg[5].shotspeedup;
                        Lcrit5.Content = gun[select].crit * gg[5].critup;
                        Ldodge5.Content = gun[select].dodge * gg[5].dodgeup;
                        Lindex5.Content = (Index((double)Lshotspeed5.Content, (double)Ldamage5.Content, (double)Lcrit5.Content, Int32.Parse(enemydodge.Text), (double)Lhit5.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 6:
                    {
                        select = Combo6.SelectedIndex;
                        Ldamage6.Content = gun[select].damage * gg[6].damageup;
                        Lhit6.Content = gun[select].hit * gg[6].hitup;
                        Lshotspeed6.Content = gun[select].shotspeed * gg[6].shotspeedup;
                        Lcrit6.Content = gun[select].crit * gg[6].critup;
                        Ldodge6.Content = gun[select].dodge * gg[6].dodgeup;
                        Lindex6.Content = (Index((double)Lshotspeed6.Content, (double)Ldamage6.Content, (double)Lcrit6.Content, Int32.Parse(enemydodge.Text), (double)Lhit6.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 7:
                    {
                        select = Combo7.SelectedIndex;
                        Ldamage7.Content = gun[select].damage * gg[7].damageup;
                        Lhit7.Content = gun[select].hit * gg[7].hitup;
                        Lshotspeed7.Content = gun[select].shotspeed * gg[7].shotspeedup;
                        Lcrit7.Content = gun[select].crit * gg[7].critup;
                        Ldodge7.Content = gun[select].dodge * gg[7].dodgeup;
                        Lindex7.Content = (Index((double)Lshotspeed7.Content, (double)Ldamage7.Content, (double)Lcrit7.Content, Int32.Parse(enemydodge.Text), (double)Lhit7.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
                case 8:
                    {
                        select = Combo8.SelectedIndex;
                        Ldamage8.Content = gun[select].damage * gg[8].damageup;
                        Lhit8.Content = gun[select].hit * gg[8].hitup;
                        Lshotspeed8.Content = gun[select].shotspeed * gg[8].shotspeedup;
                        Lcrit8.Content = gun[select].crit * gg[8].critup;
                        Ldodge8.Content = gun[select].dodge * gg[8].dodgeup;
                        Lindex8.Content = (Index((double)Lshotspeed8.Content, (double)Ldamage8.Content, (double)Lcrit8.Content, Int32.Parse(enemydodge.Text), (double)Lhit8.Content)).ToString("0.00");
                        allindex.Content = (Double.Parse(Lindex0.Content.ToString()) + Double.Parse(Lindex1.Content.ToString()) + Double.Parse(Lindex2.Content.ToString()) + Double.Parse(Lindex3.Content.ToString()) + Double.Parse(Lindex4.Content.ToString()) + Double.Parse(Lindex5.Content.ToString()) + Double.Parse(Lindex6.Content.ToString()) + Double.Parse(Lindex7.Content.ToString()) + Double.Parse(Lindex8.Content.ToString())).ToString("0.00");
                        break;
                    }
            }
        }
       

        public double Index(double shotspeed,double damage,double crit,int enemydodge,double hit)
       {
           double index = shotspeed * damage / 50 * (1 - crit + crit * 1.5) / (1 + enemydodge / hit);
           return index;
       }

       public bool ifhaveaura(int togrid,int toindex,int index)
        {
           // MessageBox.Show(gun[index].name);
           // togrid = 10 - togrid;
            if (gun[index].effect0 != 0 && gun[index].effect0 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect1 != 0 && gun[index].effect1 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect2 != 0 && gun[index].effect2 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect3 != 0 && gun[index].effect3 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect4 != 0 && gun[index].effect4 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect5 != 0 && gun[index].effect5 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect6 != 0 && gun[index].effect6 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else if (gun[index].effect7 != 0 && gun[index].effect7 == togrid && (gun[index].to == gun[toindex].what || gun[index].to == 1))
                return true;
            else
                return false;
        }

        public void changeeffect(int grid,int tocombo,int combo,int toindex,int index)
        {

          //  MessageBox.Show(gun[toindex].name);
             if (lastgunindex[tocombo]!=-1&&ifhaveaura(grid, toindex, lastgunindex[tocombo]))
            {
             //   MessageBox.Show(gg[tocombo].damageup.ToString());
                gg[tocombo].shotspeedup -= gun[lastgunindex[combo]].shotspeedup;
                gg[tocombo].dodgeup -= gun[lastgunindex[combo]].dodgeup;
                gg[tocombo].damageup -= gun[lastgunindex[combo]].damageup;
                gg[tocombo].hitup -= gun[lastgunindex[combo]].hitup;
                gg[tocombo].critup -= gun[lastgunindex[combo]].critup;
          //      MessageBox.Show(gg[tocombo].damageup.ToString());
          //      MessageBox.Show(tocombo.ToString());
                renewindex(combo);
                lastgunindex[tocombo] = index;
             //   MessageBox.Show(gun[lastgunindex[combo]].name);
            }
       //     gg[grid].critup -= lastcrit[grid];
        //    gg[grid].damageup -= lastdamage[grid];
        //    gg[grid].dodgeup -= lastdodge[grid];
         //   gg[grid].hitup -= lasthit[grid];
        //    gg[grid].shotspeedup -= lastshotspeed[grid];
        }
        
        private void Combo0_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
       //     gg[0].cleargg();
            int select = Combo0.SelectedIndex;

            double roothit = gun[select].hit;
            double rootdodge = gun[select].dodge;
            double rootdamage = gun[select].damage;
            double rootcrit = gun[select].crit;
            double rootshotspeed = gun[select].shotspeed;

            int nextselect = Combo1.SelectedIndex;

            if(nextselect!=-1)
            {
                othercombochange(nextselect, select, 4, 0, 1);
                othercombochange(select, nextselect, 6, 1, 0);
       //         changeeffect(1);
                renewindex(1);
            }

            nextselect = Combo3.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 8, 0, 3);
                othercombochange(select, nextselect, 2, 3, 0);
     //           changeeffect(3);
                renewindex(3);
            }


            nextselect = Combo4.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 7, 0, 4);
                othercombochange(select, nextselect, 3, 4, 0);
       //         changeeffect(4);
                renewindex(4);
            }

            renewindex(0);

        }

        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    gg[1].cleargg();
            int select = Combo1.SelectedIndex;

            double roothit = gun[select].hit;
            double rootdodge = gun[select].dodge;
            double rootdamage = gun[select].damage;
            double rootcrit = gun[select].crit;
            double rootshotspeed = gun[select].shotspeed;

            int nextselect = Combo0.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 6, 1, 0);
                othercombochange(select, nextselect, 4, 0, 1);
        //        changeeffect(0);
                renewindex(0);
            }

            nextselect = Combo2.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 4, 1, 2);
                othercombochange(select, nextselect, 6, 2, 1);
         //       changeeffect(2);
                renewindex(2);
            }

            nextselect = Combo3.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 9, 1, 3);
                othercombochange(select, nextselect, 1, 3, 1);
           //     changeeffect(3);
                renewindex(3);
            }

            nextselect = Combo4.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 8, 1, 4);
                othercombochange(select, nextselect, 2, 4, 1);
           //     changeeffect(4);
                renewindex(4);
            }

            nextselect = Combo5.SelectedIndex;

            if (nextselect != -1)
            {
                othercombochange(nextselect, select, 7, 1, 5);
                othercombochange(select, nextselect, 3, 5, 1);
            //    changeeffect(5);
                renewindex(5);
            }

            renewindex(1);
        }


    }
}
