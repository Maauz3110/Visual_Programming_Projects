   M S B A M L   `   `   `  ����O  K233599_Assignment-04, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:_233599_Assignment_04_233599_Assignment_04  5   	   &     _233599_Assignment_04.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   5local#clr-namespace:_233599_Assignment_04     5   	     � Title$  Cricket Team Manager��5   	   $	��400��6&   $	��400��63    � 	Resources 5      7   1_233599_Assignment_04.StringToVisibilityConverter   StringToVisibilityConverter��%   &	          5	   
   6,   5
      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��Cricket Team Manager��6   $��20(�5      $
��Bold"�5      $��Center=�5      $��0,0,0,10q�5      �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Center=�6;   $��	0,10,0,10q�6X   .+�5      � .+�5      �� -   5         ��Name$ PlayerNameTextBox��5      $	��200��5      $��30��5       �� 5!      $��Enter Player Name��6   
�������$��Center=�5#      $
��Left=�5$      $��5,0,0,0q�5%       J� IsHitTestVisible .  y�5'      �� *Text+ �� ElementName$ PlayerNameTextBox�� �� 	Converter# [  5(      �� 5)      -   5         ��Name$ AddPlayerButton��5)      $��
Add Player��5*      $	��100��5+      $��10,0,0,0q�5,      
������$��14(�5.      5/      50      �� 53   
   $��2��6   .+�55      �� -   5        	 ��Name$	 PlayersListBox��55      $	��200��56      $��0,0,0,10q�57      $��14(�59      ��58      �� *	Players+59      �� 5;      -   5        $ RemovePlayerButton��5;      $��Remove Player��5<      $	��120��5=      $��Center=�5>      
�������$��14(�5@      5A      5B      5C      5D      