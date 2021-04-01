using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TipCalculator.ViewModel
{
    public class MaingPageViewModel
    {
        public Command OperationsCommand { get; set; }
        public TipModel tipModel { get; set; }

        // Constructor
        public MaingPageViewModel()
        {
            OperationsCommand = new Command(DoOperations);
            //OperationsCommand = new Command(execute => { DoOperations(); },
            //                                canExecute => { return ValidarEntradas(); });

            /*
              https://docs.microsoft.com/es-es/xamarin/xamarin-forms/app-fundamentals/data-binding/commanding
              public interface ICommand
              {
                    public void Execute (Object parameter);

                    public bool CanExecute (Object parameter);

                    public event EventHandler CanExecuteChanged;
              }
             */
            tipModel = new TipModel
            {
                //    Propina = 5,
                NoPersonas = 2
            };            
        }

        private void DoOperations()
        {
            tipModel.TotalPropina = (tipModel.Total * tipModel.Propina) / 100;

            tipModel.TotalConPropina = tipModel.TotalPropina + tipModel.Total;

            tipModel.PropinaPorPersona = tipModel.TotalPropina / tipModel.NoPersonas;

            tipModel.TotalPorPersona = (tipModel.Total + tipModel.TotalPropina) / tipModel.NoPersonas;
        }
    }
}
