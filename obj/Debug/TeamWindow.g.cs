﻿#pragma checksum "..\..\TeamWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6D70800D0BA024307B1D429EFCD02301F2974C1D03A87DDAE7ECB9FD8E480AE7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

using CSE3055;
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


namespace CSE3055 {
    
    
    /// <summary>
    /// TeamWindow
    /// </summary>
    public partial class TeamWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grd1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAra;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listTeams;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTeamID;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTeamName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTeamMascot;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtFirstColor;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSecondColor;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\TeamWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCityID;
        
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
            System.Uri resourceLocater = new System.Uri("/CSE3055;component/teamwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TeamWindow.xaml"
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
            this.grd1 = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.txtAra = ((System.Windows.Controls.TextBox)(target));
            
            #line 23 "..\..\TeamWindow.xaml"
            this.txtAra.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listTeams = ((System.Windows.Controls.ListBox)(target));
            
            #line 25 "..\..\TeamWindow.xaml"
            this.listTeams.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listTeams_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtTeamID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtTeamName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTeamMascot = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtFirstColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtSecondColor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.txtCityID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 63 "..\..\TeamWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 64 "..\..\TeamWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 65 "..\..\TeamWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 66 "..\..\TeamWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 67 "..\..\TeamWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 68 "..\..\TeamWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_6);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

