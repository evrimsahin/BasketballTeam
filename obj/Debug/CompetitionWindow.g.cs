﻿#pragma checksum "..\..\CompetitionWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01EC2AA31C504D85E1937A930F9F8ABF14C55641F8FC0A7D29DB1EF03F750541"
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
    /// CompetitionWindow
    /// </summary>
    public partial class CompetitionWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grd1;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtAra;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listCompetitions;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCompetitionID;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCompetitionName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPrize;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumOfParticipants;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\CompetitionWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtLastChampion;
        
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
            System.Uri resourceLocater = new System.Uri("/CSE3055;component/competitionwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CompetitionWindow.xaml"
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
            
            #line 23 "..\..\CompetitionWindow.xaml"
            this.txtAra.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listCompetitions = ((System.Windows.Controls.ListBox)(target));
            
            #line 25 "..\..\CompetitionWindow.xaml"
            this.listCompetitions.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listCompetitions_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtCompetitionID = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtCompetitionName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtPrize = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtNumOfParticipants = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtLastChampion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 61 "..\..\CompetitionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 62 "..\..\CompetitionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_2);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 63 "..\..\CompetitionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_3);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 64 "..\..\CompetitionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_4);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 65 "..\..\CompetitionWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_5);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

