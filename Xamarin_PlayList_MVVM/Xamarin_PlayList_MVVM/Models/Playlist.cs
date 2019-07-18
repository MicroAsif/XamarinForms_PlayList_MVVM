using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Xamarin_PlayList_MVVM.ViewModel;

namespace Xamarin_PlayList_MVVM.Models
{
    public class Playlist : BaseViewModel
    {
        public string Name { get; set; }
        //public bool IsFavorite { get; set; }
        private bool _isFavorite;

        public bool IsFavorite
        {
            get => _isFavorite;
            set => SetProperty(ref _isFavorite, value); 
        }
        public Color Color { get { return IsFavorite ? Color.Pink : Color.Black; } }
    }
}
