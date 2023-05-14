
namespace PIA
{
    partial class RegistroE
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
            this.btn_salida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_nombre_r = new System.Windows.Forms.TextBox();
            this.txt_calle = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_apellido_r = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_salida
            // 
            this.btn_salida.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_salida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salida.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salida.Location = new System.Drawing.Point(78, 22);
            this.btn_salida.Name = "btn_salida";
            this.btn_salida.Size = new System.Drawing.Size(205, 39);
            this.btn_salida.TabIndex = 1;
            this.btn_salida.Text = "REGISTRAR SALIDA";
            this.btn_salida.UseVisualStyleBackColor = false;
            this.btn_salida.Click += new System.EventHandler(this.btn_salida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(44, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "CONTROL DE ENTRADA DE VISITANTE/PROVEEDOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(44, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "NOMBRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "APELLIDO";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MATRICULA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "MODELO DE AUTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 10;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_nombre.Location = new System.Drawing.Point(205, 157);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 11;
            this.txt_nombre.Tag = "";
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_apellido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_apellido.Location = new System.Drawing.Point(205, 184);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido.TabIndex = 12;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_matricula
            // 
            this.txt_matricula.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_matricula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_matricula.Location = new System.Drawing.Point(205, 213);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 13;
            this.txt_matricula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_matricula_KeyPress);
            // 
            // txt_modelo
            // 
            this.txt_modelo.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_modelo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_modelo.Location = new System.Drawing.Point(205, 248);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 14;
            this.txt_modelo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_modelo_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(44, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "DIRECCION DE DESTINO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "NOMBRE DE RESIDENTE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(44, 378);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "CALLE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(44, 409);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "NUMERO";
            // 
            // txt_nombre_r
            // 
            this.txt_nombre_r.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_nombre_r.Location = new System.Drawing.Point(205, 312);
            this.txt_nombre_r.Name = "txt_nombre_r";
            this.txt_nombre_r.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre_r.TabIndex = 20;
            this.txt_nombre_r.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_r_KeyPress);
            // 
            // txt_calle
            // 
            this.txt_calle.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_calle.Location = new System.Drawing.Point(205, 378);
            this.txt_calle.Name = "txt_calle";
            this.txt_calle.Size = new System.Drawing.Size(100, 20);
            this.txt_calle.TabIndex = 21;
            this.txt_calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_calle_KeyPress);
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_numero.Location = new System.Drawing.Point(205, 409);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 22;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 345);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "APELLIDO DE RESIDENTE";
            // 
            // txt_apellido_r
            // 
            this.txt_apellido_r.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_apellido_r.Location = new System.Drawing.Point(205, 345);
            this.txt_apellido_r.Name = "txt_apellido_r";
            this.txt_apellido_r.Size = new System.Drawing.Size(100, 20);
            this.txt_apellido_r.TabIndex = 25;
            this.txt_apellido_r.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_r_KeyPress);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.Location = new System.Drawing.Point(139, 449);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(89, 37);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(44, 129);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "CODIGO";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_codigo.Location = new System.Drawing.Point(205, 126);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigo.TabIndex = 28;
            // 
            // RegistroE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(368, 495);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_apellido_r);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.txt_calle);
            this.Controls.Add(this.txt_nombre_r);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salida);
            this.Name = "RegistroE";
            this.Text = "Registro De Entrada";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.RegistroE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_salida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_nombre_r;
        private System.Windows.Forms.TextBox txt_calle;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_apellido_r;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_codigo;
    }
}

