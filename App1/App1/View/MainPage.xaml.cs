using System;
using App1.ViewModel;
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
            // i.e. set the datasource for all the objects in the MainPage View to the MainPageViewModel instance vm
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}
