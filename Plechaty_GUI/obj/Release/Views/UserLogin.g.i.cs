﻿#pragma checksum "..\..\..\Views\UserLogin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "0604CE03281E1752F8277E0182D74A2FD7FBF842F6950CE85A7E27B2AA2951A0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

using Plechaty_GUI.Views;
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


namespace Plechaty_GUI.Views {
    
    
    /// <summary>
    /// UserLogin
    /// </summary>
    public partial class UserLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label loginLabel;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border emailBorder;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox emailTextBox;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border passwordBorder;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox passwordTextBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loginButton;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Views\UserLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label createAccountLabel;
        
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
            System.Uri resourceLocater = new System.Uri("/Plechaty_GUI;component/views/userlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\UserLogin.xaml"
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
            
            #line 28 "..\..\..\Views\UserLogin.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseLogin);
            
            #line default
            #line hidden
            return;
            case 2:
            this.loginLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.emailBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 4:
            this.emailTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 46 "..\..\..\Views\UserLogin.xaml"
            this.emailTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.onEmailTextBoxGotFocus);
            
            #line default
            #line hidden
            
            #line 46 "..\..\..\Views\UserLogin.xaml"
            this.emailTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.onEmailTextBoxLostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.passwordBorder = ((System.Windows.Controls.Border)(target));
            return;
            case 6:
            this.passwordTextBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 49 "..\..\..\Views\UserLogin.xaml"
            this.passwordTextBox.GotFocus += new System.Windows.RoutedEventHandler(this.onPasswordTextBoxGotFocus);
            
            #line default
            #line hidden
            
            #line 49 "..\..\..\Views\UserLogin.xaml"
            this.passwordTextBox.LostFocus += new System.Windows.RoutedEventHandler(this.onPasswordTextBoxGotLostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.loginButton = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\Views\UserLogin.xaml"
            this.loginButton.Click += new System.Windows.RoutedEventHandler(this.onLoginButtonClick);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Views\UserLogin.xaml"
            this.loginButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.onLoginButtonMouseEnter);
            
            #line default
            #line hidden
            
            #line 51 "..\..\..\Views\UserLogin.xaml"
            this.loginButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.onLoginButtonMouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.createAccountLabel = ((System.Windows.Controls.Label)(target));
            
            #line 52 "..\..\..\Views\UserLogin.xaml"
            this.createAccountLabel.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.onCreateAccountLabelMouseDown);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\Views\UserLogin.xaml"
            this.createAccountLabel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.onCreateAccountLabelMouseEnter);
            
            #line default
            #line hidden
            
            #line 52 "..\..\..\Views\UserLogin.xaml"
            this.createAccountLabel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.onCreateAccountLabelMouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
