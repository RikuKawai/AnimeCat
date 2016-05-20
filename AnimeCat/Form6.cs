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
    public partial class Form6 : Form {
        public Form6() {
            InitializeComponent();
        }

        public int clicks = 0;

        private void pictureBox1_Click(object sender, EventArgs e) {
            if (clicks <= 2) {
                MessageBox.Show("No more easter eggs, go away.");
                clicks++;
            } else {
                MessageBox.Show("I lied, you found the last easter egg.");
                Form7 finalEgg = new Form7();
                finalEgg.Show();
            }
        }
    }
}
