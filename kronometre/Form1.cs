using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace kronometre
{
    public partial class Form1 : Form
    {
        /*
         *  mersin üniversitesi bilgisayar programcılığı
         *  Project Name : kronometre
         *  User: Mohamad Younes
         *  GitHub: https://github.com/mohammedadiga
         */

        public Form1()
        {
            InitializeComponent();
        }


        // sayacı durdur

        Stopwatch stopwatch;    

        private void Form1_Load(object sender, EventArgs e)
        {
            // Yeni sayacı Ekle
            stopwatch = new Stopwatch();
        }

        // sayacı Ayarlar

        private void timer1_Tick(object sender, EventArgs e)
        {
            label.Text = string.Format("{0:hh\\:mm\\:ss\\:ff}", stopwatch.Elapsed);
        }

        // Düğme Başlat

        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Başla") 
            { 
                stopwatch.Start();
                Start.Text = "Durdur";
                Save.Enabled = false; 
            }
            else 
            { 
                stopwatch.Stop(); 
                Start.Text = "Başla"; 
                Save.Enabled = true; 
            }
        }

        // Düğme Tekrar

        private void Again_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            Start.Text = "Başla";
            listBox.Items.Clear();
        }

        // Düğme Tekrar

        private void Save_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(label.Text);
            Save.Enabled = false;
        }

        // Düğme Çıkış

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Düğme GitHub

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/mohammedadiga/XO_Game");
        }
    }
}
