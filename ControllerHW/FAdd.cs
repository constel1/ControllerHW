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
using static System.Windows.Forms.DataFormats;


namespace ControllerHW
{
    public partial class FAdd : Form
    {
        
        Subject s = new Subject();
        public FAdd()       {
            
            
            InitializeComponent();
        }
        
        private void FA_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(Defual.D_Sub.ToArray());
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

           

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
                return;
            }
            
            s.minut = Convert.ToInt32(textBox3.Text);      
           
            s.Name = comboBox1.SelectedItem.ToString();            
            s.hour = Convert.ToInt32(textBox1.Text);
            
            if (s.minut != null && s.minut != null && s.Name != null)
            {
                
                Collec.subs.Add(s);                
                this.Close();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            add_sub fl = new add_sub();
            fl.ShowDialog();            
            comboBox1.Items.AddRange(Defual.D_Sub.ToArray());
        }

        private void btn_sbros_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox3.Text = "";
        }
    }
}




