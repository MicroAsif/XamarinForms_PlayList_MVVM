using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin_PlayList_MVVM.Models;

namespace Xamarin_PlayList_MVVM.ViewModel
{
    public class PlayListsViewModel : BaseViewModel
    {
        public ObservableCollection<Playlist> PlayLists { get; private set; } = new ObservableCollection<Playlist>();


        public PlayListsViewModel()
        {
            AddPlayListCommand = new Command(AddPlayList);
            SelectPlayListCommand = new Command<Playlist>(vm => SelectPlayList(vm));
        }

        private Playlist _selectedPlaylist;
        public Playlist SelectedPlayList
        {
            get => _selectedPlaylist;
            set => SetProperty(ref _selectedPlaylist, value);
        }


        public ICommand AddPlayListCommand { get; private set; }
        public ICommand SelectPlayListCommand { get; private set; }
         

        protected void AddPlayList()
        {
            var newPlayList = "PlayList " + (PlayLists.Count + 1);
            PlayLists.Add(new Playlist { Name = newPlayList });
        }

        protected void SelectPlayList(Playlist playlist)
        {
            if (playlist == null)
                return;

            playlist.IsFavorite = !playlist.IsFavorite;
            var index = PlayLists.IndexOf(playlist);
            PlayLists[index] = playlist;
            SelectedPlayList = null;
        }

    }
}
