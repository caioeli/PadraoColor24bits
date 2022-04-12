using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadrãoColor24bits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void atualizarcor()
        {
            lblcores.BackColor = Color.FromArgb(
                hdbred.Value,
                hsbgreen.Value,
                hsbblue.Value

                );
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hdbred_Scroll(object sender, ScrollEventArgs e)
        {
            tbred.Text = hdbred.Value.ToString();
            atualizarcor();
            atualizarcornum();
        }

        private void hsbgreen_Scroll(object sender, ScrollEventArgs e)
        {
            tbgreen.Text = hsbgreen.Value.ToString();
            atualizarcor();
            atualizarcornum();
        }

        private void hsbblue_Scroll(object sender, ScrollEventArgs e)
        {
            tbblue.Text = hsbblue.Value.ToString();
            atualizarcor();
            atualizarcornum();
        }
    }
}
