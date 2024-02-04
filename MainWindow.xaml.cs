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

namespace nfsExe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGameDownload_Click(object sender, EventArgs e)
        {
            frmGameDownload gd = new frmGameDownload();
            this.Close();
            gd.Show();
        }

        private void cboCarbon_Click(object sender, EventArgs e)
        {
            frmCarbon carb = new frmCarbon();
            this.Close();
            carb.Show();
        }

        private void cboUnderground_Click(object sender, EventArgs e)
        {
            frmUnderground under = new frmUnderground();
            this.Close();
            under.Show();
        }

        private void cboDiskInstructions_MouseOverDirectlyChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (cboDiskInstructions.IsDropDownOpen == true)
            {
                cboDiskInstructions.IsDropDownOpen = false;
            }
        }

        private void cboDiskInstructions_MouseEnter(object sender, EventArgs e)
        {
            cboDiskInstructions.IsDropDownOpen = true;
        }
    }
}
