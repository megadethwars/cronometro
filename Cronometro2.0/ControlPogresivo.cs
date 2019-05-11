﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cronometro2._0
{
    public partial class ControlPogresivo : UserControl
    {

        public delegate void EventoEnter(string inter, EventArgs e);
        public event EventoEnter enter;
        public ControlPogresivo()
        {
            InitializeComponent();
            
        }
        

        public string getTime()
        {
            return this.textBox1.Text;
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //enter key is down
                
                
            }
        }

        private void Set_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate {
                enter(textBox1.Text, null);
            });
        }
    }
}