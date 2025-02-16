﻿using System;
using System.Windows.Forms;
using Sudoroyal.Models;

namespace Sudoroyal.Views.Popup
{
    public partial class ProgressQuit : Form
    {
        // -- Model
        private GUI gui = new GUI();

        public ProgressQuit()
        {
            InitializeComponent();
        }

        // -- Hover
        private void btnYay_MouseHover(object sender, EventArgs e)
        {
            gui.switchState(btnYay, btnYayActive);
        }

        // -- Leave
        private void btnYayActive_MouseLeave(object sender, EventArgs e)
        {
            gui.switchState(btnYayActive, btnYay);
        }

        // -- Click
        private void btnYayActive_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
