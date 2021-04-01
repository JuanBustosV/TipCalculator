using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator
{
    public class TipModel : INotifyPropertyChanged
    {
        private decimal _totalPorPersona;
        private decimal _propinaPorPersona;
        private decimal _totalConPropina;
        private decimal _totalPropina;

        // Primera aproximación con comando, se quitará de aquí, a MainPageViewModel
        //public Command OperationsCommand { get; set; }

        public TipModel()
        {
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //private bool ValidarEntradas()
        //{
        //    //// TODO: Eliminar
        //    Debug.WriteLine("Propina: " + Propina);
        //    Debug.WriteLine("Total: " + Total);
        //    Debug.WriteLine("Número de Personas: " + NoPersonas);

        //    if (Propina < 0 || Total < 0 || NoPersonas <= 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}



        public decimal Total { get; set; }
        public int Propina { get; set; }
        public int NoPersonas { get; set; }

        public decimal TotalPropina {
            get { return _totalPropina; }
            set
            {
                _totalPropina = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalConPropina {
            get { return _totalConPropina; }
            set
            {
                _totalConPropina = value;
                OnPropertyChanged();
            }
        }

        public decimal PropinaPorPersona
        {
            get { return _propinaPorPersona; }
            set
            {
                _propinaPorPersona = value;
                OnPropertyChanged();
            }
        }

        public decimal TotalPorPersona {
            get { return _totalPorPersona; }
            set
            {
                _totalPorPersona = value;
                OnPropertyChanged();
            }
        }

        // This method is called by the Set accessor of each property.  
        // The CallerMemberName attribute that is applied to the optional propertyName  
        // parameter causes the property name of the caller to be substituted as an argument.
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {           
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
