namespace WhatsBot
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtConvite = new System.Windows.Forms.TextBox();
            this.lblConvite = new System.Windows.Forms.Label();
            this.txtMensagemApp = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(145, 368);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(293, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(542, 368);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConvite
            // 
            this.txtConvite.Location = new System.Drawing.Point(145, 86);
            this.txtConvite.Name = "txtConvite";
            this.txtConvite.Size = new System.Drawing.Size(513, 20);
            this.txtConvite.TabIndex = 2;
            // 
            // lblConvite
            // 
            this.lblConvite.AutoSize = true;
            this.lblConvite.Location = new System.Drawing.Point(70, 89);
            this.lblConvite.Name = "lblConvite";
            this.lblConvite.Size = new System.Drawing.Size(69, 13);
            this.lblConvite.TabIndex = 3;
            this.lblConvite.Text = "Link Convite:";
            // 
            // txtMensagemApp
            // 
            this.txtMensagemApp.Location = new System.Drawing.Point(145, 124);
            this.txtMensagemApp.Multiline = true;
            this.txtMensagemApp.Name = "txtMensagemApp";
            this.txtMensagemApp.Size = new System.Drawing.Size(513, 110);
            this.txtMensagemApp.TabIndex = 4;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(77, 124);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(62, 13);
            this.lblMensagem.TabIndex = 5;
            this.lblMensagem.Text = "Mensagem:";
            // 
            // txtLog
            // 
            this.txtLog.Enabled = false;
            this.txtLog.Location = new System.Drawing.Point(145, 240);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(513, 109);
            this.txtLog.TabIndex = 6;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(107, 243);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(32, 13);
            this.lblLog.TabIndex = 7;
            this.lblLog.Text = "LOG:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 493);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtMensagemApp);
            this.Controls.Add(this.lblConvite);
            this.Controls.Add(this.txtConvite);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtConvite;
        private System.Windows.Forms.Label lblConvite;
        private System.Windows.Forms.TextBox txtMensagemApp;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
    }
}

