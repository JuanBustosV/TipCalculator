using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipCalculator.ViewModel;
using Xamarin.Forms;

namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        //private TipModel tipModel; en viewmodel

        public MainPage()
        {
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("es-ES");

            InitializeComponent();
            //tipModel = new TipModel
            //{
            ////    Propina = 5,
            //   NoPersonas = 2
            //};
            this.BindingContext = new MaingPageViewModel();//tipModel;           
        }

        private void txtNoPersonas_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNoPersonas.Text) && int.TryParse(txtNoPersonas.Text, out int noPersonas) && noPersonas < 1)
            {
                txtNoPersonas.Text = "";
                DisplayAlert("Número de personas incorrecto", "El número de personas tiene que ser mayor que cero.", "Cerrar");
            }
            // TODO: ELIMINAR
            Debug.WriteLine(" * txtNoPersonas.Text: " + txtNoPersonas.Text);            
        }

        //private void btnCalcular_Clicked(object sender, EventArgs e)
        //{
        //    //var total = (decimal.Parse(txtTotal.Text));

        //    //var propina = (int.Parse(txtPropina.Text));

        //    //var noPersonas = (int.Parse(txtNoPersonas.Text));

        //   // //var totalPropina = ((total * propina) / 100);
        //   // tipModel.TotalPropina = (tipModel.Total * tipModel.Propina ) / 100;



        //   //// lblTotal.Detail = (totalPropina + total).ToString("C");
        //   // tipModel.TotalConPropina = tipModel.TotalPropina + tipModel.Total;

        //   // //lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
        //   // tipModel.PropinaPorPersona = tipModel.TotalPropina / tipModel.NoPersonas;

        //   // //lblTotalPorPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C");
        //   // tipModel.TotalPorPersona = (tipModel.Total + tipModel.TotalPropina) / tipModel.NoPersonas;

        //    //lblPropina.Detail = totalPropina.ToString("C"); // Formato de dinero, coin
        //    //lblTotal.Detail = (totalPropina + total).ToString("C");
        //    //lblPropinaPorPersona.Detail = (totalPropina / noPersonas).ToString("C");
        //    //lblTotalPorPersona.Detail = ((total + totalPropina) / noPersonas).ToString("C");
        //}

    }
}
