﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;
using LayeredSolution.BusinessLayer;
using LayeredSolution.DataLayer;
using LayeredSolution.Szamlazo.EmployeeViews;

namespace LayeredSolution.Szamlazo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void termékekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var sampleContext = new SampleContext();
            //var productService = new ProductService(sampleContext);
            var lifetimeScope = Program.Container
                .BeginLifetimeScope();
            Form form = lifetimeScope.ResolveNamed<Form>("Products");
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.FormClosed += delegate
            {
                lifetimeScope.Dispose();
            };
        }

        private void rendelésekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var sampleContext = new SampleContext();
            //var orderService = new OrderService(sampleContext);
            var lifetimeScope = Program.Container.BeginLifetimeScope();
            Form form = lifetimeScope.ResolveNamed<Form>("Orders");
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.FormClosed += delegate
            {
                lifetimeScope.Dispose();
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (var lifestimeScope = Program.Container.BeginLifetimeScope())
            {
                var form = lifestimeScope.Resolve<LoginForm>();
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {

                }
                else
                {
                    Close();
                }
            }
        }

        private void felhasználókToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lifetimeScope = Program.Container.BeginLifetimeScope();
            var form = lifetimeScope.Resolve<EmployeeListForm>();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
            form.Closed += delegate
            {
                lifetimeScope.Dispose();
            };
        }
    }
}
