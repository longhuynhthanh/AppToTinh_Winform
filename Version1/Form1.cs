using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(600, 600);
        }
        int x;
        int y;
        private void btnKhong_MouseHover(object sender, EventArgs e)
        {
            Random rd = new Random();
            x = rd.Next(0, this.Size.Width - btnKhong.Size.Width);
            y = rd.Next(lblCauHoi.Size.Height + ptrAnh.Size.Height, this.Size.Height - btnKhong.Size.Height - 30);
            btnKhong.Location = new Point(x, y);
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            ptrAnh.Image = Image.FromFile("1.jpg");
            ptrAnh.SizeMode = PictureBoxSizeMode.StretchImage;

            MessageBox.Show("Anh cũng yêu em nhiều lắm");
        }
    }
}
