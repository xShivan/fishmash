﻿

#pragma checksum "C:\Users\Krzysztof\Documents\Visual Studio 2013\Projects\FishMashNew\FishMashNew\Views\LoginView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "099E3904567AD9FCB8A979BBA2723ACF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FishMashNew.Views
{
    partial class LoginView : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::FishMashNew.Views.LoginAndRegistration.IncorrectPasswordUserControl IncorrectPassword; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox UserName; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.PasswordBox Password; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ProgressBar ProgressBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///Views/LoginView.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            IncorrectPassword = (global::FishMashNew.Views.LoginAndRegistration.IncorrectPasswordUserControl)this.FindName("IncorrectPassword");
            UserName = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("UserName");
            Password = (global::Windows.UI.Xaml.Controls.PasswordBox)this.FindName("Password");
            ProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)this.FindName("ProgressBar");
        }
    }
}



