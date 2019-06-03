using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Cronometro2._0
{
    class Crono
    {
        Timer tiempo;
        private DateTime _inicio;
        private int intervalo=1000;
        
        public  delegate void EventoCrono(int inter,EventArgs e);
        public event EventoCrono pulso;

        public void SetInterval(int intervalo) {
            this.intervalo = intervalo;
            tiempo.Interval = intervalo;
        }

        public Crono() {
            tiempo = new Timer();
            
            tiempo.Interval = intervalo;
            tiempo.Elapsed += Tic;
        }

        public void Start() {
            this._inicio = DateTime.Now;
            tiempo.Start(); 
        }

        public void pause() {

        }

        public void restart() {
        }

        public void resume() {
        }

        public void Stop() {
            
            tiempo.Stop();
            TimeSpan transcurrio = DateTime.Now - this._inicio;
        }

        private void Tic(object sender, ElapsedEventArgs e)
        {

            TimeSpan transcurrio = DateTime.Now - this._inicio;
           
            pulso(intervalo, null);
            
        }

        public TimeSpan Detener()
        {
            tiempo.Stop();
            TimeSpan transcurrio = DateTime.Now - this._inicio;
            return transcurrio;
           
        }


    }
}
