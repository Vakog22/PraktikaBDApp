﻿#pragma checksum "..\..\..\TableWindows\AvalibleResourcesWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "005CAC70A3D677D29F39635A9FB07EF8BC5C64F444FBF0671D5BECD75B893FC2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
using VlasProg.TableWindows;


namespace VlasProg.TableWindows {
    
    
    /// <summary>
    /// AvalibleResourcesWindow
    /// </summary>
    public partial class AvalibleResourcesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TBSearch;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CBSupplier;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DG;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VlasProg;component/tablewindows/avalibleresourceswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TBSearch = ((System.Windows.Controls.TextBox)(target));
            
            #line 12 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
            this.TBSearch.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TBSearch_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CBSupplier = ((System.Windows.Controls.ComboBox)(target));
            
            #line 13 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
            this.CBSupplier.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.CBSupplier_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DG = ((System.Windows.Controls.DataGrid)(target));
            
            #line 19 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
            this.DG.LoadingRow += new System.EventHandler<System.Windows.Controls.DataGridRowEventArgs>(this.DG_LoadingRow);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 33 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 34 "..\..\..\TableWindows\AvalibleResourcesWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

