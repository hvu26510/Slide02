﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //check user va password
            if (txtUser.Text == "a" && txtPass.Text == "123")
            {
                HomePage hp = new HomePage();
                hp.FormClosing += (a, b) => this.Show();
                hp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tt");
            }

        }
    }
}
