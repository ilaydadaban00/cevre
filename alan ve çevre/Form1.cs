using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alan_ve_çevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Kenar1, kenar2, çevre, alan;
            Kenar1 = Convert.ToInt32(txtKenar1.Text);
            kenar2 = Convert.ToInt32(txtKenar2.Text);
            alan = (Kenar1 + kenar2)*2;
            çevre = Kenar1 * kenar2;

            

            lblAlan.Text = alan.ToString(); 
            lblcevre.Text = çevre.ToString();    
        }
    }
}
