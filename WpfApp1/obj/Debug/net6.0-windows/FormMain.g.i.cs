﻿#pragma checksum "..\..\..\FormMain.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "EB358BBDC988EF083087BA01E717B9B80BB75F7D"
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
using WpfApp1;


namespace WpfApp1 {
    
    
    /// <summary>
    /// FormMain
    /// </summary>
    public partial class FormMain : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 307 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image myImage;
        
        #line default
        #line hidden
        
        
        #line 336 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnTrangChu;
        
        #line default
        #line hidden
        
        
        #line 346 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDamua;
        
        #line default
        #line hidden
        
        
        #line 355 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnGioHang;
        
        #line default
        #line hidden
        
        
        #line 363 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnban;
        
        #line default
        #line hidden
        
        
        #line 372 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnDangXuat;
        
        #line default
        #line hidden
        
        
        #line 412 "..\..\..\FormMain.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl Uc;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Do_an;component/formmain.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FormMain.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 8 "..\..\..\FormMain.xaml"
            ((WpfApp1.FormMain)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.myImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.btnTrangChu = ((System.Windows.Controls.Button)(target));
            
            #line 337 "..\..\..\FormMain.xaml"
            this.btnTrangChu.Click += new System.Windows.RoutedEventHandler(this.btnTrangChu_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnDamua = ((System.Windows.Controls.Button)(target));
            
            #line 347 "..\..\..\FormMain.xaml"
            this.btnDamua.Click += new System.Windows.RoutedEventHandler(this.btnDamua_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnGioHang = ((System.Windows.Controls.Button)(target));
            
            #line 356 "..\..\..\FormMain.xaml"
            this.btnGioHang.Click += new System.Windows.RoutedEventHandler(this.btnGioHang_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnban = ((System.Windows.Controls.Button)(target));
            
            #line 364 "..\..\..\FormMain.xaml"
            this.btnban.Click += new System.Windows.RoutedEventHandler(this.btnGioHang_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnDangXuat = ((System.Windows.Controls.Button)(target));
            
            #line 373 "..\..\..\FormMain.xaml"
            this.btnDangXuat.Click += new System.Windows.RoutedEventHandler(this.btnDangXuat_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 394 "..\..\..\FormMain.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Uc = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

