using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ImplementandoMVVM_OAEA.VistaModelo
{
    public class VMpatron
    {
        #region VARIABLES
        string _Texto;
        int _Peso;
        int _Duracion;
        #endregion
        #region CONTRUCTOR
        public VMpatron(INavigation navigation)
        {
            Navigation = navigation;
        }

        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        public int Peso
        {
            get { return _Peso; }
            set { SetValue(ref _Peso, value); }
        }
        public int Duracion
        {

            get { return _Duracion; }
            set { SetValue(ref _Duracion, value); }
        }
          

        #endregion
        #region PROCESOS


        public void PesoT()
        {



        }


        public void Calcular(bool Resultado)
        {
            for (Resultado < 250)
            {
                
            }
            else if ( Resultado < 250 )


        }

        public async Task ProcesoAsyncrono()
        {





        }

        public void ProcesoSimple()
        {


        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());

        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
