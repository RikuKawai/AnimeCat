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
    public partial class EasterEgg : Form {
        public EasterEgg() {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            Form3 easterEgg2 = new Form3();
            easterEgg2.Show();
        }
    }
}
