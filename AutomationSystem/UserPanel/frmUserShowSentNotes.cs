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
    public partial class frmUserShowSentNotes : Form
    {
        public frmUserShowSentNotes()
        {
            InitializeComponent();
        }

        private void frmUserShowSentNotes_Load(object sender, EventArgs e)
        {
            this.Left = 10;
            this.Top = 160;
        }
    }
}
