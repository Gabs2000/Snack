﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oasis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login Menu = new Login();
            this.Hide();
            Menu.Show();
        }

        private void Hora_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu toMenu = new Menu();
            this.Hide();
            toMenu.Show();
        }
    }
}
