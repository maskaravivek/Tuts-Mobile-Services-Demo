﻿

#pragma checksum "C:\Users\maska\documents\visual studio 2015\Projects\Tuts+ Mobile Service Demo\Tuts+ Mobile Service Demo\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1F1BB0D7D8D4A021EBD32D52BD6FD9D3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tuts__Mobile_Service_Demo
{
    partial class MainPage : global::Windows.UI.Xaml.Controls.Page, global::Windows.UI.Xaml.Markup.IComponentConnector
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
 
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                #line 34 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonSave_Click;
                 #line default
                 #line hidden
                break;
            case 2:
                #line 35 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ButtonBase)(target)).Click += this.ButtonRefresh_Click;
                 #line default
                 #line hidden
                break;
            case 3:
                #line 40 "..\..\MainPage.xaml"
                ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target)).Checked += this.CheckBoxComplete_Checked;
                 #line default
                 #line hidden
                break;
            }
            this._contentLoaded = true;
        }
    }
}


