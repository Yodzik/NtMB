using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NtMB.View
{
    public partial class MainFormView : Form, IMainView
    {
        public MainFormView()
        {
            InitializeComponent();
        }

        private void MainFormView_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Settings.WIN_MAIN_SIZE_MAX;
            this.MinimumSize = Settings.WIN_MAIN_SIZE_MIN;
            RelocateMainWindow();
        }

        public void RelocateMainWindow()
        {
            this.Location = Settings.WindowPositionMain;
            this.Width = Settings.WindowMainWidth;
            this.Height = Settings.WindowMainHeight;
        }
    }
}
