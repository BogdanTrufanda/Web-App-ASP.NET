namespace ClientWCF
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.insertPic = new System.Windows.Forms.Button();
            this.deletePic = new System.Windows.Forms.Button();
            this.checkDb = new System.Windows.Forms.Button();
            this.folderSee = new System.Windows.Forms.Button();
            this.seePicture = new System.Windows.Forms.PictureBox();
            this.selectAll = new System.Windows.Forms.Button();
            this.getColumnNames = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.updatePic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.seePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(34, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(134, 22);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox4.Location = new System.Drawing.Point(312, 12);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox4.Size = new System.Drawing.Size(358, 426);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(33, 213);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(134, 22);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(33, 262);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(135, 22);
            this.textBox6.TabIndex = 17;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // insertPic
            // 
            this.insertPic.Location = new System.Drawing.Point(51, 24);
            this.insertPic.Name = "insertPic";
            this.insertPic.Size = new System.Drawing.Size(93, 47);
            this.insertPic.TabIndex = 18;
            this.insertPic.Text = "Insert Picture";
            this.insertPic.UseVisualStyleBackColor = true;
            this.insertPic.Click += new System.EventHandler(this.insertPic_Click);
            // 
            // deletePic
            // 
            this.deletePic.Location = new System.Drawing.Point(51, 97);
            this.deletePic.Name = "deletePic";
            this.deletePic.Size = new System.Drawing.Size(93, 48);
            this.deletePic.TabIndex = 19;
            this.deletePic.Text = "Delete Picture";
            this.deletePic.UseVisualStyleBackColor = true;
            this.deletePic.Click += new System.EventHandler(this.deletePic_Click);
            // 
            // checkDb
            // 
            this.checkDb.Location = new System.Drawing.Point(182, 24);
            this.checkDb.Name = "checkDb";
            this.checkDb.Size = new System.Drawing.Size(108, 47);
            this.checkDb.TabIndex = 20;
            this.checkDb.Text = "Check Database";
            this.checkDb.UseVisualStyleBackColor = true;
            this.checkDb.Click += new System.EventHandler(this.checkDb_Click);
            // 
            // folderSee
            // 
            this.folderSee.Location = new System.Drawing.Point(183, 97);
            this.folderSee.Name = "folderSee";
            this.folderSee.Size = new System.Drawing.Size(108, 48);
            this.folderSee.TabIndex = 21;
            this.folderSee.Text = "Folder Browsing";
            this.folderSee.UseVisualStyleBackColor = true;
            this.folderSee.Click += new System.EventHandler(this.folderSee_Click);
            // 
            // seePicture
            // 
            this.seePicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.seePicture.Location = new System.Drawing.Point(676, 12);
            this.seePicture.Name = "seePicture";
            this.seePicture.Size = new System.Drawing.Size(387, 426);
            this.seePicture.TabIndex = 22;
            this.seePicture.TabStop = false;
            this.seePicture.Click += new System.EventHandler(this.seePicture_Click);
            // 
            // selectAll
            // 
            this.selectAll.Location = new System.Drawing.Point(51, 356);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(75, 23);
            this.selectAll.TabIndex = 23;
            this.selectAll.Text = "SelectAll";
            this.selectAll.UseVisualStyleBackColor = true;
            this.selectAll.Click += new System.EventHandler(this.selectAll_Click);
            // 
            // getColumnNames
            // 
            this.getColumnNames.Location = new System.Drawing.Point(165, 356);
            this.getColumnNames.Name = "getColumnNames";
            this.getColumnNames.Size = new System.Drawing.Size(129, 23);
            this.getColumnNames.TabIndex = 24;
            this.getColumnNames.Text = "GetColumnNames";
            this.getColumnNames.UseVisualStyleBackColor = true;
            this.getColumnNames.Click += new System.EventHandler(this.getColumnNames_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(187, 212);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(107, 23);
            this.select.TabIndex = 25;
            this.select.Text = "Select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(187, 261);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(107, 23);
            this.search.TabIndex = 26;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // updatePic
            // 
            this.updatePic.Location = new System.Drawing.Point(189, 169);
            this.updatePic.Name = "updatePic";
            this.updatePic.Size = new System.Drawing.Size(105, 23);
            this.updatePic.TabIndex = 29;
            this.updatePic.Text = "UpdatePic";
            this.updatePic.UseVisualStyleBackColor = true;
            this.updatePic.Click += new System.EventHandler(this.updatePic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1075, 450);
            this.Controls.Add(this.updatePic);
            this.Controls.Add(this.search);
            this.Controls.Add(this.select);
            this.Controls.Add(this.getColumnNames);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.seePicture);
            this.Controls.Add(this.folderSee);
            this.Controls.Add(this.checkDb);
            this.Controls.Add(this.deletePic);
            this.Controls.Add(this.insertPic);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button insertPic;
        private System.Windows.Forms.Button deletePic;
        private System.Windows.Forms.Button checkDb;
        private System.Windows.Forms.Button folderSee;
        private System.Windows.Forms.PictureBox seePicture;
        private System.Windows.Forms.Button selectAll;
        private System.Windows.Forms.Button getColumnNames;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button updatePic;
    }
}

