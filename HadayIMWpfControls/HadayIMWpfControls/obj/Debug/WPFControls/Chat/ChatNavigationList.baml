   M S B A M L   `   `   `  ����M  IHadayIMWpfControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:HadayIMWpfControls.WPFControlsHadayIMWpfControls.WPFControls  5      7    1HadayIMWpfControls.WPFControls.ChatNavigationList   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      >local,clr-namespace:HadayIMWpfControls.WPFControls     5      $��Microsoft YaHei)�5        � 	Resources  5	         clipGeometry � FillRule @� RadiusX @� RadiusY @� Center  Item.MouseOver.Background �� Color  Item.IsSelected.Background  Item.TextBlock.Foreground��%�   &	        &	 n     &	 �     &	 �     � 5
   
   $ Nonzero=�6-   .��5      @� $ 21Q�6   $ 21Q�6+   $ 21, 21&�68   6J   5      �� 5   
   $ 	#30FFFFFF��6<   �� 5   
   $ 	#50FFFFFF��6=   �� 5   
   $ 	#FFFFFFFF��6<   5      .��5      � .+�5   
   �� -   5         ��Name$ listBox��5      
������ $��-1q�6<   $��0q�6I   $��0q�6�   #��[ 6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � ��	 �� Value$	 -0q�6/   �� 5       � ��$	 -0q�60   �� 5       � ��	 5      �� 5      
 �� 
TargetType"
 ��6.   .R�5   "   � #��z��6'   .+�5   &   ��  ��Name$ selectedBackground��6-   
�������$��3��6\   $
��Left=�6f   $y�Hidden=�6�   6�   �� 5   &   #��z��67   #��z��6[   5    #    �� Triggers 5!   "   P� 5"   &    P� Property �@J�IsMouseOver P� Value . . �5#   *   �� #	 [ 6G    � ��6}   5$   '   P� 5%   &    �@��
IsSelected . . �5&   *   ��  �� 
TargetName$ selectedBackground��61    � y�$	 Visible=�6g   6y   �� 5'   *   #	 [ 6H    � ��6~   5(   '   5*      5,      5-      ��5/      �� 50      .R�51      � $	��200��6   
������  � RowDefinitions 52      �� 53      $��* �6,   �� 54      $��* �6,    � ColumnDefinitions 56      �� 57      $
��auto �6/   �� 58      $��* �6/   .+�5:      �� $ selectedBackground��6!   $��2��6=   $��3��6N   ���	#30000000$y�	Collapsed=�6y   ._�5;      �� 
�������$��3��68   $
��Left=�6B   6_   5<      �� 5=       ��Name$ 	headImage��6    $��0��63   $��0��6@   $��2��6P   $��42��6~   $��42��6�   $
��Left=�6�   $��Center=�6�   $��8,8,5,8q�6�   $
��Fill=�6�    J� Clip# [  6�   ��6a   �� *	HeadImage+6  �� 5>       ��Name$ userName��6$   $��1��66   $
��Left=�6`   $��Center=�6{   $��5q�6�   ��6F   �� *
UserName+6�   �� 5?      $
 time��6$   $��1��62   $��Right=�6_   $��Center=�6{   $
��20,5q�6�   ��6B   �� *MessageTime+6�   �� 5@      $ massage��6$   $��1��65   $��1��6[   $
��Left=�6l   $	��Top=�6�   $��5,5,20,5q�6�   $y�Visible=�6�   ��6B   �� *	Message+6�   F� 5A       F�Name$
 icon��6   -   5        $��2��5A   -   $��2��6B   $��Right=�6S   $��Center=�6o   $��5q�6�   $y�	Collapsed=�5B   #   $��8��5C   #   $��8��5D   #   ����������� ������� 6��ߌ 6�0����|������v0����v����|��ծ ��� ��|������v0�x��v�r�|��ml0��ml�ߌ�r �� ��������r����ul0��ml� ���r�.���x U����8Q� �'��Ү�?�����.��0�� U���� U����.�� 6��� 6�0�����
���   � J� Opacity$	 0.5Q�5G   #    �� Stretch$
 Fill=�5H   #    � Cursor$
 Hand��62   5I      5J       �� Triggers 5K      P� 5L       �@J�IsMouseOver . . �5M      �� $
 icon��6&    � y�$	 Visible=�6N   6`   5N      5P      5R      5T      5U      