namespace Gerador_de_Arquivos {
    partial class frmGerador {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerador));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btCriar = new System.Windows.Forms.Button();
            this.fbdSalve = new System.Windows.Forms.FolderBrowserDialog();
            this.btSobre = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rbMB = new System.Windows.Forms.RadioButton();
            this.rbKB = new System.Windows.Forms.RadioButton();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.btSalve = new System.Windows.Forms.Button();
            this.txtSalve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rbGB = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Window;
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.Default;
            this.progressBar1.Location = new System.Drawing.Point(39, 324);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(304, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Visible = false;
            // 
            // btCriar
            // 
            this.btCriar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btCriar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btCriar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btCriar.Location = new System.Drawing.Point(137, 353);
            this.btCriar.Name = "btCriar";
            this.btCriar.Size = new System.Drawing.Size(112, 38);
            this.btCriar.TabIndex = 8;
            this.btCriar.Text = "Criar Arquivo";
            this.btCriar.UseVisualStyleBackColor = false;
            this.btCriar.Click += new System.EventHandler(this.btCriar_Click);
            // 
            // btSobre
            // 
            this.btSobre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSobre.AutoSize = true;
            this.btSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btSobre.Location = new System.Drawing.Point(334, 397);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(48, 23);
            this.btSobre.TabIndex = 10;
            this.btSobre.Text = "Sobre";
            this.btSobre.UseVisualStyleBackColor = false;
            this.btSobre.Visible = false;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // btSair
            // 
            this.btSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSair.Location = new System.Drawing.Point(158, 395);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 9;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(180, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "File Generator";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.treeView1.Location = new System.Drawing.Point(12, 95);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(360, 65);
            this.treeView1.TabIndex = 15;
            // 
            // rbMB
            // 
            this.rbMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbMB.AutoSize = true;
            this.rbMB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rbMB.Location = new System.Drawing.Point(289, 122);
            this.rbMB.Name = "rbMB";
            this.rbMB.Size = new System.Drawing.Size(41, 17);
            this.rbMB.TabIndex = 4;
            this.rbMB.TabStop = true;
            this.rbMB.Text = "MB";
            this.rbMB.UseVisualStyleBackColor = false;
            // 
            // rbKB
            // 
            this.rbKB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbKB.AutoSize = true;
            this.rbKB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rbKB.Checked = true;
            this.rbKB.Location = new System.Drawing.Point(253, 122);
            this.rbKB.Name = "rbKB";
            this.rbKB.Size = new System.Drawing.Size(39, 17);
            this.rbKB.TabIndex = 3;
            this.rbKB.TabStop = true;
            this.rbKB.Text = "KB";
            this.rbKB.UseVisualStyleBackColor = false;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTamanho.BackColor = System.Drawing.Color.White;
            this.txtTamanho.Location = new System.Drawing.Point(150, 121);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtTamanho.TabIndex = 2;
            this.txtTamanho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.txtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.Location = new System.Drawing.Point(37, 121);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 1;
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(174, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tamanho:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Quantidade de Arquivo(s):";
            // 
            // treeView2
            // 
            this.treeView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.treeView2.Location = new System.Drawing.Point(12, 170);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(360, 65);
            this.treeView2.TabIndex = 22;
            // 
            // btSalve
            // 
            this.btSalve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalve.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalve.Location = new System.Drawing.Point(294, 190);
            this.btSalve.Name = "btSalve";
            this.btSalve.Size = new System.Drawing.Size(30, 22);
            this.btSalve.TabIndex = 6;
            this.btSalve.Text = "...";
            this.btSalve.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btSalve.UseVisualStyleBackColor = true;
            this.btSalve.Click += new System.EventHandler(this.btSalve_Click);
            // 
            // txtSalve
            // 
            this.txtSalve.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalve.BackColor = System.Drawing.Color.White;
            this.txtSalve.Location = new System.Drawing.Point(63, 191);
            this.txtSalve.Name = "txtSalve";
            this.txtSalve.ReadOnly = true;
            this.txtSalve.Size = new System.Drawing.Size(259, 20);
            this.txtSalve.TabIndex = 5;
            this.txtSalve.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label3.Location = new System.Drawing.Point(149, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Local para salvar:";
            // 
            // treeView3
            // 
            this.treeView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.treeView3.Location = new System.Drawing.Point(12, 245);
            this.treeView3.Name = "treeView3";
            this.treeView3.Size = new System.Drawing.Size(360, 73);
            this.treeView3.TabIndex = 26;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.Location = new System.Drawing.Point(61, 264);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(267, 20);
            this.txtNome.TabIndex = 7;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Obs: Esse é o Nome padrão, ele pode ser modificado.\r\nSerá incluido nº de Id nos a" +
    "rquivos criados\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label4.Location = new System.Drawing.Point(150, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nome do Arquivo:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(80, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 12);
            this.label7.TabIndex = 29;
            this.label7.Text = "Obs: Esse é o Local padrão, ele pode ser modificado";
            // 
            // rbGB
            // 
            this.rbGB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbGB.AutoSize = true;
            this.rbGB.BackColor = System.Drawing.SystemColors.MenuBar;
            this.rbGB.Location = new System.Drawing.Point(327, 122);
            this.rbGB.Name = "rbGB";
            this.rbGB.Size = new System.Drawing.Size(40, 17);
            this.rbGB.TabIndex = 30;
            this.rbGB.TabStop = true;
            this.rbGB.Text = "GB";
            this.rbGB.UseVisualStyleBackColor = false;
            // 
            // frmGerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 421);
            this.ControlBox = false;
            this.Controls.Add(this.rbGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.btSalve);
            this.Controls.Add(this.txtSalve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.rbMB);
            this.Controls.Add(this.rbKB);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSobre);
            this.Controls.Add(this.btCriar);
            this.Controls.Add(this.progressBar1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCriar;
        private System.Windows.Forms.FolderBrowserDialog fbdSalve;
        private System.Windows.Forms.Button btSobre;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton rbMB;
        private System.Windows.Forms.RadioButton rbKB;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button btSalve;
        private System.Windows.Forms.TextBox txtSalve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TreeView treeView3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton rbGB;
    }
}

