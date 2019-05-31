namespace Version1
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
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.ptrAnh = new System.Windows.Forms.PictureBox();
            this.btnCo = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCauHoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCauHoi.Font = new System.Drawing.Font("Mistral", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.Location = new System.Drawing.Point(0, 0);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(596, 66);
            this.lblCauHoi.TabIndex = 0;
            this.lblCauHoi.Text = "Em Có Yêu Anh Không?";
            this.lblCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptrAnh
            // 
            this.ptrAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ptrAnh.BackgroundImage")));
            this.ptrAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptrAnh.Location = new System.Drawing.Point(-4, 69);
            this.ptrAnh.Name = "ptrAnh";
            this.ptrAnh.Size = new System.Drawing.Size(600, 400);
            this.ptrAnh.TabIndex = 1;
            this.ptrAnh.TabStop = false;
            // 
            // btnCo
            // 
            this.btnCo.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCo.Location = new System.Drawing.Point(89, 511);
            this.btnCo.Name = "btnCo";
            this.btnCo.Size = new System.Drawing.Size(75, 32);
            this.btnCo.TabIndex = 2;
            this.btnCo.Text = "Có";
            this.btnCo.UseVisualStyleBackColor = true;
            this.btnCo.Click += new System.EventHandler(this.btnCo_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhong.Location = new System.Drawing.Point(321, 511);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(75, 32);
            this.btnKhong.TabIndex = 3;
            this.btnKhong.Text = "Không";
            this.btnKhong.UseVisualStyleBackColor = true;
            this.btnKhong.MouseHover += new System.EventHandler(this.btnKhong_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(596, 658);
            this.Controls.Add(this.btnKhong);
            this.Controls.Add(this.btnCo);
            this.Controls.Add(this.ptrAnh);
            this.Controls.Add(this.lblCauHoi);
            this.Name = "Form1";
            this.Text = "Ứng Dụng Tỏ Tình";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptrAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.PictureBox ptrAnh;
        private System.Windows.Forms.Button btnCo;
        private System.Windows.Forms.Button btnKhong;
    }
}

