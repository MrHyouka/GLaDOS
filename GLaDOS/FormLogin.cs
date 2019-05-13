using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using GLaDOS.Properties;
using GLaDOS.BLL.System;
using System.Threading;

namespace GLaDOS
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        #region "界面初始化"

        private void FormLogin_Load(object sender, EventArgs e)
        {
            AudioPlayService.SoundPlay(Resources.GLaDOS_Welcome);
            labVersion.Text += System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        #region "无边框拖动效果"
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;

        private void pnlDragPad_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        #endregion

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = (System.Drawing.Image)Resources.next_32_green;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = (System.Drawing.Image)Resources.next_32_white;
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = (System.Drawing.Image)Resources.next_32_green;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.BackgroundImage = (System.Drawing.Image)Resources.next_32_white;
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = (System.Drawing.Image)Resources.back_32_red;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = (System.Drawing.Image)Resources.back_32_white;
        }

        private void btnExit_Enter(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = (System.Drawing.Image)Resources.back_32_red;
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackgroundImage = (System.Drawing.Image)Resources.back_32_white;
        }

        #endregion

        #region "登陆及退出事件"

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UserLoginService.UserLogin(txtUserName.Text.Trim(), txtPassword.Text.Trim()) == true)
            {
                AudioPlayService.SoundPlay(Resources.GLaDOS_Hello_world);
                Program.SetLoginFlag = true;
                this.Close();
            }
            else
            {
                MessageBox.Show(Language.Msg_UserOrPassword_Error,Language.Caption_Error,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            AudioPlayService.SoundPlay(Resources.GLaDOS_I_love_you);
            Thread.Sleep(1000);
            this.Close();
        }

        #endregion
    }
}