   M S B A M L   `   `   `  ����J  FFootballManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FootballManagerFootballManager  5   	   %    FootballManager.FirstTeamWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FootballManager     5   	     � Title$  Tigers��5   	   $	��450��6   $	��800��6%   .��5	      �  � RowDefinitions 5
   
   �� 5      $��45 �6   �� 5      �� 5      .+�5   
   �� $��18(�6   $��Center=�6   $��Center=�6;   $��5q�6V   $��0��5      $��Team members��6   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ FirstTeamDG��5         AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . $��1��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6    $��5q�60   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6;      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Id��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+  5      $	 
First Name��6%   
 69   �� *	FirstName+  5      $	 	Last Name��6%   
 68   �� *
LastName+  5      $	 Position��6%   
 67   �� *
Position+  5      $	 Date of birth��6%   
 6<   �� *
Birthday+ �� StringFormat$ 
dd-MM-yyyy��4  .System.Windows.Controls.DataGridTemplateColumn  5      $
	 Edit��6)      CellTemplate 5      �� 5      .R�5      �� -   5        $
��Edit��5   %   64   5      5        5       $	 Delete��6)    5!      �� 5"      .R�5#      �� -   5        $��Delete��5#   %   66   5$      5&      5(      � 5)   
   $��2��6    � ColumnDefinitions 5*      �� 5+      �� 5,      .+�5.      �� $��0��6   $��5q�6%   $��1q�60   
���   �._�5/      �� $��5q�6   .+�50      �� $��Add new player��6   $
��Bold"�65   $��Center=�51      $��Center=�52      $��5q�63   � 53      -   5        $��NewPlayerGrid��53       54      �� 55      �� 56      �� 57      �� 58      �� 59       5;      �� 5<      �� 5=      .+�5?      �� $��0��6    $��0��6-   $��
First Name��6=   �� 5@      $��0��6"   $��1��6/   ��6?   �� *	FirstName+�� 5A      $��1��6    $��0��6-   $��	Last Name��6=   �� 5B      $��1��6"   $��2��6/   ��6?   �� *
LastName+�� 5C      $��2��6    $��0��6-   $��Position��6=   �� 5D      $��2��6"   $��3��6/   ��6?   �� *
Position+�� 5E      $��3��6    $��0��6-   $��Date of birth��6=   �� 5F      $��3��6"   $��4��6/   ��6?   �� *
Birthday+$ 
dd-MM-yyyy���� 5G      -   5        $��4��5G   !   $��2��6.   $	��150��6B   $	��Add��6N   $��5q�6\   $��Center=�5H      $��Center=�6:   5I      5J      5K      �� 5L      $��1��6   $��5q�6%   $��1q�60   
���   �._�5M      �� $��5q�6   .+�5N      �� $��Edit player information��6   $
��Bold"�6>   $��Center=�5O      $��Center=�5P      $��5q�63   � 5Q      -   5        $��UpdatePlayerGrid��5Q       5R      �� 5S      �� 5T      �� 5U      �� 5V      �� 5W       5Y      �� 5Z      �� 5[      .+�5]      �� $��0��6    $��0��6-   $��
First Name��6=   �� 5^      $��0��6"   $��1��6/   ��6?   �� *	FirstName+�� 5_      $��1��6    $��0��6-   $��	Last Name��6=   �� 5`      $��1��6"   $��2��6/   ��6?   �� *
LastName+�� 5a      $��2��6    $��0��6-   $��Position��6=   �� 5b      $��2��6"   $��3��6/   ��6?   �� *
Position+�� 5c      $��3��6    $��0��6-   $��Date of birth��6=   �� 5d      $��3��6"   $��4��6/   ��6?   �� *
Birthday+$ 
dd-MM-yyyy���� 5e      -   5        $��4��5e   !   $��2��6.   $	��150��6B   $
��Edit��5f   !   $��5q�60   $��Center=�5g      $��Center=�6:   5h      5i      5j      5k      5l      5m      