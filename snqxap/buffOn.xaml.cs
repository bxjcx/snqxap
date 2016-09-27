using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// <summary>
    /// buffOn.xaml 的交互逻辑
    /// </summary>
    public partial class buffOn : Window
    {

        public GunGrid[] gg { get; set; }

        public int[] select { get;set; }
        

        public buffOn()
        {
            InitializeComponent();
            baka();
        }

        public void baka()
        {
            MessageBox.Show("baka!!!");

        }


    }
}
