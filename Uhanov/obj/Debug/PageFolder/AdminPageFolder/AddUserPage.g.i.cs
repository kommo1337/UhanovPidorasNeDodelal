﻿#pragma checksum "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9A40F9FF4EF16D0E62CF3BB2CA6013DC8C2B24ECBE70E4030AD9A34FDDDD2EF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LibraryBook.PageFolder.AdminPageFolder;
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


namespace LibraryBook.PageFolder.AdminPageFolder {
    
    
    /// <summary>
    /// AddUserPage
    /// </summary>
    public partial class AddUserPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LoginTB;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PasswordPsb;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox RoleCB;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddUserBtn;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Uhanov;component/pagefolder/adminpagefolder/adduserpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
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
            this.LoginTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.PasswordPsb = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.RoleCB = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.AddUserBtn = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
            this.AddUserBtn.Click += new System.Windows.RoutedEventHandler(this.AddUserBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.BackBtn = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\PageFolder\AdminPageFolder\AddUserPage.xaml"
            this.BackBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
