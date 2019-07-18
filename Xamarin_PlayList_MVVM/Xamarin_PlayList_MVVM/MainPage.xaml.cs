using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin_PlayList_MVVM.Models;

namespace Xamarin_PlayList_MVVM
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<Playlist> _playLists = new ObservableCollection<Playlist>();
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            listView.ItemsSource = _playLists;
            base.OnAppearing();
        }

        private void BtnAddPlayList_Clicked(object sender, EventArgs e)
        {
            var newPlayList = "PlayList " + (_playLists.Count + 1);
            _playLists.Add(new Playlist { Name = newPlayList });
            this.Title = $"{_playLists.Count} Playlists";
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var playlist = e.SelectedItem as Playlist;
            playlist.IsFavorite = !playlist.IsFavorite;
            _playLists[e.SelectedItemIndex] = playlist;
            listView.SelectedItem = null; 
        }
    }
}
