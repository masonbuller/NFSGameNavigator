using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace nfsExe
{
    /// <summary>
    /// Interaction logic for frmCarbon.xaml
    /// </summary>
    public partial class frmCarbon : Window
    {
        public frmCarbon()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.Start("explorer.exe", @"D:\DISKS\CARBON DISK");
        }
    }
}
