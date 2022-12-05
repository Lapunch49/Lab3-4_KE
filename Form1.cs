using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_4_KE
{
    public partial class Lab4 : Form
    {
        public Lab4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
     
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            Form new_frm = new Q1();
            new_frm.Show();
            this.Visible = false;
        }
    }
}
