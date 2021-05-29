
namespace GameShop
{
    partial class AddGameItemForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAddGamePrice = new System.Windows.Forms.Label();
            this.txtBoxAddGamePrice = new System.Windows.Forms.TextBox();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddGameStock = new System.Windows.Forms.Label();
            this.lblAddGameName = new System.Windows.Forms.Label();
            this.txtBoxAddGameStock = new System.Windows.Forms.TextBox();
            this.txtBoxAddGameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxAddGameImg = new System.Windows.Forms.PictureBox();
            this.btnAddGameImgUpload = new System.Windows.Forms.Button();
            this.errProviderAddGameForm = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddGameImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAddGameForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.Location = new System.Drawing.Point(62, 787);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 4);
            this.panel3.TabIndex = 39;
            // 
            // lblAddGamePrice
            // 
            this.lblAddGamePrice.AutoSize = true;
            this.lblAddGamePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAddGamePrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddGamePrice.Location = new System.Drawing.Point(62, 665);
            this.lblAddGamePrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGamePrice.Name = "lblAddGamePrice";
            this.lblAddGamePrice.Size = new System.Drawing.Size(97, 23);
            this.lblAddGamePrice.TabIndex = 38;
            this.lblAddGamePrice.Text = "Game Price";
            // 
            // txtBoxAddGamePrice
            // 
            this.txtBoxAddGamePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxAddGamePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddGamePrice.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxAddGamePrice.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxAddGamePrice.Location = new System.Drawing.Point(62, 732);
            this.txtBoxAddGamePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddGamePrice.MaxLength = 4;
            this.txtBoxAddGamePrice.Name = "txtBoxAddGamePrice";
            this.txtBoxAddGamePrice.Size = new System.Drawing.Size(568, 27);
            this.txtBoxAddGamePrice.TabIndex = 31;
            this.txtBoxAddGamePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAddGamePrice_KeyPress);
            // 
            // btnAddGame
            // 
            this.btnAddGame.AutoSize = true;
            this.btnAddGame.BackColor = System.Drawing.Color.Black;
            this.btnAddGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGame.FlatAppearance.BorderSize = 0;
            this.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGame.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddGame.Location = new System.Drawing.Point(66, 1054);
            this.btnAddGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(563, 70);
            this.btnAddGame.TabIndex = 37;
            this.btnAddGame.Text = "Add Game";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Location = new System.Drawing.Point(62, 990);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(568, 4);
            this.panel2.TabIndex = 36;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(62, 593);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 4);
            this.panel1.TabIndex = 35;
            // 
            // lblAddGameStock
            // 
            this.lblAddGameStock.AutoSize = true;
            this.lblAddGameStock.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAddGameStock.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddGameStock.Location = new System.Drawing.Point(62, 872);
            this.lblAddGameStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGameStock.Name = "lblAddGameStock";
            this.lblAddGameStock.Size = new System.Drawing.Size(102, 23);
            this.lblAddGameStock.TabIndex = 34;
            this.lblAddGameStock.Text = "Game Stock";
            // 
            // lblAddGameName
            // 
            this.lblAddGameName.AutoSize = true;
            this.lblAddGameName.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblAddGameName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAddGameName.Location = new System.Drawing.Point(62, 470);
            this.lblAddGameName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddGameName.Name = "lblAddGameName";
            this.lblAddGameName.Size = new System.Drawing.Size(106, 23);
            this.lblAddGameName.TabIndex = 32;
            this.lblAddGameName.Text = "Game Name";
            // 
            // txtBoxAddGameStock
            // 
            this.txtBoxAddGameStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxAddGameStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddGameStock.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxAddGameStock.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxAddGameStock.Location = new System.Drawing.Point(62, 935);
            this.txtBoxAddGameStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddGameStock.MaxLength = 4;
            this.txtBoxAddGameStock.Name = "txtBoxAddGameStock";
            this.txtBoxAddGameStock.Size = new System.Drawing.Size(568, 27);
            this.txtBoxAddGameStock.TabIndex = 33;
            this.txtBoxAddGameStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxAddGameStock_KeyPress);
            // 
            // txtBoxAddGameName
            // 
            this.txtBoxAddGameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtBoxAddGameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAddGameName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.txtBoxAddGameName.ForeColor = System.Drawing.Color.FloralWhite;
            this.txtBoxAddGameName.Location = new System.Drawing.Point(62, 534);
            this.txtBoxAddGameName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxAddGameName.MaxLength = 50;
            this.txtBoxAddGameName.Name = "txtBoxAddGameName";
            this.txtBoxAddGameName.Size = new System.Drawing.Size(568, 27);
            this.txtBoxAddGameName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 42);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add game";
            // 
            // picBoxAddGameImg
            // 
            this.picBoxAddGameImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxAddGameImg.Location = new System.Drawing.Point(66, 143);
            this.picBoxAddGameImg.Name = "picBoxAddGameImg";
            this.picBoxAddGameImg.Size = new System.Drawing.Size(243, 282);
            this.picBoxAddGameImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAddGameImg.TabIndex = 40;
            this.picBoxAddGameImg.TabStop = false;
            // 
            // btnAddGameImgUpload
            // 
            this.btnAddGameImgUpload.AutoSize = true;
            this.btnAddGameImgUpload.BackColor = System.Drawing.Color.DimGray;
            this.btnAddGameImgUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGameImgUpload.FlatAppearance.BorderSize = 0;
            this.btnAddGameImgUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGameImgUpload.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.btnAddGameImgUpload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddGameImgUpload.Location = new System.Drawing.Point(334, 355);
            this.btnAddGameImgUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddGameImgUpload.Name = "btnAddGameImgUpload";
            this.btnAddGameImgUpload.Size = new System.Drawing.Size(296, 70);
            this.btnAddGameImgUpload.TabIndex = 41;
            this.btnAddGameImgUpload.Text = "Upload Image";
            this.btnAddGameImgUpload.UseVisualStyleBackColor = false;
            this.btnAddGameImgUpload.Click += new System.EventHandler(this.btnAddGameImgUpload_Click);
            // 
            // errProviderAddGameForm
            // 
            this.errProviderAddGameForm.ContainerControl = this;
            // 
            // AddGameItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(711, 1183);
            this.Controls.Add(this.btnAddGameImgUpload);
            this.Controls.Add(this.picBoxAddGameImg);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblAddGamePrice);
            this.Controls.Add(this.txtBoxAddGamePrice);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddGameStock);
            this.Controls.Add(this.lblAddGameName);
            this.Controls.Add(this.txtBoxAddGameStock);
            this.Controls.Add(this.txtBoxAddGameName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGameItemForm";
            this.Text = "Add a new game";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAddGameImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProviderAddGameForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblAddGamePrice;
        private System.Windows.Forms.TextBox txtBoxAddGamePrice;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddGameStock;
        private System.Windows.Forms.Label lblAddGameName;
        private System.Windows.Forms.TextBox txtBoxAddGameStock;
        private System.Windows.Forms.TextBox txtBoxAddGameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxAddGameImg;
        private System.Windows.Forms.Button btnAddGameImgUpload;
        private System.Windows.Forms.ErrorProvider errProviderAddGameForm;
    }
}