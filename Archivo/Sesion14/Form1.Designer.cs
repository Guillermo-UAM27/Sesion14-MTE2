namespace Sesion14
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.btAgg = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(68, 72);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(281, 22);
            this.tbNombre.TabIndex = 3;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(68, 108);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(281, 22);
            this.tbEdad.TabIndex = 4;
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(68, 138);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(281, 22);
            this.tbNota.TabIndex = 5;
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(382, 78);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(155, 86);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Archivo para guardar datos.";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo:";
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(68, 175);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(281, 22);
            this.tbSexo.TabIndex = 9;
            // 
            // btAgg
            // 
            this.btAgg.Font = new System.Drawing.Font("Wide Latin", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAgg.Location = new System.Drawing.Point(556, 78);
            this.btAgg.Name = "btAgg";
            this.btAgg.Size = new System.Drawing.Size(157, 83);
            this.btAgg.TabIndex = 10;
            this.btAgg.Text = "Mostrar";
            this.btAgg.UseVisualStyleBackColor = true;
            this.btAgg.Click += new System.EventHandler(this.b_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(43, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(691, 196);
            this.listBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btAgg);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbNombre);
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
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.Button btAgg;
        private System.Windows.Forms.ListBox listBox1;
    }
}

