namespace BidandBuy
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uSERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bUYERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONTACTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem,
            this.rEGISTERToolStripMenuItem,
            this.cONTACTToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(748, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(317, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem,
            this.uSERToolStripMenuItem,
            this.sELLERToolStripMenuItem});
            this.lOGINToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            this.lOGINToolStripMenuItem.Click += new System.EventHandler(this.lOGINToolStripMenuItem_Click);
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.aDMINToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            this.aDMINToolStripMenuItem.Click += new System.EventHandler(this.aDMINToolStripMenuItem_Click);
            // 
            // uSERToolStripMenuItem
            // 
            this.uSERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.uSERToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.uSERToolStripMenuItem.Name = "uSERToolStripMenuItem";
            this.uSERToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.uSERToolStripMenuItem.Text = "BUYER";
            this.uSERToolStripMenuItem.Click += new System.EventHandler(this.uSERToolStripMenuItem_Click);
            // 
            // sELLERToolStripMenuItem
            // 
            this.sELLERToolStripMenuItem.Name = "sELLERToolStripMenuItem";
            this.sELLERToolStripMenuItem.Size = new System.Drawing.Size(152, 30);
            this.sELLERToolStripMenuItem.Text = "SELLER";
            this.sELLERToolStripMenuItem.Click += new System.EventHandler(this.sELLERToolStripMenuItem_Click);
            // 
            // rEGISTERToolStripMenuItem
            // 
            this.rEGISTERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uSERToolStripMenuItem1,
            this.bUYERToolStripMenuItem});
            this.rEGISTERToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.rEGISTERToolStripMenuItem.Name = "rEGISTERToolStripMenuItem";
            this.rEGISTERToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
            this.rEGISTERToolStripMenuItem.Text = "REGISTER";
            // 
            // uSERToolStripMenuItem1
            // 
            this.uSERToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.uSERToolStripMenuItem1.ForeColor = System.Drawing.Color.Black;
            this.uSERToolStripMenuItem1.Name = "uSERToolStripMenuItem1";
            this.uSERToolStripMenuItem1.Size = new System.Drawing.Size(139, 30);
            this.uSERToolStripMenuItem1.Text = "SELLER";
            this.uSERToolStripMenuItem1.Click += new System.EventHandler(this.uSERToolStripMenuItem1_Click);
            // 
            // bUYERToolStripMenuItem
            // 
            this.bUYERToolStripMenuItem.Name = "bUYERToolStripMenuItem";
            this.bUYERToolStripMenuItem.Size = new System.Drawing.Size(139, 30);
            this.bUYERToolStripMenuItem.Text = "BUYER";
            this.bUYERToolStripMenuItem.Click += new System.EventHandler(this.bUYERToolStripMenuItem_Click);
            // 
            // cONTACTToolStripMenuItem
            // 
            this.cONTACTToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cONTACTToolStripMenuItem.Name = "cONTACTToolStripMenuItem";
            this.cONTACTToolStripMenuItem.Size = new System.Drawing.Size(134, 29);
            this.cONTACTToolStripMenuItem.Text = " CONTACT US";
            this.cONTACTToolStripMenuItem.Click += new System.EventHandler(this.cONTACTToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(422, -67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1067, 516);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1067, 676);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uSERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cONTACTToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem sELLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUYERToolStripMenuItem;



    }
}

