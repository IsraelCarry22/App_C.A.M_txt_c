namespace App_C.A.M_txt_c
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
            this.Txtpagina = new System.Windows.Forms.TextBox();
            this.Btmlimpiar = new System.Windows.Forms.Button();
            this.Btmabrir = new System.Windows.Forms.Button();
            this.Btmguardar = new System.Windows.Forms.Button();
            this.Btmguardarcomo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pagina de Texto";
            // 
            // Txtpagina
            // 
            this.Txtpagina.Location = new System.Drawing.Point(12, 49);
            this.Txtpagina.Multiline = true;
            this.Txtpagina.Name = "Txtpagina";
            this.Txtpagina.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txtpagina.Size = new System.Drawing.Size(352, 389);
            this.Txtpagina.TabIndex = 1;
            // 
            // Btmlimpiar
            // 
            this.Btmlimpiar.Location = new System.Drawing.Point(370, 49);
            this.Btmlimpiar.Name = "Btmlimpiar";
            this.Btmlimpiar.Size = new System.Drawing.Size(107, 36);
            this.Btmlimpiar.TabIndex = 2;
            this.Btmlimpiar.Text = "Limpiar";
            this.Btmlimpiar.UseVisualStyleBackColor = true;
            this.Btmlimpiar.Click += new System.EventHandler(this.Btmlimpiar_Click);
            // 
            // Btmabrir
            // 
            this.Btmabrir.Location = new System.Drawing.Point(370, 91);
            this.Btmabrir.Name = "Btmabrir";
            this.Btmabrir.Size = new System.Drawing.Size(107, 36);
            this.Btmabrir.TabIndex = 3;
            this.Btmabrir.Text = "Abrir";
            this.Btmabrir.UseVisualStyleBackColor = true;
            this.Btmabrir.Click += new System.EventHandler(this.Btmabrir_Click);
            // 
            // Btmguardar
            // 
            this.Btmguardar.Location = new System.Drawing.Point(370, 133);
            this.Btmguardar.Name = "Btmguardar";
            this.Btmguardar.Size = new System.Drawing.Size(107, 36);
            this.Btmguardar.TabIndex = 4;
            this.Btmguardar.Text = "Guardar";
            this.Btmguardar.UseVisualStyleBackColor = true;
            this.Btmguardar.Click += new System.EventHandler(this.Btmguardar_Click);
            // 
            // Btmguardarcomo
            // 
            this.Btmguardarcomo.Location = new System.Drawing.Point(370, 175);
            this.Btmguardarcomo.Name = "Btmguardarcomo";
            this.Btmguardarcomo.Size = new System.Drawing.Size(107, 36);
            this.Btmguardarcomo.TabIndex = 5;
            this.Btmguardarcomo.Text = "Guardar Como";
            this.Btmguardarcomo.UseVisualStyleBackColor = true;
            this.Btmguardarcomo.Click += new System.EventHandler(this.Btmguardarcomo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(489, 450);
            this.Controls.Add(this.Btmguardarcomo);
            this.Controls.Add(this.Btmguardar);
            this.Controls.Add(this.Btmabrir);
            this.Controls.Add(this.Btmlimpiar);
            this.Controls.Add(this.Txtpagina);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtpagina;
        private System.Windows.Forms.Button Btmlimpiar;
        private System.Windows.Forms.Button Btmabrir;
        private System.Windows.Forms.Button Btmguardar;
        private System.Windows.Forms.Button Btmguardarcomo;
    }
}

