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
            this.StatusCrono = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statusmessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IndexMins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCrono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(110, 431);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 252);
            this.panel1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Image = global::Cronometro2._0.Properties.Resources.PLAY1;
            this.Start.Location = new System.Drawing.Point(136, 310);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(135, 99);
            this.Start.TabIndex = 1;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Image = global::Cronometro2._0.Properties.Resources.STOP1;
            this.Stop.Location = new System.Drawing.Point(632, 310);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(134, 99);
            this.Stop.TabIndex = 2;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // valores
            // 
            this.valores.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.valores.Location = new System.Drawing.Point(315, 310);
            this.valores.Maximum = 4;
            this.valores.Name = "valores";
            this.valores.Size = new System.Drawing.Size(236, 45);
            this.valores.TabIndex = 3;
            this.valores.Scroll += new System.EventHandler(this.valores_Scroll);
            // 
            // TypeRegresivo
            // 
            this.TypeRegresivo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TypeRegresivo.BackColor = System.Drawing.Color.Transparent;
            this.TypeRegresivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeRegresivo.Image = global::Cronometro2._0.Properties.Resources.ImageRegresivo;
            this.TypeRegresivo.Location = new System.Drawing.Point(136, 155);
            this.TypeRegresivo.Name = "TypeRegresivo";
            this.TypeRegresivo.Size = new System.Drawing.Size(135, 67);
            this.TypeRegresivo.TabIndex = 5;
            this.TypeRegresivo.Text = "Regresivo";
            this.TypeRegresivo.UseVisualStyleBackColor = false;
            this.TypeRegresivo.Click += new System.EventHandler(this.TypeRegresivo_Click);
            // 
            // Progresivo
            // 
            this.Progresivo.BackColor = System.Drawing.Color.White;
            this.Progresivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progresivo.Image = global::Cronometro2._0.Properties.Resources.ImagePROGRESIVO;
            this.Progresivo.Location = new System.Drawing.Point(632, 157);
            this.Progresivo.Name = "Progresivo";
            this.Progresivo.Size = new System.Drawing.Size(134, 65);
            this.Progresivo.TabIndex = 6;
            this.Progresivo.Text = "Progresivo";
            this.Progresivo.UseVisualStyleBackColor = false;
            this.Progresivo.Click += new System.EventHandler(this.Progresivo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Cronometro2._0.Properties.Resources.conexion;
            this.pictureBox1.Location = new System.Drawing.Point(1237, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.Home.Image = global::Cronometro2._0.Properties.Resources.HOME2;
            this.Home.Location = new System.Drawing.Point(364, 145);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(136, 120);
            this.Home.TabIndex = 8;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Opciones
            // 
            this.Opciones.AutoSize = true;
            this.Opciones.Image = global::Cronometro2._0.Properties.Resources.settings;
            this.Opciones.Location = new System.Drawing.Point(1191, 587);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(123, 96);
            this.Opciones.TabIndex = 7;
            this.Opciones.UseVisualStyleBackColor = true;
            this.Opciones.Click += new System.EventHandler(this.Opciones_Click);
            // 
            // milisegundos
            // 
            this.milisegundos.AutoSize = true;
            this.milisegundos.BackColor = System.Drawing.Color.Transparent;
            this.milisegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milisegundos.ForeColor = System.Drawing.Color.White;
            this.milisegundos.Location = new System.Drawing.Point(1278, 310);
            this.milisegundos.Name = "milisegundos";
            this.milisegundos.Size = new System.Drawing.Size(36, 37);
            this.milisegundos.TabIndex = 11;
            this.milisegundos.Text = "0";
            // 
            // segundos
            // 
            this.segundos.AutoSize = true;
            this.segundos.BackColor = System.Drawing.Color.Transparent;
            this.segundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.segundos.ForeColor = System.Drawing.Color.White;
            this.segundos.Location = new System.Drawing.Point(1181, 310);
            this.segundos.Name = "segundos";
            this.segundos.Size = new System.Drawing.Size(36, 37);
            this.segundos.TabIndex = 12;
            this.segundos.Text = "0";
            // 
            // minutos
            // 
            this.minutos.AutoSize = true;
            this.minutos.BackColor = System.Drawing.Color.Transparent;
            this.minutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutos.ForeColor = System.Drawing.Color.White;
            this.minutos.Location = new System.Drawing.Point(1013, 310);
            this.minutos.Name = "minutos";
            this.minutos.Size = new System.Drawing.Size(36, 37);
            this.minutos.TabIndex = 13;
            this.minutos.Text = "0";
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.BackColor = System.Drawing.Color.Transparent;
            this.horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horas.ForeColor = System.Drawing.Color.White;
            this.horas.Location = new System.Drawing.Point(913, 310);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(36, 37);
            this.horas.TabIndex = 14;
            this.horas.Text = "0";
            // 
            // MENSAJE
            // 
            this.MENSAJE.AutoSize = true;
            this.MENSAJE.BackColor = System.Drawing.Color.Transparent;
            this.MENSAJE.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MENSAJE.ForeColor = System.Drawing.Color.White;
            this.MENSAJE.Location = new System.Drawing.Point(908, 243);
            this.MENSAJE.Name = "MENSAJE";
            this.MENSAJE.Size = new System.Drawing.Size(141, 37);
            this.MENSAJE.TabIndex = 15;
            this.MENSAJE.Text = "CRONO";
            // 
            // ESTADO
            // 
            this.ESTADO.AutoSize = true;
            this.ESTADO.BackColor = System.Drawing.Color.Transparent;
            this.ESTADO.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ESTADO.ForeColor = System.Drawing.Color.Snow;
            this.ESTADO.Location = new System.Drawing.Point(947, 785);
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.Size = new System.Drawing.Size(215, 37);
            this.ESTADO.TabIndex = 16;
            this.ESTADO.Text = "EN REPOSO";
            // 
            // StatusCrono
            // 
            this.StatusCrono.BackColor = System.Drawing.Color.Transparent;
            this.StatusCrono.Image = ((System.Drawing.Image)(resources.GetObject("StatusCrono.Image")));
            this.StatusCrono.Location = new System.Drawing.Point(1020, 380);
            this.StatusCrono.Name = "StatusCrono";
            this.StatusCrono.Size = new System.Drawing.Size(127, 122);
            this.StatusCrono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StatusCrono.TabIndex = 17;
            this.StatusCrono.TabStop = false;
            this.StatusCrono.Click += new System.EventHandler(this.StatusCrono_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Cronometro2._0.Properties.Resources.reposo;
            this.pictureBox2.Location = new System.Drawing.Point(38, 956);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // statusmessage
            // 
            this.statusmessage.AutoSize = true;
            this.statusmessage.BackColor = System.Drawing.Color.Transparent;
            this.statusmessage.Cursor = System.Windows.Forms.Cursors.Default;
            this.statusmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusmessage.ForeColor = System.Drawing.Color.White;
            this.statusmessage.Location = new System.Drawing.Point(171, 956);
            this.statusmessage.Name = "statusmessage";
            this.statusmessage.Size = new System.Drawing.Size(167, 37);
            this.statusmessage.TabIndex = 19;
            this.statusmessage.Text = "en espera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1108, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = ":";
            // 
            // IndexMins
            // 
            this.IndexMins.AutoSize = true;
            this.IndexMins.BackColor = System.Drawing.Color.Transparent;
            this.IndexMins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndexMins.ForeColor = System.Drawing.Color.White;
            this.IndexMins.Location = new System.Drawing.Point(908, 157);
            this.IndexMins.Name = "IndexMins";
            this.IndexMins.Size = new System.Drawing.Size(101, 37);
            this.IndexMins.TabIndex = 22;
            this.IndexMins.Text = "0 min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Cronometro2._0.Properties.Resources.FORMATO;
            this.ClientSize = new System.Drawing.Size(1981, 919);
            this.Controls.Add(this.IndexMins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusmessage);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.StatusCrono);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.valores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusCrono)).EndInit();
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
        private System.Windows.Forms.PictureBox StatusCrono;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label statusmessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IndexMins;
    }
}

