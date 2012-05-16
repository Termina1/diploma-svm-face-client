using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace svmFaceClient
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void selectPath_Click(object sender, EventArgs e) {
            flistingFolder.ShowDialog();
            if (Directory.Exists(flistingFolder.SelectedPath)) {
                var lister = new Lister(flistingFolder.SelectedPath);
                lister.list();
            }
        }
    }
}
