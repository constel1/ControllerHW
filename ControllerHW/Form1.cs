using Model;

namespace ControllerHW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            FAdd fa = new FAdd();
            
            fa.ShowDialog();
            
        }

        

        private void btn_exit_Click(object sender, EventArgs e)
        {
            SubgectsForm sub = new SubgectsForm();
            sub.Update();
            sub.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}