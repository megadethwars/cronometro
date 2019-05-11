namespace Cronometro2._0
{
    partial class ControlOpciones
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.LocalPort = new System.Windows.Forms.TextBox();
            this.LocalAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(20, 40);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(100, 20);
            this.IpAddress.TabIndex = 2;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(20, 116);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(100, 20);
            this.Port.TabIndex = 3;
            // 
            // LocalPort
            // 
            this.LocalPort.Location = new System.Drawing.Point(214, 116);
            this.LocalPort.Name = "LocalPort";
            this.LocalPort.Size = new System.Drawing.Size(100, 20);
            this.LocalPort.TabIndex = 7;
            // 
            // LocalAddress
            // 
            this.LocalAddress.Location = new System.Drawing.Point(214, 40);
            this.LocalAddress.Name = "LocalAddress";
            this.LocalAddress.Size = new System.Drawing.Size(100, 20);
            this.LocalAddress.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOCAL PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "LOCAL ADDRESS";
            // 
            // back
            // 
            this.back.Image = global::Cronometro2._0.Properties.Resources.left;
            this.back.Location = new System.Drawing.Point(172, 165);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 54);
            this.back.TabIndex = 9;
            this.back.UseVisualStyleBackColor = true;
            this.back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.back_Click_Down);
            this.back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.back_Click_Up);
            // 
            // forward
            // 
            this.forward.Image = global::Cronometro2._0.Properties.Resources.right;
            this.forward.Location = new System.Drawing.Point(282, 165);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(75, 54);
            this.forward.TabIndex = 10;
            this.forward.UseVisualStyleBackColor = true;
            
            this.forward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forward_Click_Down);
            this.forward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.forward_Click_Up);
            // 
            // Save
            // 
            this.Save.Image = global::Cronometro2._0.Properties.Resources.saveconfig;
            this.Save.Location = new System.Drawing.Point(20, 165);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(84, 54);
            this.Save.TabIndex = 8;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ControlOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.forward);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.LocalPort);
            this.Controls.Add(this.LocalAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ControlOpciones";
            this.Size = new System.Drawing.Size(377, 245);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.TextBox Port;
        private System.Windows.Forms.TextBox LocalPort;
        private System.Windows.Forms.TextBox LocalAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button forward;
    }
}
