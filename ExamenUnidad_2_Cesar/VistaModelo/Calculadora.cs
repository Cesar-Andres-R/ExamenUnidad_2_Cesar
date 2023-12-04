using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ExamenUnidad_2_Cesar.VistaModelo
{
    public class Calcular : BaseViewModel
    {
        #region VARIABLES
        int _tiempoActual;
        int _pesoActual;

        #endregion
        #region CONSTRUCTOR
        public Calcular(INavigation navigation)
        {
            Navigation = navigation;

        }
        #endregion
        #region OBJETOS
        public int TiempoActual
        {
            get { return _tiempoActual; }
            set { _tiempoActual = value; }
        }
        public int PesoActual
        {
            get { return _pesoActual; }
            set { _pesoActual = value; }
        }
        #endregion
        #region PROCESOS
        public async Task Carlular()
        {
            int caloriasQuemadas = _tiempoActual * 10* _pesoActual / 200;

            string respuesta;
            if (caloriasQuemadas < 250)
            {
                respuesta = "correr más tiempo y lograr superarse";
            }
            else if (caloriasQuemadas < 250 && caloriasQuemadas < 499)
            {
                respuesta = "Vas por buen camiono pero debe esforzarce un poco más";
            }
            else if (caloriasQuemadas >= 499)
            {
                respuesta = "Sige así";
            }
        }
        public void procesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand Carlularcommand => new Command(async () => await Carlular());
        public ICommand ProcesoSimpcommand => new Command(procesoSimple);
        #endregion
    }
}
