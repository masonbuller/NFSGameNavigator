using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for frmGameDownload.xaml
    /// </summary>
    public partial class frmGameDownload : Window
    {
        private List<string> images;

        private int imageIndex = 0;
        public frmGameDownload()
        {
            InitializeComponent();
            images = new List<string>
            {
                @"C:\NeedForSpeed\nfsExe\Images\THE NEED FOR SPEED.png",
                @"C:\NeedForSpeed\nfsExe\Images\HOT PURSUIT.png",
                @"C:\NeedForSpeed\nfsExe\Images\HIGH STAKES.png",
                @"C:\NeedForSpeed\nfsExe\Images\PORSCHE UNLEASHED.png",
                @"C:\NeedForSpeed\nfsExe\Images\HOT PURSUIT 2.png",
                @"C:\NeedForSpeed\nfsExe\Images\UNDERGROUND.png",
                @"C:\NeedForSpeed\nfsExe\Images\UNDERGROUND 2.png",
                @"C:\NeedForSpeed\nfsExe\Images\MOST WANTED.png",
                @"C:\NeedForSpeed\nfsExe\Images\CARBON.png",
                @"C:\NeedForSpeed\nfsExe\Images\PROSTREET.png",
                @"C:\NeedForSpeed\nfsExe\Images\UNDERCOVER.png",
                @"C:\NeedForSpeed\nfsExe\Images\SHIFT.png",
                @"C:\NeedForSpeed\nfsExe\Images\SHIFT 2 UNLEASHED.png",
                @"C:\NeedForSpeed\nfsExe\Images\THE RUN.png"
            };
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Close();
            if (imageIndex == 0)
            { 
                Process.Start("explorer.exe", @"D:\GAMES\THE NEED FOR SPEED");
            }
            else if (imageIndex == 1)
            {
                Process.Start("explorer.exe", @"D:\GAMES\NFS3 HOT PURSUIT");
            }
            else if (imageIndex == 2)
            {
                Process.Start("explorer.exe", @"D:\GAMES\HIGH STAKES");
            }
            else if (imageIndex == 3)
            {
                Process.Start("explorer", @"D:\GAMES\PORSCHE UNLEASHED");
            }
            else if (imageIndex == 4)
            {
                Process.Start("explorer", @"D:\GAMES\HOT PURSUIT 2");
            }
            else if (imageIndex == 5)
            {
                Process.Start("explorer", @"D:\GAMES\UNDERGROUND");
            }
            else if (imageIndex == 6)
            {
                Process.Start("explorer", @"D:\GAMES\UNDERGROUND 2");
            }
            else if (imageIndex == 7)
            {
                Process.Start("explorer", @"D:\GAMES\MOST WANTED");
            }
            else if (imageIndex == 8)
            {
                Process.Start("explorer", @"D:\GAMES\CARBON");
            }
            else if (imageIndex == 9)
            {
                Process.Start("explorer", @"D:\GAMES\PROSTREET");
            }
            else if (imageIndex == 10)
            {
                Process.Start("explorer", @"D:\GAMES\UNDERCOVER");
            }
            else if (imageIndex == 11)
            {
                Process.Start("explorer", @"D:\GAMES\SHIFT");
            }
            else if (imageIndex == 12)
            {
                Process.Start("explorer", @"D:\GAMES\SHIFT 2 UNLEASHED");
            }
            else if (imageIndex == 13)
            {
                Process.Start("explorer", @"D:\GAMES\THE RUN");
            }
            else
            {
                MessageBox.Show("Index out of range.", "ERROR");
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            imageIndex--;
            MoveImage();
        }
        private void Next_Click(object sender, EventArgs e)
        {
            imageIndex++;
            MoveImage();
        }
        private void MoveImage()
        {
            //if index out of range, start from end again
            if (imageIndex < 0)
                imageIndex = images.Count - 1;

            //if index out of range, start from 0 again
            if (imageIndex >= images.Count)
                imageIndex = 0;

            imgSlide.Source = new BitmapImage(new Uri(images[imageIndex]));
        }

    }
}
