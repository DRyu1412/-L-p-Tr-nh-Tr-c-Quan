using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class fHome : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private int imageNumber = 2;
        public fHome()
        {
            InitializeComponent();
            random = new Random();
            this.ControlBox = false;
            this.Text = String.Empty;
            //this.WindowState = FormWindowState.Maximized;
            labelXinChao.Text = "Xin chào, " + fLogin.tenChuTaiKhoan;
        }
        private void LoadNextImage()
        {
            if (imageNumber == 9)
                imageNumber = 1;
            pictureBox2.ImageLocation = string.Format(@"IMAGES\{0}.jpg", imageNumber);
            imageNumber++;
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    panelTitle.BackColor = color;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }

        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(FontAwesome.Sharp.IconButton))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = ((Button)btnSender).Text;
        }

        private void btnQLTD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fThucDon(), sender);
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fNhanVien(), sender);
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fHoaDon(), sender);
        }

        private void btnQLB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form(), sender);
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form(), sender);
        }

        private void btnQLHT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form(), sender);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                fLogin fLG = new fLogin();
                fLG.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }
    }
}
