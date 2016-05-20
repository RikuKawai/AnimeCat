namespace AnimeCat {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrentTitle = new System.Windows.Forms.Label();
            this.listAnime = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.groupDetails = new System.Windows.Forms.GroupBox();
            this.webInfo = new System.Windows.Forms.WebBrowser();
            this.listID = new System.Windows.Forms.ListBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelAID = new System.Windows.Forms.Label();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentTitle
            // 
            this.CurrentTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentTitle.AutoSize = true;
            this.CurrentTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTitle.Location = new System.Drawing.Point(6, 16);
            this.CurrentTitle.Name = "CurrentTitle";
            this.CurrentTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CurrentTitle.Size = new System.Drawing.Size(176, 25);
            this.CurrentTitle.TabIndex = 0;
            this.CurrentTitle.Text = "Nothing Selected";
            this.CurrentTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listAnime
            // 
            this.listAnime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listAnime.FormattingEnabled = true;
            this.listAnime.ItemHeight = 16;
            this.listAnime.Location = new System.Drawing.Point(13, 29);
            this.listAnime.Name = "listAnime";
            this.listAnime.Size = new System.Drawing.Size(264, 628);
            this.listAnime.TabIndex = 1;
            this.listAnime.SelectedIndexChanged += new System.EventHandler(this.listAnime_SelectedIndexChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(509, 634);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(347, 634);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoad.Location = new System.Drawing.Point(428, 634);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 4;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(677, 29);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add Anime";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuery.Location = new System.Drawing.Point(347, 29);
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.Size = new System.Drawing.Size(324, 22);
            this.textBoxQuery.TabIndex = 7;
            this.textBoxQuery.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupDetails
            // 
            this.groupDetails.Controls.Add(this.webInfo);
            this.groupDetails.Controls.Add(this.CurrentTitle);
            this.groupDetails.Location = new System.Drawing.Point(347, 52);
            this.groupDetails.Name = "groupDetails";
            this.groupDetails.Size = new System.Drawing.Size(648, 576);
            this.groupDetails.TabIndex = 8;
            this.groupDetails.TabStop = false;
            this.groupDetails.Text = "Details";
            // 
            // webInfo
            // 
            this.webInfo.IsWebBrowserContextMenuEnabled = false;
            this.webInfo.Location = new System.Drawing.Point(6, 44);
            this.webInfo.MinimumSize = new System.Drawing.Size(20, 20);
            this.webInfo.Name = "webInfo";
            this.webInfo.ScriptErrorsSuppressed = true;
            this.webInfo.Size = new System.Drawing.Size(636, 526);
            this.webInfo.TabIndex = 1;
            // 
            // listID
            // 
            this.listID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listID.FormattingEnabled = true;
            this.listID.ItemHeight = 16;
            this.listID.Location = new System.Drawing.Point(283, 29);
            this.listID.Name = "listID";
            this.listID.Size = new System.Drawing.Size(58, 628);
            this.listID.TabIndex = 9;
            this.listID.SelectedIndexChanged += new System.EventHandler(this.listID_SelectedIndexChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(13, 10);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(27, 13);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Title";
            // 
            // labelAID
            // 
            this.labelAID.AutoSize = true;
            this.labelAID.Location = new System.Drawing.Point(280, 10);
            this.labelAID.Name = "labelAID";
            this.labelAID.Size = new System.Drawing.Size(50, 13);
            this.labelAID.TabIndex = 11;
            this.labelAID.Text = "Anime ID";
            // 
            // buttonErase
            // 
            this.buttonErase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonErase.Location = new System.Drawing.Point(590, 634);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(83, 23);
            this.buttonErase.TabIndex = 12;
            this.buttonErase.Text = "Erase File";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.Location = new System.Drawing.Point(679, 634);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 13;
            this.buttonAbout.Text = "About";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AnimeCat.Properties.Resources.tumblr_nezy8aVmYQ1r41iwko2_500;
            this.pictureBox1.Location = new System.Drawing.Point(921, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 638);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 677);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonErase);
            this.Controls.Add(this.labelAID);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listID);
            this.Controls.Add(this.groupDetails);
            this.Controls.Add(this.textBoxQuery);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listAnime);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "AnimeCat";
            this.groupDetails.ResumeLayout(false);
            this.groupDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CurrentTitle;
        private System.Windows.Forms.ListBox listAnime;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.GroupBox groupDetails;
        private System.Windows.Forms.ListBox listID;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelAID;
        private System.Windows.Forms.WebBrowser webInfo;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonAbout;
    }
}

