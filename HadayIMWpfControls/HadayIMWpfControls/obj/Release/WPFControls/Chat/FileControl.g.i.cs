﻿#pragma checksum "..\..\..\..\WPFControls\Chat\FileControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C658FD51B9C89A2D6BE820ABAB83350D"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace HadayIMWpfControls.WPFControls {
    
    
    /// <summary>
    /// FileControl
    /// </summary>
    public partial class FileControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fileNameTextBlock;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock fileSizeTextBlock;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ProgressBar progressBar;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock msgTextBlock;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TransferOver;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Transfer;
        
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
            System.Uri resourceLocater = new System.Uri("/HadayIMWpfControls;component/wpfcontrols/chat/filecontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
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
            this.fileNameTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.fileSizeTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.progressBar = ((System.Windows.Controls.ProgressBar)(target));
            
            #line 30 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
            this.progressBar.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.progressBar_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.msgTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TransferOver = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 34 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 36 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click_1);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 38 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click_2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Transfer = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            
            #line 41 "..\..\..\..\WPFControls\Chat\FileControl.xaml"
            ((System.Windows.Documents.Hyperlink)(target)).Click += new System.Windows.RoutedEventHandler(this.Hyperlink_Click_3);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

