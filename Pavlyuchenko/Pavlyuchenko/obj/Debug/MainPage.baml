   M S B A M L   `   `   `  ����G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko  5          Pavlyuchenko.MainPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Pavlyuchenko     5      -   5          N� Title$  MainPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ 	AddZakBtn��5      $!��Добавить Заказ��5      $��0��5      $
��Left=�5      $��Center=�5      $��5q�5      �� 5    
   -   5        $ UserLookBtn��5       $-��'Список пользователей��5!      $��0��5#      $��1��5$      $
��Left=�5%      $��Center=�5&      $��5q�5'      �� 5(   
   -   5        $ klientLookBtn��5(      $#��Список клиентов��5)      $��0��5+      $��2��5,      $
��Left=�5-      $��Center=�5.      $��5q�5/      �� 50   
   -   5        $ TranspLookBtn��50      $'��!Список транспорта��51      $��0��53      $��3��54      $
��Left=�55      $��Center=�56      $��5q�57      �� 58   
   -   5        $ PosilkaLookBtn��58      $��Список товара��59      $��0��5;      $��4��5<      $
��Left=�5=      $��Center=�5>      $��5q�5?      &   System.Windows.Controls.DataGrid  5A   
   -   5          Name$ DG��5A      $��1��6   $��5��6,      AutoGenerateColumns .     
IsReadOnly .    Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Header$ Посылка��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� *!Посылки.Название+  5D      $ Адрес ��6%   	 65   �� *Клиенты.Адрес+  5E      $ Посылка��6%   	 66   �� *0.Клиенты.Пользователи.ФИО+4  .System.Windows.Controls.DataGridTemplateColumn  5F      $' !Утвержден маршрут��6)   -   5        ChB1��
   CellTemplate
 5G      �� 5H      .R�5I      �� -	   5         d� 	IsChecked 5I   '   �� *Утверждено+6H   5J      5L        5M      $' !Утвержден маршрут��6)   -
   5        ChB0��
 5N      �� 5O      .R�5P      ��  J� IsHitTestVisible .   6'   �� *Утверждено+6H   5Q      5S        5T      
 5U      �� 5V      .R�5W      �� $ MarsBtn��6%   -   5        $��Маршрут��5X   %   5Y   %   5Z      5\        5]      -   5        	UpTel��
 5^      �� 5_      .R�5`      �� $ UpBtn��6%   -   5        $��Изминить��5a   %   5b   %   5c      5e        5f      -   5        
DelTel��
 5g      �� 5h      .R�5i      �� $ DelBtn��6%   -   5        $��Удалить��5j   %   5k   %   5l      5n      5p      5q      5r      