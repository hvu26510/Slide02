﻿using System;
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
    public partial class C3 : Form
    {
        public C3()
        {
            InitializeComponent();
        }

        public string _text { set { label1.Text = value; } }

    }
}
