
namespace GameShop
{
    partial class GameListItem
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
            this.picBoxGameListImg = new System.Windows.Forms.PictureBox();
            this.lblGameListName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGameListPrice = new System.Windows.Forms.Label();
            this.lblGameListStock = new System.Windows.Forms.Label();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.btnEditGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameListImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxGameListImg
            // 
            this.picBoxGameListImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxGameListImg.Location = new System.Drawing.Point(40, 19);
            this.picBoxGameListImg.Name = "picBoxGameListImg";
            this.picBoxGameListImg.Size = new System.Drawing.Size(144, 185);
            this.picBoxGameListImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxGameListImg.TabIndex = 41;
            this.picBoxGameListImg.TabStop = false;
            // 
            // lblGameListName
            // 
            this.lblGameListName.AutoSize = true;
            this.lblGameListName.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGameListName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGameListName.Location = new System.Drawing.Point(233, 52);
            this.lblGameListName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameListName.Name = "lblGameListName";
            this.lblGameListName.Size = new System.Drawing.Size(216, 23);
            this.lblGameListName.TabIndex = 42;
            this.lblGameListName.Text = "Red Dead Redemption 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(233, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 43;
            this.label1.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(233, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 44;
            this.label2.Text = "Stock:";
            // 
            // lblGameListPrice
            // 
            this.lblGameListPrice.AutoSize = true;
            this.lblGameListPrice.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGameListPrice.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGameListPrice.Location = new System.Drawing.Point(327, 97);
            this.lblGameListPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameListPrice.Name = "lblGameListPrice";
            this.lblGameListPrice.Size = new System.Drawing.Size(37, 23);
            this.lblGameListPrice.TabIndex = 45;
            this.lblGameListPrice.Text = "400";
            // 
            // lblGameListStock
            // 
            this.lblGameListStock.AutoSize = true;
            this.lblGameListStock.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblGameListStock.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblGameListStock.Location = new System.Drawing.Point(327, 143);
            this.lblGameListStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameListStock.Name = "lblGameListStock";
            this.lblGameListStock.Size = new System.Drawing.Size(28, 23);
            this.lblGameListStock.TabIndex = 46;
            this.lblGameListStock.Text = "20";
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.AutoSize = true;
            this.btnDeleteGame.BackColor = System.Drawing.Color.Black;
            this.btnDeleteGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteGame.FlatAppearance.BorderSize = 0;
            this.btnDeleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGame.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnDeleteGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteGame.Location = new System.Drawing.Point(1294, 134);
            this.btnDeleteGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(417, 56);
            this.btnDeleteGame.TabIndex = 47;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = false;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // btnEditGame
            // 
            this.btnEditGame.AutoSize = true;
            this.btnEditGame.BackColor = System.Drawing.Color.DimGray;
            this.btnEditGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditGame.FlatAppearance.BorderSize = 0;
            this.btnEditGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGame.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnEditGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditGame.Location = new System.Drawing.Point(1294, 40);
            this.btnEditGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditGame.Name = "btnEditGame";
            this.btnEditGame.Size = new System.Drawing.Size(417, 56);
            this.btnEditGame.TabIndex = 48;
            this.btnEditGame.Text = "Edit Game";
            this.btnEditGame.UseVisualStyleBackColor = false;
            this.btnEditGame.Click += new System.EventHandler(this.btnEditGame_Click);
            // 
            // GameListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.Controls.Add(this.btnEditGame);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.lblGameListStock);
            this.Controls.Add(this.lblGameListPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGameListName);
            this.Controls.Add(this.picBoxGameListImg);
            this.Name = "GameListItem";
            this.Size = new System.Drawing.Size(1809, 242);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGameListImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxGameListImg;
        private System.Windows.Forms.Label lblGameListName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGameListPrice;
        private System.Windows.Forms.Label lblGameListStock;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button btnEditGame;
    }
}
