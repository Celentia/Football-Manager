   M S B A M L   `   `   `  ����J  FFootballManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FootballManagerFootballManager  5   	       FootballManager.Matches   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FootballManager     5   	     � Title$  Match scores��5   	   $	��450��6   $	��800��6+   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ TeamDG��5
         AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly . $��1��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6    $��5q�60   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6;      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ First Team Name��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6>   �� *FirstTeamWindowName+  5      $ Second Team Name��6%   	 6?   �� *SecondTeamName+  5      $ Score��6%   	 64   �� *Score+  5      $
 Date��6%   	 63   �� *Date+5      �� 5   
   $
��Left=�6   $��59��6-   $��5,33,0,0q�69   
 �� TextWrapping$

 Wrap=�6K   $��Tigers��6_   $	��Top=�6m   $	��195��6�   �� 5   
   $
��Left=�6   $��59��6-   $��
205,33,0,0q�69   $

 Wrap=�6M   $��Barclays��6a   $	��Top=�6q   $	��189��6�   �� 5   
   $
��Left=�6   $��59��6-   $��
399,33,0,0q�69   $

 Wrap=�6M   $	��2-0��6a   $	��Top=�6l   $	��190��6�   �� 5   
   $
��Left=�6   $��59��6-   $��
594,33,0,0q�69   $

 Wrap=�6M   $��
10.05.2020��6a   $	��Top=�6s   $	��193��6�   �� 5   
   -   5        $��Go to the first team��5      $
��Left=�60   $��259,144,0,0q�6K   $	��Top=�6`   $	��115��6x   $��33��6�   6�   �� 5   
   -   5        $��Go to the second team��5      $
��Left=�61   $��420,144,0,0q�6L   $	��Top=�6a   $	��135��6y   $��33��6�   6�   5      5      