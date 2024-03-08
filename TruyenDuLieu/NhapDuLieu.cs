using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruyenDuLieu
{
    public partial class NhapDuLieu : Form
    {
        //c3
        public string _text1 { get { return textBox1.Text; } }

        //c4
        public delegate void NhapDuLieuDelegate(TextBox textBox);
        public NhapDuLieu()
        {
            InitializeComponent();
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            //c1
            C1 c1= new C1(textBox1.Text);
            c1.Show();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            //c2
            C2 c2 = new C2();
            c2.nhap = this;
            c2.Show();

        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            //c4
            C3 c3 = new C3();
            c3._text = _text1;
            c3.Show();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            C4 c4= new C4();
            NhapDuLieuDelegate del = new NhapDuLieuDelegate(c4.getData);
            del(this.textBox1);
            c4.Show();
        }
    }
}
