namespace ListaDeContatosT7
{
    partial class plano
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
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.DigitarNome = new System.Windows.Forms.Label();
            this.DigitarSobrenome = new System.Windows.Forms.Label();
            this.DigitarTelefone = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(79, 78);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(191, 20);
            this.textBoxNome.TabIndex = 0;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(79, 119);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(191, 20);
            this.textBoxSobrenome.TabIndex = 1;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(79, 164);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(191, 20);
            this.textBoxTelefone.TabIndex = 2;
            // 
            // DigitarNome
            // 
            this.DigitarNome.AutoSize = true;
            this.DigitarNome.Location = new System.Drawing.Point(26, 81);
            this.DigitarNome.Name = "DigitarNome";
            this.DigitarNome.Size = new System.Drawing.Size(35, 13);
            this.DigitarNome.TabIndex = 3;
            this.DigitarNome.Text = "Nome";
            // 
            // DigitarSobrenome
            // 
            this.DigitarSobrenome.AutoSize = true;
            this.DigitarSobrenome.Location = new System.Drawing.Point(12, 122);
            this.DigitarSobrenome.Name = "DigitarSobrenome";
            this.DigitarSobrenome.Size = new System.Drawing.Size(61, 13);
            this.DigitarSobrenome.TabIndex = 5;
            this.DigitarSobrenome.Text = "Sobrenome";
            // 
            // DigitarTelefone
            // 
            this.DigitarTelefone.AutoSize = true;
            this.DigitarTelefone.Location = new System.Drawing.Point(17, 168);
            this.DigitarTelefone.Name = "DigitarTelefone";
            this.DigitarTelefone.Size = new System.Drawing.Size(49, 13);
            this.DigitarTelefone.TabIndex = 6;
            this.DigitarTelefone.Text = "Telefone";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(304, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 342);
            this.listBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 102);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(517, 431);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DigitarTelefone);
            this.Controls.Add(this.DigitarSobrenome);
            this.Controls.Add(this.DigitarNome);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxNome);
            this.Name = "plano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNome;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.Label DigitarNome;
        private System.Windows.Forms.Label DigitarSobrenome;
        private System.Windows.Forms.Label DigitarTelefone;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
    }
}

