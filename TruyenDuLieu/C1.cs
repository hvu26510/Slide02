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
    public partial class C1 : Form
    {
        public C1()
        {
            InitializeComponent();
        }
        // cach 1
        public C1(string text)
        {
            InitializeComponent();
            label1.Text= text;
        }
    }
}
