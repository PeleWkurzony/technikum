﻿#pragma checksum "..\..\..\DodajSzkoleWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "CEFF552B1EBCCA2EC9EC88AE8D48B792220F6A3D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Szkola_pele;


namespace Szkola_pele {
    
    
    /// <summary>
    /// DodajSzkoleWindow
    /// </summary>
    public partial class DodajSzkoleWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\DodajSzkoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nazwa_ui;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\DodajSzkoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox id_ui;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\DodajSzkoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button zapisz_ui;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\DodajSzkoleWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button anuluj_ui;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Szkola_pele;component/dodajszkolewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DodajSzkoleWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.2.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nazwa_ui = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.id_ui = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.zapisz_ui = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\DodajSzkoleWindow.xaml"
            this.zapisz_ui.Click += new System.Windows.RoutedEventHandler(this.zapiszClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.anuluj_ui = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\DodajSzkoleWindow.xaml"
            this.anuluj_ui.Click += new System.Windows.RoutedEventHandler(this.anulujClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
