   M S B A M L   `   `   `  ����G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko  5          Pavlyuchenko.UserLookPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Pavlyuchenko     5      -   5          N� Title$  UserLookPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ ClearBtn��5      $��
Назад��5      $��0��5      $
��Left=�5      $��Center=�5      $��5q�5      �� 5   
   -   5        $ AddBtn��5      $��Добавить��5       $��0��5"      $��1��5#      $
��Left=�5$      $��Center=�5%      $��5q�5&      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ DG��5(      $��1��6   $��2��6,      AutoGenerateColumns .     
IsReadOnly .    Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 62   �� *ФИО+  5+      $ Роль��6%   	 63   �� *Роли.Название+4  .System.Windows.Controls.DataGridTemplateColumn  5,      -   5        	UpTel��
   CellTemplate
 5-      �� 5.      .R�5/      �� $ UpBtn��6%   -   5        $��Изминить��50   %   51   %   52      54        55      -   5        
DelTel��
 56      �� 57      .R�58      �� $ DelBtn��6%   -   5        $��Удалить��59   %   5:   %   5;      5=      5?      5@      5A      