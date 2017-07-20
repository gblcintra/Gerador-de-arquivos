using System;
using System.Drawing;
using System.Windows.Forms;

namespace Gerador_de_Arquivos {
    public partial class frmGerador : Form {
        public frmGerador() {
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

        private void Form1_Load(object sender, EventArgs e) {
            txtQuantidade.Focus();
            txtNome.Text = "Gerador"; //Nome Padrão para o arquivo
            txtSalve.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Gerador"; //Pasta padrão onde sera salva os arquivos
        }

        private void limpar() { //Função para limpar a tela depois de criado os arquivos
            txtQuantidade.Clear();
            txtTamanho.Clear();
            txtNome.Text = "Gerador";
            txtQuantidade.Focus();

        }


        private void btSalve_Click(object sender, EventArgs e) {//Botão salve
            fbdSalve.ShowDialog();
            txtSalve.Text = fbdSalve.SelectedPath;
        }

        private void btCriar_Click(object sender, EventArgs e) {//Botão para criar os arquivos
   
            //Validação dos textbox

            //Validação do textbox Quantidade de Arquivos
            if (txtQuantidade.Text == "") {
                MessageBox.Show("Campo Quantidade esta vazio!","Erro de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                Int32.Parse(txtQuantidade.Text);
                if (Int32.Parse(txtQuantidade.Text)<1) {
                    MessageBox.Show("Criar no minimo 1 arquivo!","Erro de Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch {
                MessageBox.Show("No campo Quantidade, digitar somente numeros!", "Erro de Caracter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validação do textbox Tamanho
            if (txtTamanho.Text == "") {
                MessageBox.Show("Campo Tamanho esta vazio!", "Erro de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
                Int32.Parse(txtTamanho.Text);
                if (Int32.Parse(txtTamanho.Text) < 0) {
                    MessageBox.Show("Tamanho do arquivo maior que 0 KB !", "Erro de Tamanho", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            catch {
                MessageBox.Show("No campo Tamanho, digitar somente numeros!", "Erro de Caracter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validação do textbox Nome do arquivo
            if (txtNome.Text == "") {
                MessageBox.Show("Campo Nome esta vazio!", "Erro de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Validação do textbox Do caminho que os arquivos iram ser salvos
            if (txtSalve.Text == "") {
                MessageBox.Show("Preencha o Local para salvar os arquivos","Erro de Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSalve.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Desktop\\Gerador";
                return;
            }

            //fim da validação


            progressBar1.Maximum = Int32.Parse(txtQuantidade.Text);
            
            progressBar1.Value = 0;
            progressBar1.Visible = true;// quando clicar em criar a barra de processos ira aparecer



            //Verificar se existe o caminho da pasta onde os arquivos vão ser salvos
            if (!System.IO.Directory.Exists(txtSalve.Text)) {
                System.IO.Directory.CreateDirectory(txtSalve.Text);
            }
            //rbKB

            long tamanho = 1024 * Int32.Parse(txtTamanho.Text);
            //rbMB
            if (rbMB.Checked) {
                if (Int32.Parse(txtQuantidade.Text) >= 10 || Int32.Parse(txtTamanho.Text) >= 100) {
                    if (Int32.Parse(txtTamanho.Text) >= 30) {
                        MessageBox.Show("Por conta da quantidade de arquivos ser muita ou do tamanho ser grande, o programa pode demorar para criar os arquivos, aguarde até ser finalizado.\nClique em Ok para continuar.", "Aviso... ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                tamanho *= 1024;  //aqui estou utilizando o tamanho 1024 pois 1024 bits é 1 kb 
            }
            if (rbGB.Checked) {
                MessageBox.Show("Por conta da quantidade de arquivos ser muita ou do tamanho ser grande, o programa pode demorar para criar os arquivos, aguarde até ser finalizado.\nClique em Ok para continuar.", "Aviso... ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tamanho *= 1048576;
            }
            //Aqui cria o(s) arquivo(s)
            for (var i = 1;i<= Int32.Parse(txtQuantidade.Text); i++) {//Calcula e cria os arquivos
                var arquivo = txtSalve.Text + "\\" + txtNome.Text + i.ToString();
                progressBar1.Value++;
                //System.IO.File.Create(arquivo);
                using (var writer = new System.IO.StreamWriter(arquivo)) {
                    for (var x = 1; x <= tamanho; x++) {
                        writer.Write("_");//no caso estou preenchendo o(s) arquivo(s) com espaço para ter tamanho no arquivo
                    }
                }
                //System.IO.File.AppendAllText(arquivo, conteudotxt);
            }
            progressBar1.Visible = false;
            MessageBox.Show("Arquivo(s) criado(s)!","Concluido",MessageBoxButtons.OK,MessageBoxIcon.Information);
            limpar();
            btSobre.Visible = true;
        }

        private void btSobre_Click(object sender, EventArgs e) {
            frmSobre Sobre = new frmSobre();
            Sobre.ShowDialog();
        }

        private void btSair_Click(object sender, EventArgs e) {
            Close();
        }

    }
}
