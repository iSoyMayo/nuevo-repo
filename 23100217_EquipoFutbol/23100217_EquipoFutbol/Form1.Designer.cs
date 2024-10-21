namespace _23100217_EquipoFutbol
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
            this.gbPosicionJugador = new System.Windows.Forms.GroupBox();
            this.rbDelantero = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbDefensa = new System.Windows.Forms.RadioButton();
            this.rbPortero = new System.Windows.Forms.RadioButton();
            this.gbDatosJugador = new System.Windows.Forms.GroupBox();
            this.txtGolesAnotados = new System.Windows.Forms.TextBox();
            this.txtMinJugados = new System.Windows.Forms.TextBox();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.txtNumJugador = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbPosicionJugador.SuspendLayout();
            this.gbDatosJugador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbPosicionJugador
            // 
            this.gbPosicionJugador.Controls.Add(this.rbDelantero);
            this.gbPosicionJugador.Controls.Add(this.rbMedio);
            this.gbPosicionJugador.Controls.Add(this.rbDefensa);
            this.gbPosicionJugador.Controls.Add(this.rbPortero);
            this.gbPosicionJugador.Location = new System.Drawing.Point(25, 31);
            this.gbPosicionJugador.Name = "gbPosicionJugador";
            this.gbPosicionJugador.Size = new System.Drawing.Size(156, 141);
            this.gbPosicionJugador.TabIndex = 0;
            this.gbPosicionJugador.TabStop = false;
            this.gbPosicionJugador.Text = "Posición del jugador";
            // 
            // rbDelantero
            // 
            this.rbDelantero.AutoSize = true;
            this.rbDelantero.Location = new System.Drawing.Point(6, 90);
            this.rbDelantero.Name = "rbDelantero";
            this.rbDelantero.Size = new System.Drawing.Size(71, 17);
            this.rbDelantero.TabIndex = 3;
            this.rbDelantero.TabStop = true;
            this.rbDelantero.Text = "Delantero";
            this.rbDelantero.UseVisualStyleBackColor = true;
            this.rbDelantero.CheckedChanged += new System.EventHandler(this.rbDelantero_CheckedChanged);
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(7, 67);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(54, 17);
            this.rbMedio.TabIndex = 2;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Medio";
            this.rbMedio.UseVisualStyleBackColor = true;
            this.rbMedio.CheckedChanged += new System.EventHandler(this.rbMedio_CheckedChanged);
            // 
            // rbDefensa
            // 
            this.rbDefensa.AutoSize = true;
            this.rbDefensa.Location = new System.Drawing.Point(7, 44);
            this.rbDefensa.Name = "rbDefensa";
            this.rbDefensa.Size = new System.Drawing.Size(65, 17);
            this.rbDefensa.TabIndex = 1;
            this.rbDefensa.TabStop = true;
            this.rbDefensa.Text = "Defensa";
            this.rbDefensa.UseVisualStyleBackColor = true;
            this.rbDefensa.CheckedChanged += new System.EventHandler(this.rbDefensa_CheckedChanged);
            // 
            // rbPortero
            // 
            this.rbPortero.AutoSize = true;
            this.rbPortero.Location = new System.Drawing.Point(7, 20);
            this.rbPortero.Name = "rbPortero";
            this.rbPortero.Size = new System.Drawing.Size(59, 17);
            this.rbPortero.TabIndex = 0;
            this.rbPortero.TabStop = true;
            this.rbPortero.Text = "Portero";
            this.rbPortero.UseVisualStyleBackColor = true;
            this.rbPortero.CheckedChanged += new System.EventHandler(this.rbPortero_CheckedChanged);
            // 
            // gbDatosJugador
            // 
            this.gbDatosJugador.Controls.Add(this.txtGolesAnotados);
            this.gbDatosJugador.Controls.Add(this.txtMinJugados);
            this.gbDatosJugador.Controls.Add(this.txtNombreJugador);
            this.gbDatosJugador.Controls.Add(this.txtNumJugador);
            this.gbDatosJugador.Controls.Add(this.label4);
            this.gbDatosJugador.Controls.Add(this.label3);
            this.gbDatosJugador.Controls.Add(this.label2);
            this.gbDatosJugador.Controls.Add(this.label1);
            this.gbDatosJugador.Location = new System.Drawing.Point(25, 207);
            this.gbDatosJugador.Name = "gbDatosJugador";
            this.gbDatosJugador.Size = new System.Drawing.Size(234, 162);
            this.gbDatosJugador.TabIndex = 1;
            this.gbDatosJugador.TabStop = false;
            this.gbDatosJugador.Text = "Datos del Jugador";
            // 
            // txtGolesAnotados
            // 
            this.txtGolesAnotados.Enabled = false;
            this.txtGolesAnotados.Location = new System.Drawing.Point(114, 106);
            this.txtGolesAnotados.Name = "txtGolesAnotados";
            this.txtGolesAnotados.Size = new System.Drawing.Size(100, 20);
            this.txtGolesAnotados.TabIndex = 7;
            // 
            // txtMinJugados
            // 
            this.txtMinJugados.Location = new System.Drawing.Point(114, 80);
            this.txtMinJugados.Name = "txtMinJugados";
            this.txtMinJugados.Size = new System.Drawing.Size(100, 20);
            this.txtMinJugados.TabIndex = 6;
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(114, 51);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJugador.TabIndex = 5;
            // 
            // txtNumJugador
            // 
            this.txtNumJugador.Location = new System.Drawing.Point(114, 25);
            this.txtNumJugador.Name = "txtNumJugador";
            this.txtNumJugador.Size = new System.Drawing.Size(100, 20);
            this.txtNumJugador.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(27, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Goles anotados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minutos Jugados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del Jugador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num. del Jugador";
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(257, 40);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(92, 40);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(257, 86);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(92, 40);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(257, 132);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 40);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 403);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.gbDatosJugador);
            this.Controls.Add(this.gbPosicionJugador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.gbPosicionJugador.ResumeLayout(false);
            this.gbPosicionJugador.PerformLayout();
            this.gbDatosJugador.ResumeLayout(false);
            this.gbDatosJugador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPosicionJugador;
        private System.Windows.Forms.RadioButton rbDelantero;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbDefensa;
        private System.Windows.Forms.RadioButton rbPortero;
        private System.Windows.Forms.GroupBox gbDatosJugador;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtGolesAnotados;
        private System.Windows.Forms.TextBox txtMinJugados;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.TextBox txtNumJugador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

