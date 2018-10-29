using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mødeplanlægger_CS
{
    public partial class Form3 : Form
    {
        Form2 f2;
        Form4 f4;

        public Form3(Form2 _f2)
        {
            this.f2 = _f2;
            InitializeComponent();
        }

        private void showForm4()
        {
            if (f4 == null)
                f4 = new Form4(this);
            f4.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void nextButton_Click_1(object sender, EventArgs e)
        {
            showForm4();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            f2.Show();
        }
    }
}
