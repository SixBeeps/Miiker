namespace Miiker
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
            this.miiBody = new System.Windows.Forms.PictureBox();
            this.maleRButton = new System.Windows.Forms.RadioButton();
            this.femaleRButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.miiHead = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDefaultSkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCustomSkinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.miiBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miiHead)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // miiBody
            // 
            this.miiBody.Location = new System.Drawing.Point(45, 100);
            this.miiBody.Name = "miiBody";
            this.miiBody.Size = new System.Drawing.Size(100, 106);
            this.miiBody.TabIndex = 0;
            this.miiBody.TabStop = false;
            // 
            // maleRButton
            // 
            this.maleRButton.AutoSize = true;
            this.maleRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maleRButton.Location = new System.Drawing.Point(350, 50);
            this.maleRButton.Name = "maleRButton";
            this.maleRButton.Size = new System.Drawing.Size(48, 17);
            this.maleRButton.TabIndex = 1;
            this.maleRButton.TabStop = true;
            this.maleRButton.Text = "Male";
            this.maleRButton.UseVisualStyleBackColor = true;
            this.maleRButton.CheckedChanged += new System.EventHandler(this.maleRButton_CheckedChanged);
            // 
            // femaleRButton
            // 
            this.femaleRButton.AutoSize = true;
            this.femaleRButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.femaleRButton.Location = new System.Drawing.Point(350, 70);
            this.femaleRButton.Name = "femaleRButton";
            this.femaleRButton.Size = new System.Drawing.Size(59, 17);
            this.femaleRButton.TabIndex = 2;
            this.femaleRButton.TabStop = true;
            this.femaleRButton.Text = "Female";
            this.femaleRButton.UseVisualStyleBackColor = true;
            this.femaleRButton.CheckedChanged += new System.EventHandler(this.femaleRButton_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gender:";
            // 
            // miiHead
            // 
            this.miiHead.BackColor = System.Drawing.Color.Transparent;
            this.miiHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.miiHead.Image = global::Miiker.Properties.Resources.Head;
            this.miiHead.Location = new System.Drawing.Point(45, 35);
            this.miiHead.Name = "miiHead";
            this.miiHead.Size = new System.Drawing.Size(100, 97);
            this.miiHead.TabIndex = 4;
            this.miiHead.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skinToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // skinToolStripMenuItem
            // 
            this.skinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDefaultSkinToolStripMenuItem,
            this.loadCustomSkinToolStripMenuItem});
            this.skinToolStripMenuItem.Name = "skinToolStripMenuItem";
            this.skinToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.skinToolStripMenuItem.Text = "Skin";
            // 
            // loadDefaultSkinToolStripMenuItem
            // 
            this.loadDefaultSkinToolStripMenuItem.Name = "loadDefaultSkinToolStripMenuItem";
            this.loadDefaultSkinToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadDefaultSkinToolStripMenuItem.Text = "Load Default Skin";
            // 
            // loadCustomSkinToolStripMenuItem
            // 
            this.loadCustomSkinToolStripMenuItem.Name = "loadCustomSkinToolStripMenuItem";
            this.loadCustomSkinToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadCustomSkinToolStripMenuItem.Text = "Load Custom Skin...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 262);
            this.Controls.Add(this.miiHead);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.femaleRButton);
            this.Controls.Add(this.maleRButton);
            this.Controls.Add(this.miiBody);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Miiker";
            ((System.ComponentModel.ISupportInitialize)(this.miiBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miiHead)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox miiBody;
        private System.Windows.Forms.RadioButton maleRButton;
        private System.Windows.Forms.RadioButton femaleRButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox miiHead;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDefaultSkinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadCustomSkinToolStripMenuItem;
    }
}

