   M S B A M L   `   `   `  ����F  BWpfProject1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfUkolWpfUkol  5   	       WpfUkol.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfUkol     5   	     � Title$  Prodeje_Aut��5   	   $	��450��6   $	��800��6*    � WindowStartupLocation$ CenterScreen=�66   .��5	      � $��10q�6   .+�5
   
   �� -   5         ��Name$ btnLoad��5
      $��Load xml��6"   $
��Left=�65   $��593,120,0,0q�6P   $	��Top=�6e   6}   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DataGridData��5      $��25,25,334,229q�6)   �� 5   
   -   5        $ btnShow��5      $��Show weekend sales��6"   $
��Left=�6?   $��593,187,0,0q�6Z   $	��Top=�6o    J� RenderTransformOrigin$ 0.253,0.503&�6�   6�   �� 5   
   -   5         ��Name$ lbLoad��5      $��Load your XML file��6    $
��Left=�6=   $��
593,64,0,0q�6X   $	��Top=�6l   �� 5   
   -   5         ��Name$ ListWiewResult��5      $��25,226,359,41q�6+   $	��300��6g   ��6B   �� *weekendSales+��5      �� 5      .R�5      � $	��300��6   $	��120��6'    � ColumnDefinitions 5      �� 5      $	��100 �6/   �� 5      $	��200 �6/    � RowDefinitions 5      �� 5      $��30 �6,   �� 5      $��30 �6,   �� 5      $��30 �6,   �� 5      $��30 �6,   .+�5      �� $��0��6    $��0��6-   $��Model��6=   
�������6M   �� 5      $��1��6    $��0��6-   $��Prize��6=   
�������6M   �� 5       $��0��6    $��1��6-   $�� ��6=   
�������6H   �� 5!      $��1��6    $��1��6-   $��	Prize DPH��6=   
�������6Q   �� 5"      $��2��6$   ��61   �� *Model+�� 5#      $��3��6$   ��61   �� *Suma+�� 5$      $��1��6$   $��3��64   ��6A   �� *	SumaDPH+5%      5&      5(      5*      5+      