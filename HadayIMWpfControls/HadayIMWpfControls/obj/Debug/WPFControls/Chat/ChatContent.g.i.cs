﻿#pragma checksum "..\..\..\..\WPFControls\Chat\ChatContent.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "66260373C0165E711222CEBB861C483B"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using HadayIMWpfControls.WPFControls;
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


namespace HadayIMWpfControls.WPFControls {
    
    
    /// <summary>
    /// ChatContent
    /// </summary>
    public partial class ChatContent : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grid;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image headImageLeft;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HadayIMWpfControls.WPFControls.Bubble bubble;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image headImageRight;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup leftPop;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HadayIMWpfControls.WPFControls.UserInfo leftUserInfo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.Popup rightPop;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HadayIMWpfControls.WPFControls.UserInfo rightUserInfo;
        
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
            System.Uri resourceLocater = new System.Uri("/HadayIMWpfControls;component/wpfcontrols/chat/chatcontent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
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
            
            #line 13 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.copy_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 14 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.reference_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 15 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.undo_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.transpond_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.headImageLeft = ((System.Windows.Controls.Image)(target));
            
            #line 25 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            this.headImageLeft.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headImageLeft_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.bubble = ((HadayIMWpfControls.WPFControls.Bubble)(target));
            return;
            case 8:
            this.headImageRight = ((System.Windows.Controls.Image)(target));
            
            #line 29 "..\..\..\..\WPFControls\Chat\ChatContent.xaml"
            this.headImageRight.MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.headImageLeft_MouseLeftButtonUp);
            
            #line default
            #line hidden
            return;
            case 9:
            this.leftPop = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 10:
            this.leftUserInfo = ((HadayIMWpfControls.WPFControls.UserInfo)(target));
            return;
            case 11:
            this.rightPop = ((System.Windows.Controls.Primitives.Popup)(target));
            return;
            case 12:
            this.rightUserInfo = ((HadayIMWpfControls.WPFControls.UserInfo)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

