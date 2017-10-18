using System;
using App1.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            InitializeComponent();

            // set the BindingContext Property of the Page3 to a new instance of Page3ViewModel.
            // i.e. set the datasource for all the objects in the Page3 View to the Page3ViewModel.
            BindingContext = new Page3ViewModel();
        }
    }
}