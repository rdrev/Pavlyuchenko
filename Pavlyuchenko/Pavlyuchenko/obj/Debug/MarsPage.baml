   M S B A M L   `   `   `  ����G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko  5          Pavlyuchenko.MarsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Pavlyuchenko     5      -   5          N� Title$  MarsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ClearBtn��5      $��
Назад��5      $��0��5      $
��Left=�5      $��Center=�5      $��5q�5      �� 5   
   -   5        $ 
AddMarsBtn��5      $%��Добавить Маршрут��5      $��0��5!      $��1��5"      $
��Left=�5#      $��Center=�5$      $��5q�5%      &   System.Windows.Controls.DataGrid  5'   
   -   5          Name$ DG��5'      $��1��6   $��2��6,      AutoGenerateColumns .     
IsReadOnly .    Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)      ,  &System.Windows.Controls.DataGridColumn   Header$ Номер Этапа��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6:   �� *НомерЭтапа+  5*      $ Транспорт��6%   	 68   �� *Транспорт+  5+      $# Начальный Адрес��6%   	 6>   �� *НачальныйАдрес+  5,      $! Конечный Адрес��6%   	 6=   �� *КонечныйАдрес+4  .System.Windows.Controls.DataGridTemplateColumn  5-      $' !Утвержден маршрут��6)   -   5        ChB1��
   CellTemplate
 5.      �� 5/      .R�50      �� -   5         d� 	IsChecked 50   '   �� *Выполнено+6G   51      53        54      $' !Утвержден маршрут��6)   -   5        ChB0��
 55      �� 56      .R�57      ��  J� IsHitTestVisible .   6'   �� *Выполнено+6G   58      5:        5;      -   5        	UpTel��
 5<      �� 5=      .R�5>      �� $ UpBtn��6%   -	   5        $��Изминить��5?   %   5@   %   5A      5C        5D      -
   5        
DelTel��
 5E      �� 5F      .R�5G      �� $ DelBtn��6%   -   5        $��Удалить��5H   %   5I   %   5J      5L      5N      5O      5P      