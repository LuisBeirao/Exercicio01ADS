namespace Portifolio
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmdImpares = new System.Windows.Forms.Button();
            this.cmdSoma = new System.Windows.Forms.Button();
            this.cmdDivisao = new System.Windows.Forms.Button();
            this.cmdQuadrados = new System.Windows.Forms.Button();
            this.cmdSomaPares = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 12);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultado.Size = new System.Drawing.Size(776, 232);
            this.txtResultado.TabIndex = 0;
            // 
            // cmdImpares
            // 
            this.cmdImpares.Location = new System.Drawing.Point(12, 250);
            this.cmdImpares.Name = "cmdImpares";
            this.cmdImpares.Size = new System.Drawing.Size(129, 30);
            this.cmdImpares.TabIndex = 1;
            this.cmdImpares.Text = "Impares 0 a 40";
            this.cmdImpares.UseVisualStyleBackColor = true;
            this.cmdImpares.Click += new System.EventHandler(this.cmdImpares_Click);
            // 
            // cmdSoma
            // 
            this.cmdSoma.Location = new System.Drawing.Point(147, 250);
            this.cmdSoma.Name = "cmdSoma";
            this.cmdSoma.Size = new System.Drawing.Size(129, 30);
            this.cmdSoma.TabIndex = 2;
            this.cmdSoma.Text = "Soma 0 a 100";
            this.cmdSoma.UseVisualStyleBackColor = true;
            this.cmdSoma.Click += new System.EventHandler(this.cmdSoma_Click);
            // 
            // cmdDivisao
            // 
            this.cmdDivisao.Location = new System.Drawing.Point(282, 250);
            this.cmdDivisao.Name = "cmdDivisao";
            this.cmdDivisao.Size = new System.Drawing.Size(129, 30);
            this.cmdDivisao.TabIndex = 3;
            this.cmdDivisao.Text = "Divisão por 4";
            this.cmdDivisao.UseVisualStyleBackColor = true;
            this.cmdDivisao.Click += new System.EventHandler(this.cmdDivisao_Click);
            // 
            // cmdQuadrados
            // 
            this.cmdQuadrados.Location = new System.Drawing.Point(417, 250);
            this.cmdQuadrados.Name = "cmdQuadrados";
            this.cmdQuadrados.Size = new System.Drawing.Size(129, 30);
            this.cmdQuadrados.TabIndex = 4;
            this.cmdQuadrados.Text = "Quadrados 15 a 200";
            this.cmdQuadrados.UseVisualStyleBackColor = true;
            this.cmdQuadrados.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdSomaPares
            // 
            this.cmdSomaPares.Location = new System.Drawing.Point(552, 250);
            this.cmdSomaPares.Name = "cmdSomaPares";
            this.cmdSomaPares.Size = new System.Drawing.Size(129, 30);
            this.cmdSomaPares.TabIndex = 5;
            this.cmdSomaPares.Text = "Soma pares 1 a 50";
            this.cmdSomaPares.UseVisualStyleBackColor = true;
            this.cmdSomaPares.Click += new System.EventHandler(this.cmdSomaPares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdSomaPares);
            this.Controls.Add(this.cmdQuadrados);
            this.Controls.Add(this.cmdDivisao);
            this.Controls.Add(this.cmdSoma);
            this.Controls.Add(this.cmdImpares);
            this.Controls.Add(this.txtResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button cmdImpares;
        private System.Windows.Forms.Button cmdSoma;
        private System.Windows.Forms.Button cmdDivisao;
        private System.Windows.Forms.Button cmdQuadrados;
        private System.Windows.Forms.Button cmdSomaPares;
    }
}

