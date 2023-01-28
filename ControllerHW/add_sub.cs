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
    public partial class add_sub : Form
    {
        public add_sub()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==null)
            {
                MessageBox.Show("Не введён предмет");
                return;
            }
            Defual.D_Sub.Add(textBox1.Text);
            this.Close();
        }
    }
}
