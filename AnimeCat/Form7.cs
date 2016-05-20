using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeCat {
    public partial class Form7 : Form {
        public Form7() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            MessageBox.Show("I warned you this was the last one.");
            Environment.Exit(1);
        }
    }
}
