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
    public partial class C4 : Form
    {
        public C4()
        {
            InitializeComponent();
        }

        public void getData(TextBox text)
        {
            label1.Text = text.Text;
        }
    }
}
