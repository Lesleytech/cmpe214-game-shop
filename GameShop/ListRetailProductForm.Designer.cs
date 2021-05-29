
namespace GameShop
{
    partial class ListRetailProductForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelAddGame = new System.Windows.Forms.LinkLabel();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutGameList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabelAddGame);
            this.panel1.Controls.Add(this.linkLabelLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 62);
            this.panel1.TabIndex = 0;
            // 
            // linkLabelAddGame
            // 
            this.linkLabelAddGame.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelAddGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelAddGame.AutoSize = true;
            this.linkLabelAddGame.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.linkLabelAddGame.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelAddGame.LinkColor = System.Drawing.Color.White;
            this.linkLabelAddGame.Location = new System.Drawing.Point(758, 22);
            this.linkLabelAddGame.Name = "linkLabelAddGame";
            this.linkLabelAddGame.Size = new System.Drawing.Size(108, 28);
            this.linkLabelAddGame.TabIndex = 3;
            this.linkLabelAddGame.TabStop = true;
            this.linkLabelAddGame.Text = "Add Game";
            this.linkLabelAddGame.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAddGame_LinkClicked);
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabelLogout.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabelLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.linkLabelLogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabelLogout.LinkColor = System.Drawing.Color.White;
            this.linkLabelLogout.Location = new System.Drawing.Point(898, 22);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(77, 28);
            this.linkLabelLogout.TabIndex = 2;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout (Admin)";
            this.linkLabelLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
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
            this.label1.TabIndex = 1;
            this.label1.Text = "All Games";
            // 
            // flowLayoutGameList
            // 
            this.flowLayoutGameList.AutoScroll = true;
            this.flowLayoutGameList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutGameList.Location = new System.Drawing.Point(0, 66);
            this.flowLayoutGameList.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutGameList.Name = "flowLayoutGameList";
            this.flowLayoutGameList.Size = new System.Drawing.Size(1034, 484);
            this.flowLayoutGameList.TabIndex = 1;
            // 
            // ListRetailProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1034, 550);
            this.Controls.Add(this.flowLayoutGameList);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListRetailProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Retail Products (*Admin)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListRetailProductForm_FormClosed);
            this.Load += new System.EventHandler(this.ListRetailProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.LinkLabel linkLabelAddGame;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutGameList;
    }
}