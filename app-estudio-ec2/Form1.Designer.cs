namespace app_estudio_ec2
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lstNota1 = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstNota2 = new System.Windows.Forms.ListBox();
            this.lstNota3 = new System.Windows.Forms.ListBox();
            this.lstPromedio = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formulario de Notas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(220, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 1";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(80, 105);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(120, 95);
            this.lstNombres.TabIndex = 5;
            this.lstNombres.SelectedIndexChanged += new System.EventHandler(this.lstNombres_SelectedIndexChanged);
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(274, 59);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(120, 20);
            this.txtNota1.TabIndex = 6;
            // 
            // lstNota1
            // 
            this.lstNota1.FormattingEnabled = true;
            this.lstNota1.Location = new System.Drawing.Point(274, 105);
            this.lstNota1.Name = "lstNota1";
            this.lstNota1.Size = new System.Drawing.Size(120, 95);
            this.lstNota1.TabIndex = 7;
            this.lstNota1.SelectedIndexChanged += new System.EventHandler(this.lstNota1_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(24, 243);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 47);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(183, 243);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(103, 47);
            this.btnQuitar.TabIndex = 9;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(344, 243);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 47);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(327, 338);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(120, 20);
            this.txtPromedio.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(223, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Promedio General";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(464, 59);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(120, 20);
            this.txtNota2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(410, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Nota 2";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(656, 59);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(120, 20);
            this.txtNota3.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(602, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nota 3";
            // 
            // lstNota2
            // 
            this.lstNota2.FormattingEnabled = true;
            this.lstNota2.Location = new System.Drawing.Point(464, 105);
            this.lstNota2.Name = "lstNota2";
            this.lstNota2.Size = new System.Drawing.Size(120, 95);
            this.lstNota2.TabIndex = 17;
            this.lstNota2.SelectedIndexChanged += new System.EventHandler(this.lstNota2_SelectedIndexChanged);
            // 
            // lstNota3
            // 
            this.lstNota3.FormattingEnabled = true;
            this.lstNota3.Location = new System.Drawing.Point(656, 105);
            this.lstNota3.Name = "lstNota3";
            this.lstNota3.Size = new System.Drawing.Size(120, 95);
            this.lstNota3.TabIndex = 18;
            this.lstNota3.SelectedIndexChanged += new System.EventHandler(this.lstNota3_SelectedIndexChanged);
            // 
            // lstPromedio
            // 
            this.lstPromedio.FormattingEnabled = true;
            this.lstPromedio.Location = new System.Drawing.Point(848, 105);
            this.lstPromedio.Name = "lstPromedio";
            this.lstPromedio.Size = new System.Drawing.Size(120, 95);
            this.lstPromedio.TabIndex = 21;
            this.lstPromedio.SelectedIndexChanged += new System.EventHandler(this.lstPromedio_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(794, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Promedio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 387);
            this.Controls.Add(this.lstPromedio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstNota3);
            this.Controls.Add(this.lstNota2);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstNota1);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Formulario de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.ListBox lstNota1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstNota2;
        private System.Windows.Forms.ListBox lstNota3;
        private System.Windows.Forms.ListBox lstPromedio;
        private System.Windows.Forms.Label label7;
    }
}

