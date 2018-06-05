using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            NoClass n = new NoClass();
            n.Show();
            this.Hide();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            YesClass y = new YesClass();
            y.Show();
            this.Hide();
        }

        private void btn_No_MouseHover(object sender, EventArgs e)
        {
            Random r = new Random();
            int x = r.Next(this.Size.Width - this.btn_No.Size.Width);
            int y = r.Next(52,520 - this.btn_No.Size.Height);

            btn_No.Location = new Point(x, y);

        }
    }
}
