   M S B A M L   `   `   `  ����I  EWPFMiniProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFMiniProjectWPFMiniProject  5   	       WPFMiniProject.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFMiniProject     5   	     � Title$(  "WPF Mini Project by Lingling Zhang��5   	   $	��450��64   $	��800��6A   $��22(�6M   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6!   $��0 20 5 0q�61   
First Name5      �� 5   
   -   5         ��Name$ 	firstName��5      $��0��6%   $��2��62   $	��200��6B   $	��300��6Q   $��0 20 0 0q�6`   6t   �� 5   
   $��1��6   $��1��6!   $��0 20 5 0q�61   	Last Name5      �� 5    
   -   5        $ lastName��5       $��1��6$   $��2��61   $	��200��6A   $	��300��6P   $��0 20 0 0q�6_   6s   �� 5!   
   $��2��6   $��1��6!   $��0 20 5 0q�61   	Address5#      �� 5$   
   -   5         ��Name$ 
addAddress��5$      $��2��6%   $��2��62   $��50��6B   $��Center=�5%      $��0 20 0 0q�6.   .��5&   *   Add5(      �� 5)   
   -   5         ��Name$ addressList��5)      $��3��6'   $��1��64   $��2��6D   $��0 5 0 0q�6X   $��80��6i   ��5*      �� 5+      .R�5,      ��  �� Orientation$ Vertical=�6!   .+�5-      �� ��6$   ��  �� Path$ Street�6C   �� 5.      $ 
Horizontal=�6%   .+�5/      �� $��12(�6E   ��6(   �� $ Suburb�6U   �� 50      $��, ��6(   $��12(�62   6B   �� 51      $��12(�6C   ��6(   �� $
 City�6S   �� 52      $��  ��6(   $��12(�62   6B   �� 53      $��12(�6F   ��6(   �� $ ZipCode�6V   54      55      56      58      �� 59   
   -   5        $ 
savePerson��59      $��4��6%   $��1��62   $��2��6B   $��5 30 5 0q�6V   .��5:   *   Save5<      5=      5>      