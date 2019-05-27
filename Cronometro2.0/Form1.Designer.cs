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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.SstatusCrono = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusmessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SstatusCrono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.Location = new System.Drawing.Point(27, 81);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(107, 60);
            this.Start.TabIndex = 1;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
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
            this.valores.Maximum = 4;
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(157, 45);
            this.valores.TabIndex = 3;
            this.valores.Scroll += new System.EventHandler(this.valores_Scroll);
            // 
            // TypeRegresivo
            // 
            this.TypeRegresivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Progresivo.BackColor = System.Drawing.Color.White;
            this.Progresivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progresivo.Location = new System.Drawing.Point(327, 12);
            this.Progresivo.Name = "Progresivo";
            this.Progresivo.Size = new System.Drawing.Size(118, 46);
            this.Progresivo.TabIndex = 6;
            this.Progresivo.Text = "Progresivo";
            this.Progresivo.UseVisualStyleBackColor = false;
            this.Progresivo.Click += new System.EventHandler(this.Progresivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(837, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.Location = new System.Drawing.Point(191, 12);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(94, 46);
            this.Home.TabIndex = 8;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Opciones
            // 
            this.Opciones.Image = ((System.Drawing.Image)(resources.GetObject("Opciones.Image")));
            this.Opciones.Location = new System.Drawing.Point(793, 227);
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
            this.milisegundos.ForeColor = System.Drawing.Color.White;
            this.milisegundos.Image = ((System.Drawing.Image)(resources.GetObject("milisegundos.Image")));
            this.milisegundos.Location = new System.Drawing.Point(766, 85);
            this.milisegundos.Name = "milisegundos";
            this.milisegundos.Size = new System.Drawing.Size(39, 42);
            this.milisegundos.TabIndex = 11;
            this.milisegundos.Text = "0";
            // 
            // segundos
            // 
            this.segundos.AutoSize = true;
            this.segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.ForeColor = System.Drawing.Color.White;
            this.segundos.Image = ((System.Drawing.Image)(resources.GetObject("segundos.Image")));
            this.segundos.Location = new System.Drawing.Point(697, 85);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(39, 42);
            this.segundos.TabIndex = 12;
            this.segundos.Text = "0";
            // 
            // minutos
            // 
            this.minutos.AutoSize = true;
            this.minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.ForeColor = System.Drawing.Color.White;
            this.minutos.Image = ((System.Drawing.Image)(resources.GetObject("minutos.Image")));
            this.minutos.Location = new System.Drawing.Point(577, 85);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(39, 42);
            this.minutos.TabIndex = 13;
            this.minutos.Text = "0";
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.ForeColor = System.Drawing.Color.White;
            this.horas.Image = ((System.Drawing.Image)(resources.GetObject("horas.Image")));
            this.horas.Location = new System.Drawing.Point(504, 85);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(39, 42);
            this.horas.TabIndex = 14;
            this.horas.Text = "0";
            // 
            // MENSAJE
            // 
            this.MENSAJE.AutoSize = true;
            this.MENSAJE.BackColor = System.Drawing.Color.Green;
            this.MENSAJE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENSAJE.ForeColor = System.Drawing.Color.White;
            this.MENSAJE.Image = ((System.Drawing.Image)(resources.GetObject("MENSAJE.Image")));
            this.MENSAJE.Location = new System.Drawing.Point(591, 9);
            this.MENSAJE.Name = "MENSAJE";
            this.MENSAJE.Size = new System.Drawing.Size(141, 37);
            this.MENSAJE.TabIndex = 15;
            this.MENSAJE.Text = "CRONO";
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSize = true;
            this.ESTADO.BackColor = System.Drawing.Color.MidnightBlue;
            this.ESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESTADO.ForeColor = System.Drawing.Color.Snow;
            this.ESTADO.Image = ((System.Drawing.Image)(resources.GetObject("ESTADO.Image")));
            this.ESTADO.Location = new System.Drawing.Point(505, 303);
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Size = new System.Drawing.Size(184, 31);
            this.ESTADO.TabIndex = 16;
            this.ESTADO.Text = "EN REPOSO";
            // 
            // SstatusCrono
            // 
            this.SstatusCrono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SstatusCrono.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SstatusCrono.BackgroundImage")));
            this.SstatusCrono.Image = ((System.Drawing.Image)(resources.GetObject("SstatusCrono.Image")));
            this.SstatusCrono.Location = new System.Drawing.Point(584, 147);
            this.SstatusCrono.Name = "SstatusCrono";
            this.SstatusCrono.Size = new System.Drawing.Size(152, 142);
            this.SstatusCrono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SstatusCrono.TabIndex = 17;
            this.SstatusCrono.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // statusmessage
            // 
            this.statusmessage.AutoSize = true;
            this.statusmessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.statusmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusmessage.ForeColor = System.Drawing.Color.White;
            this.statusmessage.Image = ((System.Drawing.Image)(resources.GetObject("statusmessage.Image")));
            this.statusmessage.Location = new System.Drawing.Point(75, 354);
            this.statusmessage.Name = "statusmessage";
            this.statusmessage.Size = new System.Drawing.Size(71, 15);
            this.statusmessage.TabIndex = 19;
            this.statusmessage.Text = "en espera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(637, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 55);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(821, 323);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(47, 40);
            this.Reset.TabIndex = 21;
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Form1
            // 
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(878, 376);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusmessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.SstatusCrono);
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
            ((System.ComponentModel.ISupportInitialize)(this.SstatusCrono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.PictureBox SstatusCrono;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label statusmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
    }
}

