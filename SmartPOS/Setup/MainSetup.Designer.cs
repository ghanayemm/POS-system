namespace SmartPOS.Setup
{
    partial class MainSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSetup));
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCategories
            // 
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.Image = ((System.Drawing.Image)(resources.GetObject("btnCategories.Image")));
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCategories.Location = new System.Drawing.Point(12, 12);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(135, 125);
            this.btnCategories.TabIndex = 1;
            this.btnCategories.Text = "Categories";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCategories.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            this.btnItems.FlatAppearance.BorderSize = 0;
            this.btnItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.Image = ((System.Drawing.Image)(resources.GetObject("btnItems.Image")));
            this.btnItems.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnItems.Location = new System.Drawing.Point(12, 132);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(135, 125);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Items";
            this.btnItems.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // btnPayments
            // 
            this.btnPayments.FlatAppearance.BorderSize = 0;
            this.btnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.Image = ((System.Drawing.Image)(resources.GetObject("btnPayments.Image")));
            this.btnPayments.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPayments.Location = new System.Drawing.Point(12, 252);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(135, 125);
            this.btnPayments.TabIndex = 3;
            this.btnPayments.Text = "Payments";
            this.btnPayments.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPayments.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnUsers.Image")));
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUsers.Location = new System.Drawing.Point(138, 132);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(135, 125);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExit.Location = new System.Drawing.Point(731, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 96);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 428);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCategories);
            this.Name = "MainSetup";
            this.Text = "MainSetup";
            this.Load += new System.EventHandler(this.MainSetup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExit;
    }
}