   M S B A M L   `   `   `  ����I  EWPFMiniProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFMiniProjectWPFMiniProject  5   	   !    WPFMiniProject.AddressEntry   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFMiniProject     5   	     � Title$  Address Entry��5   	   $	��450��6   $	��800��6,   $��22(�68   .��5	      �  � ColumnDefinitions 5
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
   �� $��0��6   $��1��6!   $��0 20 5 0q�61   $��Right=�6C   Street5      �� 5   
   -   5         ��Name$ street��5      $��0��6"   $��2��6/   $	��200��6?   $	��300��6N   $��0 20 0 0q�6]   6q   �� 5   
   $��1��6   $��1��6!   $��0 20 5 0q�61   $��Right=�6C   Suburb5      �� 5    
   -   5        $ suburb��5       $��1��6"   $��2��6/   $	��200��6?   $	��300��6N   $��0 20 0 0q�6]   6q   �� 5!   
   $��2��6   $��1��6!   $��0 20 5 0q�61   $��Right=�6C   City5#      �� 5$   
   -   5        $
 city��5$      $��2��6    $��2��6-   $	��200��6=   $	��300��6L   $��0 20 0 0q�6[   6o   �� 5%   
   $��3��6   $��1��6!   $��0 20 5 0q�61   $��Right=�6C   
Zip Code5'      �� 5(   
   -   5        $ zipCode��5(      $��3��6#   $��2��60   $	��200��6@   $	��300��6O   $��0 20 0 0q�6^   6r   �� 5)   
   -   5         ��Name$ 
saveAdress��5)      $��4��6%   $��1��62   $��2��6B   $��5 30 5 0q�6V   .��5*   *   Save5,      5.      5/      