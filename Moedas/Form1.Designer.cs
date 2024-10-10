namespace Moedas
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
            this.txbNew = new System.Windows.Forms.TextBox();
            this.gbCambio = new System.Windows.Forms.GroupBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.gbConversor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txbEuro = new System.Windows.Forms.TextBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.cbDinheiro = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbConvert = new System.Windows.Forms.ComboBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.txbDinheiro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCambio.SuspendLayout();
            this.gbConversor.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbNew
            // 
            this.txbNew.Location = new System.Drawing.Point(245, 37);
            this.txbNew.Name = "txbNew";
            this.txbNew.Size = new System.Drawing.Size(100, 20);
            this.txbNew.TabIndex = 0;
            // 
            // gbCambio
            // 
            this.gbCambio.Controls.Add(this.lblAviso);
            this.gbCambio.Controls.Add(this.txbEuro);
            this.gbCambio.Controls.Add(this.lblEuro);
            this.gbCambio.Controls.Add(this.lblCambio);
            this.gbCambio.Controls.Add(this.txbNew);
            this.gbCambio.Location = new System.Drawing.Point(47, 28);
            this.gbCambio.Name = "gbCambio";
            this.gbCambio.Size = new System.Drawing.Size(353, 220);
            this.gbCambio.TabIndex = 1;
            this.gbCambio.TabStop = false;
            this.gbCambio.Text = "Taxa de câmbio";
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(6, 37);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(35, 13);
            this.lblCambio.TabIndex = 0;
            this.lblCambio.Text = "label1";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(176, 254);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // gbConversor
            // 
            this.gbConversor.Controls.Add(this.label3);
            this.gbConversor.Controls.Add(this.txbDinheiro);
            this.gbConversor.Controls.Add(this.cbConvert);
            this.gbConversor.Controls.Add(this.label2);
            this.gbConversor.Controls.Add(this.cbDinheiro);
            this.gbConversor.Controls.Add(this.label1);
            this.gbConversor.Location = new System.Drawing.Point(461, 28);
            this.gbConversor.Name = "gbConversor";
            this.gbConversor.Size = new System.Drawing.Size(267, 220);
            this.gbConversor.TabIndex = 3;
            this.gbConversor.TabStop = false;
            this.gbConversor.Text = "Conversão";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qual Moeda você está usando?";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Location = new System.Drawing.Point(7, 64);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(35, 13);
            this.lblEuro.TabIndex = 1;
            this.lblEuro.Text = "label2";
            // 
            // txbEuro
            // 
            this.txbEuro.Location = new System.Drawing.Point(245, 64);
            this.txbEuro.Name = "txbEuro";
            this.txbEuro.Size = new System.Drawing.Size(100, 20);
            this.txbEuro.TabIndex = 2;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Location = new System.Drawing.Point(6, 139);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(35, 13);
            this.lblAviso.TabIndex = 3;
            this.lblAviso.Text = "label2";
            // 
            // cbDinheiro
            // 
            this.cbDinheiro.FormattingEnabled = true;
            this.cbDinheiro.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Real"});
            this.cbDinheiro.Location = new System.Drawing.Point(68, 56);
            this.cbDinheiro.Name = "cbDinheiro";
            this.cbDinheiro.Size = new System.Drawing.Size(121, 21);
            this.cbDinheiro.TabIndex = 4;
            this.cbDinheiro.Text = "Selecione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deseja converter para qual valor?";
            // 
            // cbConvert
            // 
            this.cbConvert.FormattingEnabled = true;
            this.cbConvert.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Real"});
            this.cbConvert.Location = new System.Drawing.Point(68, 131);
            this.cbConvert.Name = "cbConvert";
            this.cbConvert.Size = new System.Drawing.Size(121, 21);
            this.cbConvert.TabIndex = 6;
            this.cbConvert.Text = "Selecione";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(549, 254);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Converter";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // gbResult
            // 
            this.gbResult.Controls.Add(this.lblResult);
            this.gbResult.Location = new System.Drawing.Point(292, 297);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(241, 100);
            this.gbResult.TabIndex = 5;
            this.gbResult.TabStop = false;
            this.gbResult.Text = "Resultado";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(19, 45);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "label3";
            // 
            // txbDinheiro
            // 
            this.txbDinheiro.Location = new System.Drawing.Point(79, 194);
            this.txbDinheiro.Name = "txbDinheiro";
            this.txbDinheiro.Size = new System.Drawing.Size(100, 20);
            this.txbDinheiro.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Informe a quantia de dinheiro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.gbConversor);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.gbCambio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCambio.ResumeLayout(false);
            this.gbCambio.PerformLayout();
            this.gbConversor.ResumeLayout(false);
            this.gbConversor.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbNew;
        private System.Windows.Forms.GroupBox gbCambio;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox gbConversor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox txbEuro;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.ComboBox cbDinheiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbConvert;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txbDinheiro;
        private System.Windows.Forms.Label label3;
    }
}

