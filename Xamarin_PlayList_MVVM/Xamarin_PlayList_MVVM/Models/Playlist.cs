using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Xamarin_PlayList_MVVM.Models
{
    public class Playlist
    {
        public string Name { get; set; }
        public bool IsFavorite { get; set; }
        public string Font { get { return IsFavorite ? "FontAwesomeSolid" : "FontAwesomeRegular"; } }
        public Color Color { get { return IsFavorite ? Color.Pink : Color.Black; } }
    }
}
