using System.Windows.Forms;

namespace linafromdota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лентина Полина", "Автор");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Эта функция дорабатывается", "Ошибка");
        }
    }
}