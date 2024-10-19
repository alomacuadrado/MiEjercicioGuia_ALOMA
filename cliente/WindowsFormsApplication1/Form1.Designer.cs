namespace WindowsFormsApplication1
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
			this.label2 = new System.Windows.Forms.Label();
			this.nombre = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.palindromo = new System.Windows.Forms.RadioButton();
			this.Mayusculas = new System.Windows.Forms.RadioButton();
			this.Longitud = new System.Windows.Forms.RadioButton();
			this.altura = new System.Windows.Forms.RadioButton();
			this.label3 = new System.Windows.Forms.Label();
			this.alturaBox = new System.Windows.Forms.TextBox();
			this.Bonito = new System.Windows.Forms.RadioButton();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.contlbl = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(342, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 25);
			this.label2.TabIndex = 1;
			this.label2.Text = "Insertar nombre";
			// 
			// nombre
			// 
			this.nombre.Location = new System.Drawing.Point(347, 76);
			this.nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.nombre.Name = "nombre";
			this.nombre.Size = new System.Drawing.Size(217, 22);
			this.nombre.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(31, 83);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 38);
			this.button1.TabIndex = 4;
			this.button1.Text = "CONECTAR";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(444, 215);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 28);
			this.button2.TabIndex = 5;
			this.button2.Text = "Enviar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.palindromo);
			this.groupBox1.Controls.Add(this.Mayusculas);
			this.groupBox1.Controls.Add(this.Longitud);
			this.groupBox1.Controls.Add(this.altura);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.alturaBox);
			this.groupBox1.Controls.Add(this.Bonito);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.nombre);
			this.groupBox1.Location = new System.Drawing.Point(31, 201);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(588, 272);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Peticion";
			// 
			// palindromo
			// 
			this.palindromo.AutoSize = true;
			this.palindromo.Location = new System.Drawing.Point(14, 188);
			this.palindromo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.palindromo.Name = "palindromo";
			this.palindromo.Size = new System.Drawing.Size(129, 20);
			this.palindromo.TabIndex = 11;
			this.palindromo.TabStop = true;
			this.palindromo.Text = "¿Es palíndromo?";
			this.palindromo.UseVisualStyleBackColor = true;
			this.palindromo.CheckedChanged += new System.EventHandler(this.palindromo_CheckedChanged);
			// 
			// Mayusculas
			// 
			this.Mayusculas.AutoSize = true;
			this.Mayusculas.Location = new System.Drawing.Point(14, 160);
			this.Mayusculas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Mayusculas.Name = "Mayusculas";
			this.Mayusculas.Size = new System.Drawing.Size(224, 20);
			this.Mayusculas.TabIndex = 10;
			this.Mayusculas.TabStop = true;
			this.Mayusculas.Text = "Dame mi nombre en mayúsculas\r\n";
			this.Mayusculas.UseVisualStyleBackColor = true;
			// 
			// Longitud
			// 
			this.Longitud.AutoSize = true;
			this.Longitud.Location = new System.Drawing.Point(14, 104);
			this.Longitud.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Longitud.Name = "Longitud";
			this.Longitud.Size = new System.Drawing.Size(209, 20);
			this.Longitud.TabIndex = 7;
			this.Longitud.TabStop = true;
			this.Longitud.Text = "Dime la longitud de mi nombre";
			this.Longitud.UseVisualStyleBackColor = true;
			// 
			// altura
			// 
			this.altura.AutoSize = true;
			this.altura.Location = new System.Drawing.Point(14, 132);
			this.altura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.altura.Name = "altura";
			this.altura.Size = new System.Drawing.Size(123, 20);
			this.altura.TabIndex = 7;
			this.altura.TabStop = true;
			this.altura.Text = "Dime si soy alto";
			this.altura.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(342, 124);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Insertar altura";
			// 
			// alturaBox
			// 
			this.alturaBox.Location = new System.Drawing.Point(347, 153);
			this.alturaBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.alturaBox.Name = "alturaBox";
			this.alturaBox.Size = new System.Drawing.Size(81, 22);
			this.alturaBox.TabIndex = 9;
			// 
			// Bonito
			// 
			this.Bonito.AutoSize = true;
			this.Bonito.Location = new System.Drawing.Point(14, 76);
			this.Bonito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Bonito.Name = "Bonito";
			this.Bonito.Size = new System.Drawing.Size(197, 20);
			this.Bonito.TabIndex = 8;
			this.Bonito.TabStop = true;
			this.Bonito.Text = "Dime si mi nombre es bonito";
			this.Bonito.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(31, 555);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(259, 65);
			this.button3.TabIndex = 10;
			this.button3.Text = "DESCONECTAR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(721, 248);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(160, 91);
			this.button4.TabIndex = 11;
			this.button4.Text = "¿Cúantos servicios?";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// contlbl
			// 
			this.contlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.contlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.contlbl.Location = new System.Drawing.Point(735, 354);
			this.contlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.contlbl.Name = "contlbl";
			this.contlbl.Size = new System.Drawing.Size(133, 77);
			this.contlbl.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 28);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(140, 31);
			this.label1.TabIndex = 12;
			this.label1.Text = "Peticiones";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightBlue;
			this.ClientSize = new System.Drawing.Size(988, 692);
			this.Controls.Add(this.contlbl);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.RadioButton altura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alturaBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton palindromo;
        private System.Windows.Forms.RadioButton Mayusculas;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label contlbl;
		private System.Windows.Forms.Label label1;
	}
}

