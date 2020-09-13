namespace GerarChaveNotaFiscal
{
    partial class GerarChaveNotaFiscal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroNota = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataEmissao = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCnpjExportador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonCopiar = new System.Windows.Forms.Button();
            this.btnCnpjBTP = new System.Windows.Forms.Button();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChaveValidar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonGerar
            // 
            this.buttonGerar.Location = new System.Drawing.Point(417, 45);
            this.buttonGerar.Name = "buttonGerar";
            this.buttonGerar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerar.TabIndex = 4;
            this.buttonGerar.Text = "Gerar";
            this.buttonGerar.UseVisualStyleBackColor = true;
            this.buttonGerar.Click += new System.EventHandler(this.buttonGerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // txtNumeroNota
            // 
            this.txtNumeroNota.Location = new System.Drawing.Point(82, 16);
            this.txtNumeroNota.MaxLength = 9;
            this.txtNumeroNota.Name = "txtNumeroNota";
            this.txtNumeroNota.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroNota.TabIndex = 0;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(245, 16);
            this.txtSerie.MaxLength = 3;
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(68, 20);
            this.txtSerie.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Série:";
            // 
            // dtpDataEmissao
            // 
            this.dtpDataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataEmissao.Location = new System.Drawing.Point(399, 16);
            this.dtpDataEmissao.Name = "dtpDataEmissao";
            this.dtpDataEmissao.Size = new System.Drawing.Size(93, 20);
            this.dtpDataEmissao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Emissão:";
            // 
            // txtCnpjExportador
            // 
            this.txtCnpjExportador.Location = new System.Drawing.Point(82, 45);
            this.txtCnpjExportador.MaxLength = 14;
            this.txtCnpjExportador.Name = "txtCnpjExportador";
            this.txtCnpjExportador.Size = new System.Drawing.Size(137, 20);
            this.txtCnpjExportador.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "CNPJ (Exp):";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(15, 97);
            this.txtChave.Name = "txtChave";
            this.txtChave.ReadOnly = true;
            this.txtChave.Size = new System.Drawing.Size(328, 20);
            this.txtChave.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chave";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(430, 94);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonCopiar
            // 
            this.buttonCopiar.Location = new System.Drawing.Point(349, 94);
            this.buttonCopiar.Name = "buttonCopiar";
            this.buttonCopiar.Size = new System.Drawing.Size(75, 23);
            this.buttonCopiar.TabIndex = 6;
            this.buttonCopiar.Text = "Copiar";
            this.buttonCopiar.UseVisualStyleBackColor = true;
            this.buttonCopiar.Click += new System.EventHandler(this.buttonCopiar_Click);
            // 
            // btnCnpjBTP
            // 
            this.btnCnpjBTP.Location = new System.Drawing.Point(225, 45);
            this.btnCnpjBTP.Name = "btnCnpjBTP";
            this.btnCnpjBTP.Size = new System.Drawing.Size(108, 23);
            this.btnCnpjBTP.TabIndex = 12;
            this.btnCnpjBTP.Text = "CNPJ HLC";
            this.btnCnpjBTP.UseVisualStyleBackColor = true;
            this.btnCnpjBTP.Click += new System.EventHandler(this.btnCnpjBTP_Click);
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(349, 142);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 14;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Chave";
            // 
            // txtChaveValidar
            // 
            this.txtChaveValidar.Location = new System.Drawing.Point(15, 145);
            this.txtChaveValidar.Name = "txtChaveValidar";
            this.txtChaveValidar.Size = new System.Drawing.Size(328, 20);
            this.txtChaveValidar.TabIndex = 13;
            // 
            // GerarChaveNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 170);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtChaveValidar);
            this.Controls.Add(this.btnCnpjBTP);
            this.Controls.Add(this.buttonCopiar);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.txtCnpjExportador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataEmissao);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumeroNota);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGerar);
            this.MaximizeBox = false;
            this.Name = "GerarChaveNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar Chave Nota Fiscal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroNota;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataEmissao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCnpjExportador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonCopiar;
        private System.Windows.Forms.Button btnCnpjBTP;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtChaveValidar;
    }
}

