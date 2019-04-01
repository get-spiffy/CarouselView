using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using CarouselView.FormsPlugin.Abstractions;
using FFImageLoading.Forms;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        MainViewModel _vm;

        public MainPage()
        {
            InitializeComponent();

            Title = "CarouselView";
            BindingContext = _vm = new MainViewModel();
           
        }

        void Handle_PositionSelected(object sender, CarouselView.FormsPlugin.Abstractions.PositionSelectedEventArgs e)
        {
            Debug.WriteLine("Position " + e.NewValue + " selected.");
        }

        void Handle_Scrolled(object sender, CarouselView.FormsPlugin.Abstractions.ScrolledEventArgs e)
        {
            Debug.WriteLine("Scrolled to " + e.NewValue + " position.");
            Debug.WriteLine("Direction = " + e.Direction);
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            carousel.Position = carousel.ItemsSource.GetCount();
        }
    }
}
