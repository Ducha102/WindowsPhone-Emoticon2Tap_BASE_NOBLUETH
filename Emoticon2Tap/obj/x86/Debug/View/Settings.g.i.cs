﻿#pragma checksum "F:\Project\Emoticon2Tap\Emoticon2Tap\Emoticon2Tap\View\Settings.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "18355EDBBC2FB8A46604B8271AB4620B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
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


namespace Emoticon2Tap.View {
    
    
    public partial class Settings : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox txtPlayer;
        
        internal System.Windows.Controls.TextBlock timeValue;
        
        internal System.Windows.Controls.Slider slideTime;
        
        internal System.Windows.Controls.Button btnSave;
        
        internal Microsoft.Phone.Controls.ListPicker pkSpeed;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Emoticon2Tap;component/View/Settings.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.txtPlayer = ((System.Windows.Controls.TextBox)(this.FindName("txtPlayer")));
            this.timeValue = ((System.Windows.Controls.TextBlock)(this.FindName("timeValue")));
            this.slideTime = ((System.Windows.Controls.Slider)(this.FindName("slideTime")));
            this.btnSave = ((System.Windows.Controls.Button)(this.FindName("btnSave")));
            this.pkSpeed = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("pkSpeed")));
        }
    }
}

