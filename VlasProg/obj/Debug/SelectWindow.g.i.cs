﻿#pragma checksum "..\..\SelectWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "68843A09CBD6EEB5234DCF25835DE2B4E8162A21C99DB0F99B39807FC880D36E"
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
using VlasProg;


namespace VlasProg {
    
    
    /// <summary>
    /// SelectWindow
    /// </summary>
    public partial class SelectWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_EXIT;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TB_Welcome;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Cabinet;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_OrderProd;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Supplier1;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_AvaliableResources;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Resource;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Supplier;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Product;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\SelectWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BTN_Auth;
        
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
            System.Uri resourceLocater = new System.Uri("/VlasProg;component/selectwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SelectWindow.xaml"
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
            this.BTN_EXIT = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\SelectWindow.xaml"
            this.BTN_EXIT.Click += new System.Windows.RoutedEventHandler(this.BTN_EXIT_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TB_Welcome = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.BTN_Cabinet = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\SelectWindow.xaml"
            this.BTN_Cabinet.Click += new System.Windows.RoutedEventHandler(this.BTN_Cabinet_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BTN_OrderProd = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\SelectWindow.xaml"
            this.BTN_OrderProd.Click += new System.Windows.RoutedEventHandler(this.BTN_OrderProd_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BTN_Supplier1 = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\SelectWindow.xaml"
            this.BTN_Supplier1.Click += new System.Windows.RoutedEventHandler(this.BTN_Supplier_Click_1);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BTN_AvaliableResources = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\SelectWindow.xaml"
            this.BTN_AvaliableResources.Click += new System.Windows.RoutedEventHandler(this.BTN_AvaliableResources_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.BTN_Resource = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\SelectWindow.xaml"
            this.BTN_Resource.Click += new System.Windows.RoutedEventHandler(this.BTN_Resource_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.BTN_Supplier = ((System.Windows.Controls.Button)(target));
            
            #line 65 "..\..\SelectWindow.xaml"
            this.BTN_Supplier.Click += new System.Windows.RoutedEventHandler(this.BTN_Supplier_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BTN_Product = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\SelectWindow.xaml"
            this.BTN_Product.Click += new System.Windows.RoutedEventHandler(this.BTN_Product_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BTN_Auth = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\SelectWindow.xaml"
            this.BTN_Auth.Click += new System.Windows.RoutedEventHandler(this.BTN_Auth_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

