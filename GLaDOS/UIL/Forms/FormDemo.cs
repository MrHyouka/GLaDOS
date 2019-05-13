using GLaDOS.Properties;
using GLaDOS.UIL.BaseForms;
using System;
using System.Windows.Forms;

namespace GLaDOS.UIL.Forms
{
    public partial class FormDemo : BaseForm01
    {
        public FormDemo()
        {
            InitializeComponent();
        }

        private void btnHelloWorld_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Language.Msg_Hello_World, Language.Caption_Information, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
