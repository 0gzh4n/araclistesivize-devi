﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace araclistesivizeödevi
{
    public partial class Frmcars : Form
    {
        public Frmcars()
        {
            InitializeComponent();
        }
        public cars cars = null;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            propertyGrid1.SelectedObject = cars;
        }

        private void OkClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void iptalclick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
