﻿#pragma checksum "..\..\..\WAddBook.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "C8613EC9D46831039A1AD7C6E1EF1B6D280A9EA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Bookshelf;
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


namespace Bookshelf {
    
    
    /// <summary>
    /// WAddBook
    /// </summary>
    public partial class WAddBook : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_Author;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Author;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label l_Title;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tb_Title;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Add_Book;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Add_File;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\WAddBook.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_Cancel;
        
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
            System.Uri resourceLocater = new System.Uri("/Bookshelf;component/waddbook.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WAddBook.xaml"
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
            this.l_Author = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.tb_Author = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.l_Title = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.tb_Title = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.bt_Add_Book = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\..\WAddBook.xaml"
            this.bt_Add_Book.Click += new System.Windows.RoutedEventHandler(this.bt_Add_Book_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.bt_Add_File = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.bt_Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\WAddBook.xaml"
            this.bt_Cancel.Click += new System.Windows.RoutedEventHandler(this.bt_Cancel_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

