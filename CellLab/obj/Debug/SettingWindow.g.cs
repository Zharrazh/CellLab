﻿#pragma checksum "..\..\SettingWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0E830B3B2CE5CFE676EE28351D7237E1FB477949"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CellLab;
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


namespace CellLab {
    
    
    /// <summary>
    /// SettingWindow
    /// </summary>
    public partial class SettingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBox_Map;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_food;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_food;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_foodNutrition;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_foodNutrition;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_poison;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_poison;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider_radiation;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBox_radiation;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OkBtn;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\SettingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CanselBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/CellLab;component/settingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SettingWindow.xaml"
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
            
            #line 8 "..\..\SettingWindow.xaml"
            ((CellLab.SettingWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.SettingWindow_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBox_Map = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.Slider_food = ((System.Windows.Controls.Slider)(target));
            return;
            case 4:
            this.TextBox_food = ((System.Windows.Controls.TextBox)(target));
            
            #line 20 "..\..\SettingWindow.xaml"
            this.TextBox_food.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_food_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Slider_foodNutrition = ((System.Windows.Controls.Slider)(target));
            return;
            case 6:
            this.TextBox_foodNutrition = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\SettingWindow.xaml"
            this.TextBox_foodNutrition.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_foodNutrition_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Slider_poison = ((System.Windows.Controls.Slider)(target));
            return;
            case 8:
            this.TextBox_poison = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\SettingWindow.xaml"
            this.TextBox_poison.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_poison_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Slider_radiation = ((System.Windows.Controls.Slider)(target));
            return;
            case 10:
            this.TextBox_radiation = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\SettingWindow.xaml"
            this.TextBox_radiation.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_radiation_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.OkBtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\SettingWindow.xaml"
            this.OkBtn.Click += new System.Windows.RoutedEventHandler(this.OkBtn_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.CanselBtn = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\SettingWindow.xaml"
            this.CanselBtn.Click += new System.Windows.RoutedEventHandler(this.CanselBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

