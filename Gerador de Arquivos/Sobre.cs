using System;
using System.Windows.Forms;

namespace Gerador_de_Arquivos {
    public partial class frmSobre : Form {
        public frmSobre() {
            InitializeComponent();
        }

        //codigo para não movimentar o form
        protected override void WndProc(ref Message message) {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg) {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }


        private void btVoltar_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
