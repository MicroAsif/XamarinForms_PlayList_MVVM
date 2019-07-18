using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_PlayList_MVVM.Models;
using Xamarin_PlayList_MVVM.ViewModel;

namespace Xamarin_PlayList_MVVM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            BindingContext = new PlayListsViewModel();
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (BindingContext as PlayListsViewModel).SelectPlayListCommand.Execute(e.SelectedItem as Playlist);
            
        }
    }
}
