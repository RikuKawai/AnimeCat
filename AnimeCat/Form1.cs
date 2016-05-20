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
using System.Xml;

namespace AnimeCat {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        public int currentIndex;
        public string currentTitle;
        public string currentAID = "null";

        public string query;
        public string animeID;

        public Uri infoUri;

        public bool valid;

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void buttonExit_Click(object sender, EventArgs e) {
            Environment.Exit(1);
        }

        private void SaveList() {
            System.IO.StreamWriter titleOut = new System.IO.StreamWriter("userdata\\titles.neko");
            System.IO.StreamWriter idOut = new System.IO.StreamWriter("userdata\\ids.neko");
                        
            foreach (var item in listAnime.Items) {
                titleOut.WriteLine(item.ToString());
            }
            titleOut.Close();
            foreach (var item in listID.Items) {
                idOut.WriteLine(item.ToString());
            }
            idOut.Close();
            MessageBox.Show("Save Successful!");
        }

        private void LoadList() {
            int counterTitle = 0;
            string lineTitle;

            // Read the file and add it line by line.
            System.IO.StreamReader titleIn =
               new System.IO.StreamReader("userdata\\titles.neko");
            while ((lineTitle = titleIn.ReadLine()) != null) {
                listAnime.Items.Add(lineTitle);
                counterTitle++;
            } titleIn.Close();

            int counterID = 0;
            string lineID;

            // Read the file and add it line by line.
            System.IO.StreamReader idIn =
               new System.IO.StreamReader("userdata\\ids.neko");
            while ((lineID = idIn.ReadLine()) != null) {
                listID.Items.Add(lineID);
                counterID++;
            } idIn.Close();
            MessageBox.Show("Load Successful!");
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            SaveList();
        }

        private void buttonLoad_Click(object sender, EventArgs e) {
            LoadList();
        }

        private void buttonAdd_Click(object sender, EventArgs e) {
            QueryID();
            AddAnime();
        }

        private void AddAnime() {
            if (valid == true) {
                listAnime.Items.Add(textBoxQuery.Text);
                textBoxQuery.Text = "";
            } else {
                textBoxQuery.Text = "";
            } 
        }

        private void QueryID() {
            query = textBoxQuery.Text;
            
            //Load the entire DOM into memory
            XmlDocument doc = new XmlDocument();
            doc.Load("data\\database.xml");

            //xpath stuff doesn;t work properly without an ns manager
            XmlNamespaceManager nsMgr = new XmlNamespaceManager(doc.NameTable);
            nsMgr.AddNamespace("x", "urn:riku");

            String xpath = "//title[text() = \"" + query + "\"]/..";
            XmlNodeList nodes = doc.DocumentElement.SelectNodes(xpath, nsMgr);

            foreach (XmlNode node in nodes) {
                animeID = node.Attributes["aid"] != null ? node.Attributes["aid"].Value : null;
            }
            if (listID.Items.Contains(animeID)) {
                MessageBox.Show("Invalid Title! Item might already be in the list. Warning: Titles are cAsE sEnSiTiVe");
                valid = false;
            } else {
                listID.Items.Add(animeID);
                valid = true;
            } 
        }

        private void listAnime_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateInfoTitle();
        }

        private void UpdateInfoTitle() {
            currentTitle = listAnime.SelectedItem.ToString();
            CurrentTitle.Text = currentTitle;
            currentIndex = listAnime.SelectedIndex;
            listID.SelectedIndex = currentIndex;
            currentAID = listID.SelectedItem.ToString();
            infoUri = new Uri("http://anidb.net/perl-bin/animedb.pl?show=anime&aid=" + currentAID, UriKind.Absolute);
            webInfo.Url = infoUri;
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show(System.Convert.ToString(infoUri));
        }

        private void listID_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateInfoID();
        }

        private void UpdateInfoID() {
            currentIndex = listID.SelectedIndex;
            listAnime.SelectedIndex = currentIndex;
            currentTitle = listAnime.SelectedItem.ToString();
            CurrentTitle.Text = currentTitle;
            currentAID = listID.SelectedItem.ToString();
            infoUri = new Uri("http://anidb.net/perl-bin/animedb.pl?show=anime&aid=" + currentAID, UriKind.Absolute);
            webInfo.Url = infoUri;
        }

        private void buttonErase_Click(object sender, EventArgs e) {
            EraseFiles();
        }

        private void EraseFiles() {
            File.Delete("userdata\\titles.neko");
            File.Delete("userdata\\ids.neko");
        }

        private void button1_Click_1(object sender, EventArgs e) {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            EasterEgg easterEgg = new EasterEgg();
            easterEgg.Show();
        }
    }
}
