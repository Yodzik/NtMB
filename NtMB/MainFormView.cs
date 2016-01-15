using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NtMB
{
    public partial class MainFormView : Form
    {
        public MainFormView()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = Settings.WindowPositionMain;
        }
    }
}
