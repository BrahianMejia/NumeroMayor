namespace NumeroMayor
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
            this.btbir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumero1 = new System.Windows.Forms.TextBox();
            this.txtnumero2 = new System.Windows.Forms.TextBox();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.lblresultado2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbliguales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btbir
            // 
            this.btbir.Location = new System.Drawing.Point(514, 196);
            this.btbir.Name = "btbir";
            this.btbir.Size = new System.Drawing.Size(75, 23);
            this.btbir.TabIndex = 0;
            this.btbir.Text = "Ir";
            this.btbir.UseVisualStyleBackColor = true;
            this.btbir.Click += new System.EventHandler(this.btbir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite el primer número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite el segundo número:";
            // 
            // txtnumero1
            // 
            this.txtnumero1.Location = new System.Drawing.Point(386, 171);
            this.txtnumero1.Name = "txtnumero1";
            this.txtnumero1.Size = new System.Drawing.Size(100, 20);
            this.txtnumero1.TabIndex = 3;
            // 
            // txtnumero2
            // 
            this.txtnumero2.Location = new System.Drawing.Point(386, 226);
            this.txtnumero2.Name = "txtnumero2";
            this.txtnumero2.Size = new System.Drawing.Size(100, 20);
            this.txtnumero2.TabIndex = 4;
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.Location = new System.Drawing.Point(383, 287);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(35, 13);
            this.lblresultado1.TabIndex = 5;
            this.lblresultado1.Text = "label3";
            // 
            // lblresultado2
            // 
            this.lblresultado2.AutoSize = true;
            this.lblresultado2.Location = new System.Drawing.Point(383, 320);
            this.lblresultado2.Name = "lblresultado2";
            this.lblresultado2.Size = new System.Drawing.Size(35, 13);
            this.lblresultado2.TabIndex = 6;
            this.lblresultado2.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mayor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Menor:";
            // 
            // lbliguales
            // 
            this.lbliguales.AutoSize = true;
            this.lbliguales.Location = new System.Drawing.Point(383, 261);
            this.lbliguales.Name = "lbliguales";
            this.lbliguales.Size = new System.Drawing.Size(35, 13);
            this.lbliguales.TabIndex = 9;
            this.lbliguales.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbliguales);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblresultado2);
            this.Controls.Add(this.lblresultado1);
            this.Controls.Add(this.txtnumero2);
            this.Controls.Add(this.txtnumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumero1;
        private System.Windows.Forms.TextBox txtnumero2;
        private System.Windows.Forms.Label lblresultado1;
        private System.Windows.Forms.Label lblresultado2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbliguales;
    }
}

