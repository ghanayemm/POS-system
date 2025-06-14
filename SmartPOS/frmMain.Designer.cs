namespace SmartPOS
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnSetup = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.brnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightGray;
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Controls.Add(this.btnPOS);
            this.pnlMenu.Controls.Add(this.btnSetup);
            this.pnlMenu.Controls.Add(this.btnReporting);
            this.pnlMenu.Controls.Add(this.btnOptions);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 603);
            this.pnlMenu.TabIndex = 1;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlLogo.Controls.Add(this.linkLabel1);
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Controls.Add(this.pictureBox1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(212, 80);
            this.pnlLogo.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(82, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 22);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Ghanayem";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "1.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Smart POS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 74);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnPOS
            // 
            this.btnPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOS.FlatAppearance.BorderSize = 0;
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Black;
            this.btnPOS.Image = ((System.Drawing.Image)(resources.GetObject("btnPOS.Image")));
            this.btnPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOS.Location = new System.Drawing.Point(3, 89);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnPOS.Size = new System.Drawing.Size(212, 80);
            this.btnPOS.TabIndex = 3;
            this.btnPOS.Text = "POS";
            this.btnPOS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnSetup
            // 
            this.btnSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetup.FlatAppearance.BorderSize = 0;
            this.btnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetup.ForeColor = System.Drawing.Color.Black;
            this.btnSetup.Image = ((System.Drawing.Image)(resources.GetObject("btnSetup.Image")));
            this.btnSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetup.Location = new System.Drawing.Point(3, 175);
            this.btnSetup.Name = "btnSetup";
            this.btnSetup.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSetup.Size = new System.Drawing.Size(212, 80);
            this.btnSetup.TabIndex = 4;
            this.btnSetup.Text = "Setup";
            this.btnSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetup.UseVisualStyleBackColor = true;
            this.btnSetup.Click += new System.EventHandler(this.btnSetup_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporting.ForeColor = System.Drawing.Color.Black;
            this.btnReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.Image")));
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(3, 261);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReporting.Size = new System.Drawing.Size(212, 91);
            this.btnReporting.TabIndex = 5;
            this.btnReporting.Text = "Reports";
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.ForeColor = System.Drawing.Color.Black;
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOptions.Location = new System.Drawing.Point(3, 358);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnOptions.Size = new System.Drawing.Size(212, 80);
            this.btnOptions.TabIndex = 6;
            this.btnOptions.Text = "Options";
            this.btnOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlTitle.Controls.Add(this.brnClose);
            this.pnlTitle.Controls.Add(this.lblTime);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(220, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(655, 100);
            this.pnlTitle.TabIndex = 2;
            // 
            // brnClose
            // 
            this.brnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.brnClose.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.brnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnClose.BackgroundImage")));
            this.brnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnClose.FlatAppearance.BorderSize = 0;
            this.brnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnClose.Location = new System.Drawing.Point(575, 36);
            this.brnClose.Name = "brnClose";
            this.brnClose.Size = new System.Drawing.Size(68, 65);
            this.brnClose.TabIndex = 0;
            this.brnClose.UseVisualStyleBackColor = false;
            this.brnClose.Click += new System.EventHandler(this.brnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(12, 75);
            this.lblTime.Name = "lblTime";
            this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTime.Size = new System.Drawing.Size(64, 22);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "label1";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(6, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Point of Sale";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainForm.Location = new System.Drawing.Point(220, 100);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(655, 503);
            this.pnlMainForm.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 603);
            this.Controls.Add(this.pnlMainForm);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(893, 650);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart POS";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnSetup;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMainForm;
        private System.Windows.Forms.Button brnClose;
    }
}

