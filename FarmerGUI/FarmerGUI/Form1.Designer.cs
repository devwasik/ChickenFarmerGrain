namespace FarmerGUI
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.readMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rBchickennorth = new System.Windows.Forms.RadioButton();
            this.rBgrainnorth = new System.Windows.Forms.RadioButton();
            this.rBfoxnorth = new System.Windows.Forms.RadioButton();
            this.rBfarmernorth = new System.Windows.Forms.RadioButton();
            this.rBfarmersouth = new System.Windows.Forms.RadioButton();
            this.rBfoxsouth = new System.Windows.Forms.RadioButton();
            this.rBgrainsouth = new System.Windows.Forms.RadioButton();
            this.rBchickensouth = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.movenorth = new System.Windows.Forms.Button();
            this.movesouth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FarmerGUI.Properties.Resources.Winding_River_1116233643;
            this.pictureBox1.Location = new System.Drawing.Point(245, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.instructionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitGameToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitGameToolStripMenuItem
            // 
            this.exitGameToolStripMenuItem.Name = "exitGameToolStripMenuItem";
            this.exitGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitGameToolStripMenuItem.Text = "Exit Game";
            this.exitGameToolStripMenuItem.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readMeToolStripMenuItem});
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // readMeToolStripMenuItem
            // 
            this.readMeToolStripMenuItem.Name = "readMeToolStripMenuItem";
            this.readMeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.readMeToolStripMenuItem.Text = "Read me";
            this.readMeToolStripMenuItem.Click += new System.EventHandler(this.readMeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // authorToolStripMenuItem
            // 
            this.authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            this.authorToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.authorToolStripMenuItem.Text = "Author";
            this.authorToolStripMenuItem.Click += new System.EventHandler(this.authorToolStripMenuItem_Click);
            // 
            // rBchickennorth
            // 
            this.rBchickennorth.AutoSize = true;
            this.rBchickennorth.Location = new System.Drawing.Point(48, 80);
            this.rBchickennorth.Name = "rBchickennorth";
            this.rBchickennorth.Size = new System.Drawing.Size(64, 17);
            this.rBchickennorth.TabIndex = 2;
            this.rBchickennorth.TabStop = true;
            this.rBchickennorth.Text = "Chicken";
            this.rBchickennorth.UseVisualStyleBackColor = true;
            // 
            // rBgrainnorth
            // 
            this.rBgrainnorth.AutoSize = true;
            this.rBgrainnorth.Location = new System.Drawing.Point(48, 117);
            this.rBgrainnorth.Name = "rBgrainnorth";
            this.rBgrainnorth.Size = new System.Drawing.Size(50, 17);
            this.rBgrainnorth.TabIndex = 3;
            this.rBgrainnorth.TabStop = true;
            this.rBgrainnorth.Text = "Grain";
            this.rBgrainnorth.UseVisualStyleBackColor = true;
            // 
            // rBfoxnorth
            // 
            this.rBfoxnorth.AutoSize = true;
            this.rBfoxnorth.Location = new System.Drawing.Point(48, 154);
            this.rBfoxnorth.Name = "rBfoxnorth";
            this.rBfoxnorth.Size = new System.Drawing.Size(42, 17);
            this.rBfoxnorth.TabIndex = 4;
            this.rBfoxnorth.TabStop = true;
            this.rBfoxnorth.Text = "Fox";
            this.rBfoxnorth.UseVisualStyleBackColor = true;
            // 
            // rBfarmernorth
            // 
            this.rBfarmernorth.AutoSize = true;
            this.rBfarmernorth.Location = new System.Drawing.Point(48, 192);
            this.rBfarmernorth.Name = "rBfarmernorth";
            this.rBfarmernorth.Size = new System.Drawing.Size(57, 17);
            this.rBfarmernorth.TabIndex = 5;
            this.rBfarmernorth.TabStop = true;
            this.rBfarmernorth.Text = "Farmer";
            this.rBfarmernorth.UseVisualStyleBackColor = true;
            // 
            // rBfarmersouth
            // 
            this.rBfarmersouth.AutoSize = true;
            this.rBfarmersouth.Location = new System.Drawing.Point(664, 192);
            this.rBfarmersouth.Name = "rBfarmersouth";
            this.rBfarmersouth.Size = new System.Drawing.Size(57, 17);
            this.rBfarmersouth.TabIndex = 9;
            this.rBfarmersouth.TabStop = true;
            this.rBfarmersouth.Text = "Farmer";
            this.rBfarmersouth.UseVisualStyleBackColor = true;
            // 
            // rBfoxsouth
            // 
            this.rBfoxsouth.AutoSize = true;
            this.rBfoxsouth.Location = new System.Drawing.Point(664, 154);
            this.rBfoxsouth.Name = "rBfoxsouth";
            this.rBfoxsouth.Size = new System.Drawing.Size(42, 17);
            this.rBfoxsouth.TabIndex = 8;
            this.rBfoxsouth.TabStop = true;
            this.rBfoxsouth.Text = "Fox";
            this.rBfoxsouth.UseVisualStyleBackColor = true;
            // 
            // rBgrainsouth
            // 
            this.rBgrainsouth.AutoSize = true;
            this.rBgrainsouth.Location = new System.Drawing.Point(664, 117);
            this.rBgrainsouth.Name = "rBgrainsouth";
            this.rBgrainsouth.Size = new System.Drawing.Size(50, 17);
            this.rBgrainsouth.TabIndex = 7;
            this.rBgrainsouth.TabStop = true;
            this.rBgrainsouth.Text = "Grain";
            this.rBgrainsouth.UseVisualStyleBackColor = true;
            // 
            // rBchickensouth
            // 
            this.rBchickensouth.AutoSize = true;
            this.rBchickensouth.Location = new System.Drawing.Point(664, 80);
            this.rBchickensouth.Name = "rBchickensouth";
            this.rBchickensouth.Size = new System.Drawing.Size(64, 17);
            this.rBchickensouth.TabIndex = 6;
            this.rBchickensouth.TabStop = true;
            this.rBchickensouth.Text = "Chicken";
            this.rBchickensouth.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(25, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 212);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "North Bank";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(603, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 212);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "South Bank";
            // 
            // movenorth
            // 
            this.movenorth.Location = new System.Drawing.Point(48, 258);
            this.movenorth.Name = "movenorth";
            this.movenorth.Size = new System.Drawing.Size(75, 23);
            this.movenorth.TabIndex = 12;
            this.movenorth.Text = "Move";
            this.movenorth.UseVisualStyleBackColor = true;
            this.movenorth.Click += new System.EventHandler(this.movenorth_Click);
            // 
            // movesouth
            // 
            this.movesouth.Location = new System.Drawing.Point(664, 257);
            this.movesouth.Name = "movesouth";
            this.movesouth.Size = new System.Drawing.Size(75, 23);
            this.movesouth.TabIndex = 13;
            this.movesouth.Text = "Move";
            this.movesouth.UseVisualStyleBackColor = true;
            this.movesouth.Click += new System.EventHandler(this.movesouth_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 338);
            this.Controls.Add(this.movesouth);
            this.Controls.Add(this.movenorth);
            this.Controls.Add(this.rBfarmersouth);
            this.Controls.Add(this.rBfoxsouth);
            this.Controls.Add(this.rBgrainsouth);
            this.Controls.Add(this.rBchickensouth);
            this.Controls.Add(this.rBfarmernorth);
            this.Controls.Add(this.rBfoxnorth);
            this.Controls.Add(this.rBgrainnorth);
            this.Controls.Add(this.rBchickennorth);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Farmer Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem readMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorToolStripMenuItem;
        private System.Windows.Forms.RadioButton rBchickennorth;
        private System.Windows.Forms.RadioButton rBgrainnorth;
        private System.Windows.Forms.RadioButton rBfoxnorth;
        private System.Windows.Forms.RadioButton rBfarmernorth;
        private System.Windows.Forms.RadioButton rBfarmersouth;
        private System.Windows.Forms.RadioButton rBfoxsouth;
        private System.Windows.Forms.RadioButton rBgrainsouth;
        private System.Windows.Forms.RadioButton rBchickensouth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button movenorth;
        private System.Windows.Forms.Button movesouth;

    }
}

