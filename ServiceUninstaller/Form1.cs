using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ServiceUninstaller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUn_Click(object sender, EventArgs e)
        {
            WindowsServiceInstaller srv = new WindowsServiceInstaller();
            if (txtName.Text != "")
            {
                if (srv.UnInstallService(txtName.Text))
                    lblResult.Text = "OK";
                else
                    lblResult.Text = "Fail";
            }
            else
                lblResult.Text = "Null";
        }

    }
}
