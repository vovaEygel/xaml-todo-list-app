   M S B A M L   `   `   `  ����D  @mytodoapp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:mytodoapp	mytodoapp  5   	       mytodoapp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:mytodoapp     5   	     � Title$  
MainWindow��5   	   $	��480��6   $	��800��6)   .��5	      � ���#242638 � RowDefinitions 5
      �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��10q�6   ���#FAE800$��20(�65    �� TextAlignment$
 left=�6C   $��0��6X   $��
Todo Items��6e   �� 5   
   $��1��6   $��0q�6p   $	��Top=�6�   $��Visible=�5      ��. ! �� IsDeferredScrollingEnabled . ��5       �� *Todos+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=���5      �� 5      .R�5      � $
��auto��6    5      �� 5   "   $��40 �60   �� 5   "   $
��Auto �60    � ColumnDefinitions 5      �� 5   "   $
��auto �63   �� 5   "   $
��auto �63   .+�5       �� $��1q�6'   $��Center=�6;   $��2��6V   $��20q�6�    d� 	IsChecked 6g   �� *status+$ TwoWay=� � LayoutTransform 5!   "   �� 5"   &   	 �� ScaleX$		 1.5Q�65   
 �� ScaleY$	
 1.5Q�6B   5$      �� 5%      $��0��6(   $��20(�65   $��1��6C   $��	10 10 0 0q�6S   ��6f   �� *title+�� 5&      $	��600��6(   $��1��64   ���#B9B9B9$��1��6V   $��
20 10 0 10q�6f   $
��Wrap=�6z   ��6�   �� *description+5'      5)      5+      �� 5,   
    �� Orientation$ 
Horizontal=�6   $��Right=�6.   $��2��6J   $��
0,300,30,0q�6W   .+�5-      �� -   5        $��0q�5.      ���#FC4850$��Right=�51      $��1��52      $��0��53      $��0q�54      $��20(�55      $��Center=�56      $��Center=�57      $��50��58      $��50��59         RoundButton#���   5:      $��10q�5;      .��5<      �� $��Center=�6   $��35��65   $��35��6@   $��/img/delete.png��6L   5=      �� 5>      -   5        $��0q�5@      $��Right=�5A      ���#FAE800$��1��5C      $��1��5D      $��0q�5E      $��40(�6   $��Center=�5F      $��Center=�5G      $��50��5H      $��50��5I      #���   5J      $��10q�5K      .��5L      �� $��Center=�6   $��35��65   $��35��6@   $��/img/plus.png��6L   5M      5N      5O      5P      