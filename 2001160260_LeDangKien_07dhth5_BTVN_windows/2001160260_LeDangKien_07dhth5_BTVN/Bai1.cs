using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001160260_LeDangKien_07dhth5_BTVN
{
    public partial class Bai1 : Form
    {
        int cleft=1;
        public Bai1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewTextbox();
        }
        private System.Windows.Forms.TextBox AddNewTextbox()
        {
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            txt.Top = cleft * 25;
            txt.Left = 100;
            txt.Text = "TextBox" + this.cleft.ToString();
            cleft = cleft + 1;
            return txt;
        }
    }
}
