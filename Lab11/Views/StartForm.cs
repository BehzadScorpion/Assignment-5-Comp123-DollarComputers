﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 
 * Last Modified: 8/16/2019-7:20PM
*/
namespace DollarComputers.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartANewOrderButton_Click(object sender, EventArgs e)
        {
            Program.selectform.Show();
            this.Hide();
        }

        private void LoadASavedOrderButton_Click(object sender, EventArgs e)
        {
            Program.productinfoForm.Show();
            this.Hide();
        }

        private void ExitTheProgramButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
