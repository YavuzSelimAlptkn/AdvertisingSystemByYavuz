using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random sayi = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string FolderPath = Path.Combine(exePath, "Videos");
            string[] files = Directory.GetFiles(FolderPath);
            int sayi2;
            do
            {
                sayi2 = sayi.Next(1, files.Length);
            } while ("Video" + sayi2 + ".mp4" == Main.URL);
            string videoPath = Path.Combine(FolderPath, "Video" + sayi2 + ".mp4");
            Main.URL = videoPath;
            Main.BringToFront();
            Main.stretchToFit = true;
            Main.Ctlcontrols.play();
            timer1.Interval = 10000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            if (Main.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string FolderPath = Path.Combine(exePath, "Ads");
                string[] files = Directory.GetFiles(FolderPath);
                Random sayi = new Random();
                int sayi2 = sayi.Next(1, files.Length);
                Main.Ctlcontrols.pause();
                string videoPath = Path.Combine(FolderPath, "AD" + sayi2 + ".mp4");
                Advertising.URL = videoPath;
                Advertising.Ctlcontrols.play();
                Advertising.BringToFront();
                Advertising.stretchToFit = true;
            }
            else
            {
                string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string FolderPath = Path.Combine(exePath, "Videos");
                string[] files = Directory.GetFiles(FolderPath);
                int sayi2;
                do
                {
                    sayi2 = sayi.Next(1, files.Length);
                } while ("Video" + sayi2 + ".mp4" == Main.URL);
                string videoPath = Path.Combine(FolderPath, "Video" + sayi2 + ".mp4");
                Main.URL = videoPath;
                Main.BringToFront();
                Main.stretchToFit = true;
                Main.Ctlcontrols.play();
            }
            timer1.Interval = 5 * 60 * 1000;
            timer1.Start();
        }

        private void Main_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Main.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                Main.Ctlcontrols.pause();
                string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                string FolderPath = Path.Combine(exePath, "Videos");
                string[] files = Directory.GetFiles(FolderPath);
                int sayi2;
                do
                {
                    sayi2 = sayi.Next(1, files.Length);
                } while ("Video" + sayi2 + ".mp4" == Main.URL);
                string videoPath = Path.Combine(FolderPath, "Video" + sayi2 + ".mp4");
                Main.URL = videoPath;
                Main.BringToFront();
                Main.stretchToFit = true;
                Main.Ctlcontrols.play();
            }
        }

        private void Advertising_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (Advertising.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                if(Main.playState == WMPLib.WMPPlayState.wmppsStopped)
                {
                    string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
                    string FolderPath = Path.Combine(exePath, "Videos");
                    string[] files = Directory.GetFiles(FolderPath);
                    int sayi2;
                    do
                    {
                        sayi2 = sayi.Next(1, files.Length);
                    } while ("Video" + sayi2 + ".mp4" == Main.URL);
                    string videoPath = Path.Combine(FolderPath, "Video" + sayi2 + ".mp4");
                    Main.URL = videoPath;
                    Main.BringToFront();
                    Main.stretchToFit = true;
                    Main.Ctlcontrols.play();
                }
                else
                {
                    Main.Ctlcontrols.play();
                    Main.BringToFront();
                    Main.stretchToFit = true;
                    timer1.Start();
                }
            }
        }
    }
}
