namespace WhatsAppTimer
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lStatus = new System.Windows.Forms.Label();
            this.lGrupo = new System.Windows.Forms.Label();
            this.lEnvio = new System.Windows.Forms.Label();
            this.btnCon = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.richLinks = new System.Windows.Forms.RichTextBox();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIntervalo = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lIntervalo = new System.Windows.Forms.Label();
            this.btnSetTimer = new System.Windows.Forms.Button();
            this.btnArquivoLinks = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lQtLinks = new System.Windows.Forms.Label();
            this.radioSegundos = new System.Windows.Forms.RadioButton();
            this.radioMinutos = new System.Windows.Forms.RadioButton();
            this.btnZerarContador = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            this.label1.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Envio:";
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Location = new System.Drawing.Point(58, 14);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(10, 13);
            this.lStatus.TabIndex = 3;
            this.lStatus.Text = "-";
            // 
            // lGrupo
            // 
            this.lGrupo.AutoSize = true;
            this.lGrupo.Location = new System.Drawing.Point(58, 27);
            this.lGrupo.Name = "lGrupo";
            this.lGrupo.Size = new System.Drawing.Size(10, 13);
            this.lGrupo.TabIndex = 4;
            this.lGrupo.Text = "-";
            // 
            // lEnvio
            // 
            this.lEnvio.AutoSize = true;
            this.lEnvio.Location = new System.Drawing.Point(58, 40);
            this.lEnvio.Name = "lEnvio";
            this.lEnvio.Size = new System.Drawing.Size(10, 13);
            this.lEnvio.TabIndex = 5;
            this.lEnvio.Text = "-";
            // 
            // btnCon
            // 
            this.btnCon.Location = new System.Drawing.Point(363, 14);
            this.btnCon.Name = "btnCon";
            this.btnCon.Size = new System.Drawing.Size(105, 25);
            this.btnCon.TabIndex = 6;
            this.btnCon.Text = "Abrir Navegador";
            this.btnCon.UseVisualStyleBackColor = true;
            this.btnCon.Click += new System.EventHandler(this.Conexao);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Location = new System.Drawing.Point(363, 83);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(105, 33);
            this.btnGrupo.TabIndex = 7;
            this.btnGrupo.Text = "Achar Grupo";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.Busca);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(367, 312);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(105, 32);
            this.btnEnviar.TabIndex = 8;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.Timer);
            // 
            // richLinks
            // 
            this.richLinks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richLinks.Location = new System.Drawing.Point(133, 12);
            this.richLinks.Name = "richLinks";
            this.richLinks.Size = new System.Drawing.Size(228, 332);
            this.richLinks.TabIndex = 9;
            this.richLinks.Text = "";
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(364, 57);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(104, 20);
            this.txtNomeGrupo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(367, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome Grupo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Intervalo Tempo(seg)";
            // 
            // txtIntervalo
            // 
            this.txtIntervalo.Location = new System.Drawing.Point(364, 144);
            this.txtIntervalo.Name = "txtIntervalo";
            this.txtIntervalo.Size = new System.Drawing.Size(104, 20);
            this.txtIntervalo.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(13, 119);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(100, 20);
            this.txtLink.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Link";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(25, 145);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(74, 23);
            this.btnAdicionar.TabIndex = 22;
            this.btnAdicionar.Text = "Add. Lista";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Adicione os links";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tempo entre envios:";
            // 
            // lIntervalo
            // 
            this.lIntervalo.AutoSize = true;
            this.lIntervalo.Location = new System.Drawing.Point(112, 53);
            this.lIntervalo.Name = "lIntervalo";
            this.lIntervalo.Size = new System.Drawing.Size(10, 13);
            this.lIntervalo.TabIndex = 25;
            this.lIntervalo.Text = "-";
            // 
            // btnSetTimer
            // 
            this.btnSetTimer.Location = new System.Drawing.Point(363, 215);
            this.btnSetTimer.Name = "btnSetTimer";
            this.btnSetTimer.Size = new System.Drawing.Size(105, 23);
            this.btnSetTimer.TabIndex = 26;
            this.btnSetTimer.Text = "Setar Timer";
            this.btnSetTimer.UseVisualStyleBackColor = true;
            this.btnSetTimer.Click += new System.EventHandler(this.btnSetTimer_Click);
            // 
            // btnArquivoLinks
            // 
            this.btnArquivoLinks.Location = new System.Drawing.Point(12, 183);
            this.btnArquivoLinks.Name = "btnArquivoLinks";
            this.btnArquivoLinks.Size = new System.Drawing.Size(101, 23);
            this.btnArquivoLinks.TabIndex = 27;
            this.btnArquivoLinks.Text = "Arquivo de links";
            this.btnArquivoLinks.UseVisualStyleBackColor = true;
            this.btnArquivoLinks.Click += new System.EventHandler(this.procurarArquivo);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Qt. Links:";
            // 
            // lQtLinks
            // 
            this.lQtLinks.AutoSize = true;
            this.lQtLinks.Location = new System.Drawing.Point(58, 66);
            this.lQtLinks.Name = "lQtLinks";
            this.lQtLinks.Size = new System.Drawing.Size(10, 13);
            this.lQtLinks.TabIndex = 29;
            this.lQtLinks.Text = "-";
            // 
            // radioSegundos
            // 
            this.radioSegundos.AutoSize = true;
            this.radioSegundos.Location = new System.Drawing.Point(367, 170);
            this.radioSegundos.Name = "radioSegundos";
            this.radioSegundos.Size = new System.Drawing.Size(73, 17);
            this.radioSegundos.TabIndex = 30;
            this.radioSegundos.TabStop = true;
            this.radioSegundos.Text = "Segundos";
            this.radioSegundos.UseVisualStyleBackColor = true;
            // 
            // radioMinutos
            // 
            this.radioMinutos.AutoSize = true;
            this.radioMinutos.Location = new System.Drawing.Point(367, 192);
            this.radioMinutos.Name = "radioMinutos";
            this.radioMinutos.Size = new System.Drawing.Size(62, 17);
            this.radioMinutos.TabIndex = 31;
            this.radioMinutos.TabStop = true;
            this.radioMinutos.Text = "Minutos";
            this.radioMinutos.UseVisualStyleBackColor = true;
            // 
            // btnZerarContador
            // 
            this.btnZerarContador.Location = new System.Drawing.Point(12, 230);
            this.btnZerarContador.Name = "btnZerarContador";
            this.btnZerarContador.Size = new System.Drawing.Size(101, 23);
            this.btnZerarContador.TabIndex = 32;
            this.btnZerarContador.Text = "Enviar do começo";
            this.btnZerarContador.UseVisualStyleBackColor = true;
            this.btnZerarContador.Click += new System.EventHandler(this.zerarCon);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 356);
            this.Controls.Add(this.btnZerarContador);
            this.Controls.Add(this.radioMinutos);
            this.Controls.Add(this.radioSegundos);
            this.Controls.Add(this.lQtLinks);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnArquivoLinks);
            this.Controls.Add(this.btnSetTimer);
            this.Controls.Add(this.lIntervalo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIntervalo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.richLinks);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnGrupo);
            this.Controls.Add(this.btnCon);
            this.Controls.Add(this.lEnvio);
            this.Controls.Add(this.lGrupo);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label lGrupo;
        private System.Windows.Forms.Label lEnvio;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox richLinks;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIntervalo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lIntervalo;
        private System.Windows.Forms.Button btnSetTimer;
        private System.Windows.Forms.Button btnArquivoLinks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lQtLinks;
        private System.Windows.Forms.RadioButton radioSegundos;
        private System.Windows.Forms.RadioButton radioMinutos;
        private System.Windows.Forms.Button btnZerarContador;
    }
}

