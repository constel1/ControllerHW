using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerHW
{
    public partial class Timer : Form
    {
        
        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {
            label2.Text = Temp.subj.Name;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            var start = DateTime.UtcNow;

            var end = start.AddHours(Convert.ToDouble(Temp.subj.hour)).AddMinutes(Convert.ToDouble(Temp.subj.minut));

            var diff = TimeSpan.FromHours(Convert.ToDouble(Temp.subj.hour)) + TimeSpan.FromMinutes(Convert.ToDouble(Temp.subj.minut));
            while ((DateTime.UtcNow - start) < diff)
            {
                label1.Text = (diff - (DateTime.UtcNow - start)).ToString();
                await Task.Delay(1000);
            }
            SystemSounds.Beep.Play();
            Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point p = new Point(25, 117);
            label1.Location = p;
            
            timer1_Tick(sender, e);

        }

        
    }
}
