﻿#pragma checksum "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39E8D5579CEEBA4D6D968C2E05840A9762E3DDE09E2EDCA44A0622AC136BFBA0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

using PlayersMVVM.TbWithErrorProvider;
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


namespace PlayersMVVM.TbWithErrorProvider {
    
    
    /// <summary>
    /// TextBoxWithErrorProvider
    /// </summary>
    public partial class TextBoxWithErrorProvider : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBox textBox;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.ToolTip toolTip;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        private System.Windows.Controls.TextBlock textBlockToolTip;
        
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
            System.Uri resourceLocater = new System.Uri("/PlayersMVVM;component/tbwitherrorprovider/textboxwitherrorprovider.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
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
            this.textBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
            this.textBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextChanged);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
            this.textBox.GotFocus += new System.Windows.RoutedEventHandler(this.textBoxFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\..\TbWithErrorProvider\TextBoxWithErrorProvider.xaml"
            this.textBox.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.textBox_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.toolTip = ((System.Windows.Controls.ToolTip)(target));
            return;
            case 3:
            this.textBlockToolTip = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
