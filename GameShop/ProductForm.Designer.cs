namespace GameShop
{
    partial class ProductForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLblAccount = new System.Windows.Forms.LinkLabel();
            this.flowLayoutAllGames = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Games";
            // 
            // linkLblAccount
            // 
            this.linkLblAccount.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLblAccount.AutoSize = true;
            this.linkLblAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.linkLblAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.linkLblAccount.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLblAccount.LinkColor = System.Drawing.Color.White;
            this.linkLblAccount.Location = new System.Drawing.Point(360, 0);
            this.linkLblAccount.Name = "linkLblAccount";
            this.linkLblAccount.Size = new System.Drawing.Size(86, 28);
            this.linkLblAccount.TabIndex = 1;
            this.linkLblAccount.TabStop = true;
            this.linkLblAccount.Text = "Account";
            this.linkLblAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblAccount_LinkClicked);
            // 
            // flowLayoutAllGames
            // 
            this.flowLayoutAllGames.AutoScroll = true;
            this.flowLayoutAllGames.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutAllGames.Location = new System.Drawing.Point(0, 65);
            this.flowLayoutAllGames.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutAllGames.Name = "flowLayoutAllGames";
            this.flowLayoutAllGames.Size = new System.Drawing.Size(1034, 485);
            this.flowLayoutAllGames.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLblAccount);
            this.panel1.Location = new System.Drawing.Point(553, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 36);
            this.panel1.TabIndex = 0;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1034, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutAllGames);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLblAccount;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutAllGames;
        private System.Windows.Forms.Panel panel1;
    }
}

