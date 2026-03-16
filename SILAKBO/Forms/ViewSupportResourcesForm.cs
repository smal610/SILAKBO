using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SILAKBO
{
    public partial class ViewSupportResourcesForm : Form
    {
        public ViewSupportResourcesForm()
        {
            InitializeComponent();
        }

        private void ViewSupportResourcesForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Philippine Commission on Women");
            listBox1.Items.Add("DSWD Violence Against Women Desk");
            listBox1.Items.Add("PNP Women and Children Protection Desk");
            listBox1.Items.Add("National Center for Mental Health Hotline - 1553");
        }
    }
}
