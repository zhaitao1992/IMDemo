   M S B A M L   `   `   `  ����M  IHadayIMWpfControls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:HadayIMWpfControls.WPFControls.Win"HadayIMWpfControls.WPFControls.Win  5   	   O,clr-namespace:HadayIMWpfControls.WPFControlsHadayIMWpfControls.WPFControls  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   7    1HadayIMWpfControls.WPFControls.Win.MessageManager   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:HadayIMWpfControls.WPFControls.Win     5   	   @control,clr-namespace:HadayIMWpfControls.WPFControls     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	     � WindowStyle$
  None=�5
   	    � 
ResizeMode$ NoResize=�5   	    � Title$ MessageManager��5   	   $	��600��6    $	��800��6-    � 	Resources 5         clipGeometry � FillRule @� RadiusX @� RadiusY @� Center  Item.MouseOver.Background �� Color  Item.IsSelected.Background  Item.TextBlock.Foreground��%�   &	        &	 n     &	 �     &	 �     � 5   
   $ Nonzero=�6-   .��5      @� $ 14Q�6   $ 14Q�6+   $ 14, 14&�68   6J   5      �� 5   
   $ #FFFFFF��6<   �� 5   
   $ #FFFFFF��6=   �� 5   
   $ Black��6<   5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��30 �6   �� 5      $��40 �6   �� 5      
 � ColumnDefinitions
 5   
   �� 5      $	��180 �6   �� 5       .+�5"      �� -   5        ���#5cb1df$��30��5"   '   $��2��63   6d   �� 5#   
   $
��Left=�6   $��Center=�60    �� Orientation$ 
Horizontal=�6K   $��2��6d   .+�5$      �� $��../Images/messageIcon.png��6   $��15��67   $
��10,0q�6C   6T   �� 5%      $��14(�6   
�������消息管理器6A   5&      �� 5'   
   $��2��6   $ 
Horizontal=�6)   $��Right=�6C   $	��Top=�6_   $��5q�6w    J� Opacity$ 1Q�6�   $y�Visible=�6�   .+�5(      �� -   5        $��20��5(      $��20��6!   $��0q�6-   
������ $��Right=�6Z   $	��Top=�6v   $	��5,0q�6�   .��5)      �� $��../Images/upload.png��6   $��20��66   $��20��6A   6O   5*      �� 5+      -   5        $��20��5+      $��20��6!   $��0q�6-   
������ $��Right=�6Z   $	��Top=�6v   $	��5,0q�6�   .��5,      �� $��../Images/min.png��6   $��20��63   $��20��6>   6L   5-      �� 5.      -   5        $��20��5.      $��20��6!   $��0q�6-   
������ $��Right=�6Z   $	��Top=�6v   $	��5,0q�6�   .��5/      �� $��../Images/max.png��6   $��20��63   $��20��6>   6L   50      �� 51      -   5        $��2��51      $��20��6)   $��20��64   $��Right=�6@   $	��Top=�6\   $��0q�6t   
������ $	��5,0q�6�   .��52      �� $��../Images/close.png��6   $��20��65   $��20��6@   6N   53      54      �� 55   
   -   5         ��Name$ chatNavigationList��55      $��1��6.   $��3��6;   ���#f1f1f1$��1,0,0,1q�6a   ���#c9c9c9$��-1q�6�   $��0q�6�   #��[ 6�   ��56      �� 57       �� 
TargetType" ��6   .�58      ��  �� Property � �� �� Value$ -0q�6/   �� 59       � ��$ -0q�60   �� 5:       � �� 5;      �� 5<       �� 
TargetType" ��6.   .R�5=   "   � #��z��6'   .+�5>   &   ��  ��Name$ selectedBackground��6-   
�������$��3��6\   $
��Left=�6f   $y�Hidden=�6�   6�   �� 5?   &   #��z��67   #��z��6[   5@   #    �� Triggers 5A   "   P� 5B   &    P� Property �@J�IsMouseOver P� Value . . �5C   *   �� # [ 6G    � ��6|   5D   '   P� 5E   &    �@��
IsSelected . . �5F   *   ��  �� 
TargetName$ selectedBackground��61    � y�$ Visible=�6g   6y   �� 5G   *   # [ 6H    � ��6~   5H   '   5J      5L      5M      ��5O      �� 5P      .R�5Q      � $	��175��6   
������ 
 5R      �� 5S      $
��auto �6/   �� 5T      $��* �6/   .+�5V      ��  ��Name$ 	headImage��6    $��0��63   $��0��6@   $��2��6P   $��28��6~   $��28��6�   $
��Left=�6�   $��Center=�6�   $��8,8,5,8q�6�   $
��Fill=�6�    J� Clip# [  6�   ��6a   �� *	HeadImage+6  F� 5W       F�Name$
 icon��6   -   5        $��1��5W   -   $��Right=�6=   $��Center=�6Y   $��5q�6t   $y�	Collapsed=�5X   #   $��8��5Y   #   $��8��5Z   #   ����������� ������� 6��ߌ 6�0����|������v0����v����|��ծ ��� ��|������v0�x��v�r�|��ml0��ml�ߌ�r �� ��������r����ul0��ml� ���r�.���x U����8Q� �'��Ү�?�����.��0�� U���� U����.�� 6��� 6�0�����
���   �$	 0.5Q�5]   #    �� Stretch$
 Fill=�5^   #    � Cursor$
 Hand��62   5_      �� 5`       ��Name$ userName��6$   $��1��66   $
��Left=�6`   $��Center=�6{   $��0,5,20,5q�6�   ��6F   �� *
UserName+6�   5b       �� Triggers 5c      P� 5d       �@J�IsMouseOver . . �5e      �� $
 icon��6&    � y�$ Visible=�6N   6`   5f      5h      5j      �� 5l   
   $��1��6   $��1��6   ���#c9c9c9$��0,0,1,0q�6D   6`   �� 5m   
   $��1��6   $��1��6"   $
��Left=�63   $��Center=�6N   $ 
Horizontal=�6i   .+�5n      �� -   5        $ 	otherUser��5n   &   $��15(�6   6&   5o      �� 5p   
   $��1��6   $��1��6"   $��Right=�63   $��Center=�6O   $ 
Horizontal=�6j   $��8q�6�   .+�5q      �� -	   5        $��0q�5q      
������ $��Right=�6D   $	��Top=�6`   $	��5,0q�6y   .��5r      �� $!��../Images/arrow_refresh.png��6   $	 0.8Q�6=   $
 Hand��6K   6[   5s      �� 5t      -
   5        $��0q�5t      
������ $��Right=�6D   $	��Top=�6`   $	��5,0q�6y   .��5u      �� $��../Images/delete.png��6   $	 0.8Q�67   $
 Hand��6E   6U   5v      5w      4   .HadayIMWpfControls.WPFControls.ChatHistoryList  5x   
   -   5          Name$ chatHistoryList��5x   "   $��2��6;   $��1��6H   6Z   5|      5      