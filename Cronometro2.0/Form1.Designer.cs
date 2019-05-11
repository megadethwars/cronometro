namespace Cronometro2._0
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.valores = new System.Windows.Forms.TrackBar();
            this.TypeRegresivo = new System.Windows.Forms.Button();
            this.Progresivo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Home = new System.Windows.Forms.Button();
            this.Opciones = new System.Windows.Forms.Button();
            this.milisegundos = new System.Windows.Forms.Label();
            this.segundos = new System.Windows.Forms.Label();
            this.minutos = new System.Windows.Forms.Label();
            this.horas = new System.Windows.Forms.Label();
            this.MENSAJE = new System.Windows.Forms.Label();
            this.ESTADO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            this.FormClosing += Form1_FormClosing;
            
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(27, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 187);
            this.panel1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Image = global::Cronometro2._0.Properties.Resources.play;
            this.Start.Location = new System.Drawing.Point(27, 81);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 60);
            this.Start.TabIndex = 1;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Image = global::Cronometro2._0.Properties.Resources.stop;
            this.Stop.Location = new System.Drawing.Point(340, 81);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(105, 60);
            this.Stop.TabIndex = 2;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // valores
            // 
            this.valores.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.valores.Location = new System.Drawing.Point(158, 82);
            this.valores.Maximum = 20;
            this.valores.Minimum = 10;
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(157, 45);
            this.valores.TabIndex = 3;
            this.valores.Value = 10;
            this.valores.Scroll += new System.EventHandler(this.valores_Scroll);
            // 
            // TypeRegresivo
            // 
            this.TypeRegresivo.Location = new System.Drawing.Point(27, 12);
            this.TypeRegresivo.Name = "TypeRegresivo";
            this.TypeRegresivo.Size = new System.Drawing.Size(107, 46);
            this.TypeRegresivo.TabIndex = 5;
            this.TypeRegresivo.Text = "Regresivo";
            this.TypeRegresivo.UseVisualStyleBackColor = true;
            this.TypeRegresivo.Click += new System.EventHandler(this.TypeRegresivo_Click);
            // 
            // Progresivo
            // 
            this.Progresivo.Location = new System.Drawing.Point(340, 12);
            this.Progresivo.Name = "Progresivo";
            this.Progresivo.Size = new System.Drawing.Size(105, 46);
            this.Progresivo.TabIndex = 6;
            this.Progresivo.Text = "Progresivo";
            this.Progresivo.UseVisualStyleBackColor = true;
            this.Progresivo.Click += new System.EventHandler(this.Progresivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Image = global::Cronometro2._0.Properties.Resources.circle_red;
            this.pictureBox1.Location = new System.Drawing.Point(807, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.Image = global::Cronometro2._0.Properties.Resources.home;
            this.Home.Location = new System.Drawing.Point(191, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(94, 46);
            this.Home.TabIndex = 8;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Opciones
            // 
            this.Opciones.Image = global::Cronometro2._0.Properties.Resources.icons8_llave_64;
            this.Opciones.Location = new System.Drawing.Point(793, 272);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(73, 62);
            this.Opciones.TabIndex = 7;
            this.Opciones.UseVisualStyleBackColor = true;
            this.Opciones.Click += new System.EventHandler(this.Opciones_Click);
            // 
            // milisegundos
            // 
            this.milisegundos.AutoSize = true;
            this.milisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milisegundos.Location = new System.Drawing.Point(809, 147);
            this.milisegundos.Name = "milisegundos";
            this.milisegundos.Size = new System.Drawing.Size(39, 42);
            this.milisegundos.TabIndex = 11;
            this.milisegundos.Text = "0";
            // 
            // segundos
            // 
            this.segundos.AutoSize = true;
            this.segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.Location = new System.Drawing.Point(712, 147);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(39, 42);
            this.segundos.TabIndex = 12;
            this.segundos.Text = "0";
            // 
            // minutos
            // 
            this.minutos.AutoSize = true;
            this.minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.Location = new System.Drawing.Point(625, 147);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(39, 42);
            this.minutos.TabIndex = 13;
            this.minutos.Text = "0";
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.Location = new System.Drawing.Point(519, 147);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(39, 42);
            this.horas.TabIndex = 14;
            this.horas.Text = "0";
            // 
            // MENSAJE
            // 
            this.MENSAJE.AutoSize = true;
            this.MENSAJE.BackColor = System.Drawing.Color.Green;
            this.MENSAJE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENSAJE.Location = new System.Drawing.Point(451, 9);
            this.MENSAJE.Name = "MENSAJE";
            this.MENSAJE.Size = new System.Drawing.Size(121, 31);
            this.MENSAJE.TabIndex = 15;
            this.MENSAJE.Text = "CRONO";
            
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSize = true;
            this.ESTADO.BackColor = System.Drawing.Color.MidnightBlue;
            this.ESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESTADO.Location = new System.Drawing.Point(480, 303);
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Size = new System.Drawing.Size(184, 31);
            this.ESTADO.TabIndex = 16;
            this.ESTADO.Text = "EN REPOSO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cronometro2._0.Properties.Resources.qzEYl1Y;
            this.ClientSize = new System.Drawing.Size(878, 362);
            this.Controls.Add(this.ESTADO);
            this.Controls.Add(this.MENSAJE);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.minutos);
            this.Controls.Add(this.segundos);
            this.Controls.Add(this.milisegundos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Opciones);
            this.Controls.Add(this.Progresivo);
            this.Controls.Add(this.TypeRegresivo);
            this.Controls.Add(this.valores);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TrackBar valores;
        private System.Windows.Forms.Button TypeRegresivo;
        private System.Windows.Forms.Button Progresivo;
        private System.Windows.Forms.Button Opciones;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label milisegundos;
        private System.Windows.Forms.Label segundos;
        private System.Windows.Forms.Label minutos;
        private System.Windows.Forms.Label horas;
        private System.Windows.Forms.Label MENSAJE;
        private System.Windows.Forms.Label ESTADO;
    }
}

