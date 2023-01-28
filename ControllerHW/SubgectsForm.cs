using Microsoft.VisualBasic.ApplicationServices;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllerHW
{
    public partial class SubgectsForm : Form
    {
        public SubgectsForm()
        {
            InitializeComponent();
            
        }
        
        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Subject? s = listBox1.SelectedItem as Subject;
            if (s != null)
            {
                label1.Text = $" Предмет: {s.Name}";
                label2.Text = $" Часы - {s.hour+(s.minut/60)}\n Минуты - {(s.minut >60 ? (s.minut - (60* (s.minut / 60))): s.minut)}";
            }    
                                                  
            
        }
       
        private void SubgectsForm_Load(object sender, EventArgs e)
        {
            listBox1.DisplayMember = nameof(Subject.Name);
            foreach (Subject sub in Collec.subs)
            {
                listBox1.Items.Add(sub);
            }
            
            label1.Text = "Время";
            label2.Text = "Предмет";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == null)
            {
                MessageBox.Show("Не выбран элемент");
                return;
            }
            Subject? s = listBox1.SelectedItem as Subject;
            if (s == null) { return; }
            listBox1.Items.Clear();
            Collec.subs.Remove(s); 
            foreach (Subject sub in Collec.subs) 
            {
                listBox1.Items.Add(sub);
            }
            
            label1.Text = " ";
            label2.Text = " ";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) 
            {
                MessageBox.Show("Не выбран элемент");
                return;
            }
            Subject subject = listBox1.SelectedItem as Subject; if (subject == null) { return; }
            Temp.subj = subject;
            listBox1.Items.Remove(subject);
            Collec.subs.Remove(subject);    
            label1.Text = " ";
            label2.Text = " ";
            Timer t = new Timer();  
            t.Show();

        }
    }
}
