﻿#pragma checksum "C:\Users\Emina\Tim-Raketa\Projekat\Teretana\Teretana\Teretana\Views\UposlenikPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "EDA37C4E6D8B40C7488598C0F6551B9B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teretana.Teretana.Views
{
    partial class UposlenikPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.image = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 2:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 18 "..\..\..\..\Teretana\Views\UposlenikPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.textBlock).SelectionChanged += this.textBlock_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.toggleButton = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 4:
                {
                    this.toggleButton_Copy = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 5:
                {
                    this.toggleButton_Copy1 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                    #line 25 "..\..\..\..\Teretana\Views\UposlenikPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)this.toggleButton_Copy1).Checked += this.toggleButton_Copy1_Checked;
                    #line default
                }
                break;
            case 6:
                {
                    this.toggleButton_Copy2 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 7:
                {
                    this.toggleButton_Copy3 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 8:
                {
                    this.toggleButton_Copy4 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            case 9:
                {
                    this.toggleButton_Copy5 = (global::Windows.UI.Xaml.Controls.Primitives.ToggleButton)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

