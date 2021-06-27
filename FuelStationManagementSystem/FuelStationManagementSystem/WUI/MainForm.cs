﻿using FuelStationManagementSystem.WUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStationManagementSystem {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        #region Events

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            AddCustomer();
        }

        #endregion

        #region methods

        private void AddCustomer() {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();

        }

        #endregion


    }
}
