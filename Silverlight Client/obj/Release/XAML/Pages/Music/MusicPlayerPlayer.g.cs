﻿#pragma checksum "C:\Users\carl\Visual Studio\Projects\RemotePotatoServer\SilverPotato\XAML\Pages\Music\MusicPlayerPlayer.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BD09C765A13EDA5477B3D63C4404AADC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SilverPotato;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace SilverPotato {
    
    
    public partial class MusicPlayerPlayer : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.MediaElement mePlayer;
        
        internal System.Windows.Controls.Border brdOSDBottom;
        
        internal System.Windows.Controls.Image imgCurrentSongThumb;
        
        internal System.Windows.Controls.Border btnPlay;
        
        internal System.Windows.Controls.Image imgPlayPause;
        
        internal System.Windows.Controls.Border btnSkipPrev;
        
        internal System.Windows.Controls.Border btnSkipNext;
        
        internal System.Windows.Controls.TextBlock lblStatus;
        
        internal SilverPotato.VolumePopupHorizontal volPopup;
        
        internal System.Windows.Controls.Grid gdSeekBar;
        
        internal System.Windows.Shapes.Rectangle rctSeekBar;
        
        internal System.Windows.Shapes.Rectangle rctDownloaded;
        
        internal System.Windows.Shapes.Rectangle rctPlayed;
        
        internal System.Windows.Controls.Border rctCursor;
        
        internal System.Windows.Controls.TextBlock lblTimeDisplay;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/SilverPotato;component/XAML/Pages/Music/MusicPlayerPlayer.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.mePlayer = ((System.Windows.Controls.MediaElement)(this.FindName("mePlayer")));
            this.brdOSDBottom = ((System.Windows.Controls.Border)(this.FindName("brdOSDBottom")));
            this.imgCurrentSongThumb = ((System.Windows.Controls.Image)(this.FindName("imgCurrentSongThumb")));
            this.btnPlay = ((System.Windows.Controls.Border)(this.FindName("btnPlay")));
            this.imgPlayPause = ((System.Windows.Controls.Image)(this.FindName("imgPlayPause")));
            this.btnSkipPrev = ((System.Windows.Controls.Border)(this.FindName("btnSkipPrev")));
            this.btnSkipNext = ((System.Windows.Controls.Border)(this.FindName("btnSkipNext")));
            this.lblStatus = ((System.Windows.Controls.TextBlock)(this.FindName("lblStatus")));
            this.volPopup = ((SilverPotato.VolumePopupHorizontal)(this.FindName("volPopup")));
            this.gdSeekBar = ((System.Windows.Controls.Grid)(this.FindName("gdSeekBar")));
            this.rctSeekBar = ((System.Windows.Shapes.Rectangle)(this.FindName("rctSeekBar")));
            this.rctDownloaded = ((System.Windows.Shapes.Rectangle)(this.FindName("rctDownloaded")));
            this.rctPlayed = ((System.Windows.Shapes.Rectangle)(this.FindName("rctPlayed")));
            this.rctCursor = ((System.Windows.Controls.Border)(this.FindName("rctCursor")));
            this.lblTimeDisplay = ((System.Windows.Controls.TextBlock)(this.FindName("lblTimeDisplay")));
        }
    }
}
