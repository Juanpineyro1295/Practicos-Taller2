namespace Practico_4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TDesde = new System.Windows.Forms.TextBox();
            this.THasta = new System.Windows.Forms.TextBox();
            this.LBNum = new System.Windows.Forms.ListBox();
            this.BFuncion = new System.Windows.Forms.Button();
            this.BPares = new System.Windows.Forms.Button();
            this.BImpares = new System.Windows.Forms.Button();
            this.BPrimos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Desde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lista de Números";
            // 
            // TDesde
            // 
            this.TDesde.Location = new System.Drawing.Point(86, 69);
            this.TDesde.Multiline = true;
            this.TDesde.Name = "TDesde";
            this.TDesde.Size = new System.Drawing.Size(100, 20);
            this.TDesde.TabIndex = 3;
            // 
            // THasta
            // 
            this.THasta.Location = new System.Drawing.Point(86, 122);
            this.THasta.Multiline = true;
            this.THasta.Name = "THasta";
            this.THasta.Size = new System.Drawing.Size(100, 20);
            this.THasta.TabIndex = 4;
            // 
            // LBNum
            // 
            this.LBNum.FormattingEnabled = true;
            this.LBNum.Location = new System.Drawing.Point(356, 69);
            this.LBNum.Name = "LBNum";
            this.LBNum.Size = new System.Drawing.Size(243, 199);
            this.LBNum.TabIndex = 5;
            this.LBNum.SelectedIndexChanged += new System.EventHandler(this.LBNum_SelectedIndexChanged);
            // 
            // BFuncion
            // 
            this.BFuncion.Location = new System.Drawing.Point(212, 81);
            this.BFuncion.Name = "BFuncion";
            this.BFuncion.Size = new System.Drawing.Size(119, 32);
            this.BFuncion.TabIndex = 6;
            this.BFuncion.Text = "Generar Función";
            this.BFuncion.UseVisualStyleBackColor = true;
            this.BFuncion.Click += new System.EventHandler(this.BFuncion_Click);
            // 
            // BPares
            // 
            this.BPares.Location = new System.Drawing.Point(212, 136);
            this.BPares.Name = "BPares";
            this.BPares.Size = new System.Drawing.Size(119, 27);
            this.BPares.TabIndex = 7;
            this.BPares.Text = "Pares";
            this.BPares.UseVisualStyleBackColor = true;
            this.BPares.Click += new System.EventHandler(this.BPares_Click);
            // 
            // BImpares
            // 
            this.BImpares.Location = new System.Drawing.Point(212, 186);
            this.BImpares.Name = "BImpares";
            this.BImpares.Size = new System.Drawing.Size(119, 29);
            this.BImpares.TabIndex = 8;
            this.BImpares.Text = "Impares";
            this.BImpares.UseVisualStyleBackColor = true;
            this.BImpares.Click += new System.EventHandler(this.BImpares_Click);
            // 
            // BPrimos
            // 
            this.BPrimos.Location = new System.Drawing.Point(212, 239);
            this.BPrimos.Name = "BPrimos";
            this.BPrimos.Size = new System.Drawing.Size(119, 29);
            this.BPrimos.TabIndex = 9;
            this.BPrimos.Text = "Primos";
            this.BPrimos.UseVisualStyleBackColor = true;
            this.BPrimos.Click += new System.EventHandler(this.BPrimos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.BPrimos);
            this.Controls.Add(this.BImpares);
            this.Controls.Add(this.BPares);
            this.Controls.Add(this.BFuncion);
            this.Controls.Add(this.LBNum);
            this.Controls.Add(this.THasta);
            this.Controls.Add(this.TDesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TDesde;
        private System.Windows.Forms.TextBox THasta;
        private System.Windows.Forms.ListBox LBNum;
        private System.Windows.Forms.Button BFuncion;
        private System.Windows.Forms.Button BPares;
        private System.Windows.Forms.Button BImpares;
        private System.Windows.Forms.Button BPrimos;
    }
}

