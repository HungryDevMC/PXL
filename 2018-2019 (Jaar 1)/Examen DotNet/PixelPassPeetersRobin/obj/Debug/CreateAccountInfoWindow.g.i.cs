﻿#pragma checksum "..\..\CreateAccountInfoWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A46BA89727DA88621647815D84FBBBA7BE4198C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PixelPass;
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


namespace PixelPass {
    
    
    /// <summary>
    /// CreateAccountInfoWindow
    /// </summary>
    public partial class CreateAccountInfoWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox titleTextBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameTextBox;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passwordTextBox;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox notesTextBox;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider expirationSlider;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock expirationDateTextBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock passwordStrengthTextBlock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\CreateAccountInfoWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button createButton;
        
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
            System.Uri resourceLocater = new System.Uri("/PixelPass;component/createaccountinfowindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CreateAccountInfoWindow.xaml"
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
            this.titleTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.usernameTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.passwordTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 21 "..\..\CreateAccountInfoWindow.xaml"
            this.passwordTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PasswordTextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.notesTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.expirationSlider = ((System.Windows.Controls.Slider)(target));
            
            #line 26 "..\..\CreateAccountInfoWindow.xaml"
            this.expirationSlider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.ExpirationSlider_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.expirationDateTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.passwordStrengthTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.createButton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\CreateAccountInfoWindow.xaml"
            this.createButton.Click += new System.Windows.RoutedEventHandler(this.CreateButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

