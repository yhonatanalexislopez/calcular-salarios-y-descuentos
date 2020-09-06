namespace calcular_salarios_y_descuentos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthorastrabajadas = new System.Windows.Forms.TextBox();
            this.btnsalarioBase = new System.Windows.Forms.Button();
            this.btndescuentos = new System.Windows.Forms.Button();
            this.lblsalarioBase = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblvalorsalud = new System.Windows.Forms.Label();
            this.lblvalorpencion = new System.Windows.Forms.Label();
            this.lblvalorccp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblvalorsalariofinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(198, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "calcular salarios y descuentos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(29, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingresar las horas trabajadas:";
            // 
            // txthorastrabajadas
            // 
            this.txthorastrabajadas.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthorastrabajadas.Location = new System.Drawing.Point(296, 138);
            this.txthorastrabajadas.Name = "txthorastrabajadas";
            this.txthorastrabajadas.Size = new System.Drawing.Size(175, 32);
            this.txthorastrabajadas.TabIndex = 2;
            // 
            // btnsalarioBase
            // 
            this.btnsalarioBase.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalarioBase.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnsalarioBase.Location = new System.Drawing.Point(33, 230);
            this.btnsalarioBase.Name = "btnsalarioBase";
            this.btnsalarioBase.Size = new System.Drawing.Size(132, 55);
            this.btnsalarioBase.TabIndex = 3;
            this.btnsalarioBase.Text = "salario Base";
            this.btnsalarioBase.UseVisualStyleBackColor = true;
            this.btnsalarioBase.Click += new System.EventHandler(this.btnsalarioBase_Click);
            // 
            // btndescuentos
            // 
            this.btndescuentos.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndescuentos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btndescuentos.Location = new System.Drawing.Point(33, 307);
            this.btndescuentos.Name = "btndescuentos";
            this.btndescuentos.Size = new System.Drawing.Size(132, 56);
            this.btndescuentos.TabIndex = 4;
            this.btndescuentos.Text = "descuentos";
            this.btndescuentos.UseVisualStyleBackColor = true;
            this.btndescuentos.Click += new System.EventHandler(this.btndescuentos_Click);
            // 
            // lblsalarioBase
            // 
            this.lblsalarioBase.AutoSize = true;
            this.lblsalarioBase.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsalarioBase.ForeColor = System.Drawing.Color.Black;
            this.lblsalarioBase.Location = new System.Drawing.Point(190, 245);
            this.lblsalarioBase.Name = "lblsalarioBase";
            this.lblsalarioBase.Size = new System.Drawing.Size(138, 24);
            this.lblsalarioBase.TabIndex = 5;
            this.lblsalarioBase.Text = "elsalarioBase";
            this.lblsalarioBase.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(190, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "salud:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(190, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "ccp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(190, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "pencion:";
            // 
            // lblvalorsalud
            // 
            this.lblvalorsalud.AutoSize = true;
            this.lblvalorsalud.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorsalud.ForeColor = System.Drawing.Color.Black;
            this.lblvalorsalud.Location = new System.Drawing.Point(292, 323);
            this.lblvalorsalud.Name = "lblvalorsalud";
            this.lblvalorsalud.Size = new System.Drawing.Size(111, 24);
            this.lblvalorsalud.TabIndex = 9;
            this.lblvalorsalud.Text = "valorsalud";
            // 
            // lblvalorpencion
            // 
            this.lblvalorpencion.AutoSize = true;
            this.lblvalorpencion.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorpencion.ForeColor = System.Drawing.Color.Black;
            this.lblvalorpencion.Location = new System.Drawing.Point(315, 389);
            this.lblvalorpencion.Name = "lblvalorpencion";
            this.lblvalorpencion.Size = new System.Drawing.Size(136, 24);
            this.lblvalorpencion.TabIndex = 10;
            this.lblvalorpencion.Text = "valorpension";
            // 
            // lblvalorccp
            // 
            this.lblvalorccp.AutoSize = true;
            this.lblvalorccp.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorccp.ForeColor = System.Drawing.Color.Black;
            this.lblvalorccp.Location = new System.Drawing.Point(312, 437);
            this.lblvalorccp.Name = "lblvalorccp";
            this.lblvalorccp.Size = new System.Drawing.Size(91, 24);
            this.lblvalorccp.TabIndex = 11;
            this.lblvalorccp.Text = "valorccp";
            this.lblvalorccp.Click += new System.EventHandler(this.lblvalorccp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(190, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "salario a pagar:";
            // 
            // lblvalorsalariofinal
            // 
            this.lblvalorsalariofinal.AutoSize = true;
            this.lblvalorsalariofinal.Font = new System.Drawing.Font("Calisto MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalorsalariofinal.ForeColor = System.Drawing.Color.Black;
            this.lblvalorsalariofinal.Location = new System.Drawing.Point(380, 501);
            this.lblvalorsalariofinal.Name = "lblvalorsalariofinal";
            this.lblvalorsalariofinal.Size = new System.Drawing.Size(172, 24);
            this.lblvalorsalariofinal.TabIndex = 13;
            this.lblvalorsalariofinal.Text = "valorsalariofinal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 544);
            this.Controls.Add(this.lblvalorsalariofinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblvalorccp);
            this.Controls.Add(this.lblvalorpencion);
            this.Controls.Add(this.lblvalorsalud);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblsalarioBase);
            this.Controls.Add(this.btndescuentos);
            this.Controls.Add(this.btnsalarioBase);
            this.Controls.Add(this.txthorastrabajadas);
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
        private System.Windows.Forms.TextBox txthorastrabajadas;
        private System.Windows.Forms.Button btnsalarioBase;
        private System.Windows.Forms.Button btndescuentos;
        private System.Windows.Forms.Label lblsalarioBase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblvalorsalud;
        private System.Windows.Forms.Label lblvalorpencion;
        private System.Windows.Forms.Label lblvalorccp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblvalorsalariofinal;
    }
}

