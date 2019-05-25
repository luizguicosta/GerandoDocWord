namespace GerarRelatorio.Presentation
{
    partial class Form1
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
            this.btnGerarRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbSobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.dtAdmissao = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtPromocao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbDescricao = new System.Windows.Forms.RichTextBox();
            this.tbIdade = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerarRelatorio
            // 
            this.btnGerarRelatorio.Location = new System.Drawing.Point(345, 399);
            this.btnGerarRelatorio.Name = "btnGerarRelatorio";
            this.btnGerarRelatorio.Size = new System.Drawing.Size(127, 41);
            this.btnGerarRelatorio.TabIndex = 0;
            this.btnGerarRelatorio.Text = "Gerar Relatório";
            this.btnGerarRelatorio.UseVisualStyleBackColor = true;
            this.btnGerarRelatorio.Click += new System.EventHandler(this.BtnGerarRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(16, 30);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(239, 20);
            this.tbNome.TabIndex = 2;
            // 
            // tbSobrenome
            // 
            this.tbSobrenome.Location = new System.Drawing.Point(16, 72);
            this.tbSobrenome.Name = "tbSobrenome";
            this.tbSobrenome.Size = new System.Drawing.Size(239, 20);
            this.tbSobrenome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Nascimento";
            // 
            // dtNascimento
            // 
            this.dtNascimento.Location = new System.Drawing.Point(272, 30);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(200, 20);
            this.dtNascimento.TabIndex = 8;
            // 
            // dtAdmissao
            // 
            this.dtAdmissao.Location = new System.Drawing.Point(272, 72);
            this.dtAdmissao.Name = "dtAdmissao";
            this.dtAdmissao.Size = new System.Drawing.Size(200, 20);
            this.dtAdmissao.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data de Admissão";
            // 
            // dtPromocao
            // 
            this.dtPromocao.Location = new System.Drawing.Point(272, 114);
            this.dtPromocao.Name = "dtPromocao";
            this.dtPromocao.Size = new System.Drawing.Size(200, 20);
            this.dtPromocao.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data de Promoção";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Descrição";
            // 
            // rtbDescricao
            // 
            this.rtbDescricao.Location = new System.Drawing.Point(16, 160);
            this.rtbDescricao.Name = "rtbDescricao";
            this.rtbDescricao.Size = new System.Drawing.Size(456, 233);
            this.rtbDescricao.TabIndex = 14;
            this.rtbDescricao.Text = "";
            // 
            // tbIdade
            // 
            this.tbIdade.Location = new System.Drawing.Point(16, 114);
            this.tbIdade.Name = "tbIdade";
            this.tbIdade.Size = new System.Drawing.Size(120, 20);
            this.tbIdade.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.tbIdade);
            this.Controls.Add(this.rtbDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtPromocao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtAdmissao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSobrenome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerarRelatorio);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Relatório de pessoa";
            ((System.ComponentModel.ISupportInitialize)(this.tbIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbSobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.DateTimePicker dtAdmissao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtPromocao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtbDescricao;
        private System.Windows.Forms.NumericUpDown tbIdade;
    }
}

