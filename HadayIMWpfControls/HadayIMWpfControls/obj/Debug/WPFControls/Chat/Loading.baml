   M S B A M L   `   `   `  ����  HadayIMWpfControls,    &HadayIMWpfControls.WPFControls.Loading   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � -   5        $��
LayoutRoot��5   $   
������ z�5	   
   �� 5
      -   5        SpinnerScale��  �� ScaleX$	  1.0Q�5
   3    �� ScaleY$	 1.0Q�6@   .+�5   
   ��  J� RenderTransformOrigin$ 0.5,0.5&�6   $��30��63   $��30��6>   z�5      �� 5      -   5        SpinnerRotate�� �� Angle$ 0Q�5   9    � Triggers 5      :� 5       :� RoutedEvent$ FrameworkElement.Loaded��6   .[�5      �� ��5      �� 5      .��5   "   W�  g� Duration$ 0:0:01D�62    W� From$ 0X�6D    g� RepeatBehavior$ Forever��6M   	 �� 
TargetName$	 SpinnerRotate��6f   
 �� TargetProperty$
 (RotateTransform.Angle)�6�   	 W� To$	 360X�6�   5      5      5      .+�5      �� $��../Images/spinner.png��6   $��30��63   $��30��6>   6L   5      5      5      