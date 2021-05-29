
namespace GameShop
{
    partial class GameItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameItem));
            this.panelGameItem = new System.Windows.Forms.Panel();
            this.btnGameBuy = new System.Windows.Forms.Button();
            this.lblGameStock = new System.Windows.Forms.Label();
            this.picBoxGameImg = new System.Windows.Forms.PictureBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.lblGamePrice = new System.Windows.Forms.Label();
            this.panelGameItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGameItem
            // 
            this.panelGameItem.Controls.Add(this.lblGamePrice);
            this.panelGameItem.Controls.Add(this.btnGameBuy);
            this.panelGameItem.Controls.Add(this.lblGameStock);
            this.panelGameItem.Controls.Add(this.picBoxGameImg);
            this.panelGameItem.Controls.Add(this.lblGameName);
            this.panelGameItem.Location = new System.Drawing.Point(12, 4);
            this.panelGameItem.Margin = new System.Windows.Forms.Padding(4);
            this.panelGameItem.Name = "panelGameItem";
            this.panelGameItem.Size = new System.Drawing.Size(420, 725);
            this.panelGameItem.TabIndex = 1;
            // 
            // btnGameBuy
            // 
            this.btnGameBuy.BackColor = System.Drawing.Color.Black;
            this.btnGameBuy.FlatAppearance.BorderSize = 0;
            this.btnGameBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGameBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnGameBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGameBuy.Location = new System.Drawing.Point(21, 589);
            this.btnGameBuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnGameBuy.Name = "btnGameBuy";
            this.btnGameBuy.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.btnGameBuy.Size = new System.Drawing.Size(374, 78);
            this.btnGameBuy.TabIndex = 3;
            this.btnGameBuy.Text = "Buy Now";
            this.btnGameBuy.UseVisualStyleBackColor = false;
            this.btnGameBuy.Click += new System.EventHandler(this.btnGameBuy_Click);
            // 
            // lblGameStock
            // 
            this.lblGameStock.AutoSize = true;
            this.lblGameStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGameStock.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGameStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblGameStock.Location = new System.Drawing.Point(21, 541);
            this.lblGameStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameStock.Name = "lblGameStock";
            this.lblGameStock.Size = new System.Drawing.Size(25, 19);
            this.lblGameStock.TabIndex = 2;
            this.lblGameStock.Text = "10";
            // 
            // picBoxGameImg
            // 
            this.picBoxGameImg.BackColor = System.Drawing.Color.Black;
            this.picBoxGameImg.Image = ((System.Drawing.Image)(resources.GetObject("picBoxGameImg.Image")));
            this.picBoxGameImg.Location = new System.Drawing.Point(25, 4);
            this.picBoxGameImg.Margin = new System.Windows.Forms.Padding(4);
            this.picBoxGameImg.Name = "picBoxGameImg";
            this.picBoxGameImg.Size = new System.Drawing.Size(370, 474);
            this.picBoxGameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxGameImg.TabIndex = 0;
            this.picBoxGameImg.TabStop = false;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGameName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGameName.Location = new System.Drawing.Point(23, 495);
            this.lblGameName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(216, 23);
            this.lblGameName.TabIndex = 1;
            this.lblGameName.Text = "Red Dead Redemption 2";
            // 
            // lblGamePrice
            // 
            this.lblGamePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGamePrice.AutoSize = true;
            this.lblGamePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGamePrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGamePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblGamePrice.Location = new System.Drawing.Point(313, 541);
            this.lblGamePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGamePrice.Name = "lblGamePrice";
            this.lblGamePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGamePrice.Size = new System.Drawing.Size(33, 19);
            this.lblGamePrice.TabIndex = 4;
            this.lblGamePrice.Text = "400";
            this.lblGamePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GameItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.panelGameItem);
            this.Name = "GameItem";
            this.Size = new System.Drawing.Size(445, 735);
            this.panelGameItem.ResumeLayout(false);
            this.panelGameItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGameItem;
        private System.Windows.Forms.Button btnGameBuy;
        private System.Windows.Forms.Label lblGameStock;
        private System.Windows.Forms.PictureBox picBoxGameImg;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.Label lblGamePrice;
    }
}
