﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationSystem.UserPanel
{
    public partial class frmUserSendEmail : Form
    {
        public frmUserSendEmail()
        {
            InitializeComponent();
        }

        private void frmUserSendEmail_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
