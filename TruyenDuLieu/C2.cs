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
    public partial class C2 : Form
    {
        public C2()
        {
            InitializeComponent();
        }

        public NhapDuLieu nhap;

        private void C2_Load(object sender, EventArgs e)
        {
            label1.Text = nhap.textBox1.Text;
        }
    }
}
