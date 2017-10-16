using App1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.View
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            // let vm be a new object of type MainPageViewModel
            vm = new MainPageViewModel();

            // set the BindingContext Property of the MainPage to vm
            // we can now bind MainPageViewModel objects to the view MainPage
            BindingContext = vm;

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
