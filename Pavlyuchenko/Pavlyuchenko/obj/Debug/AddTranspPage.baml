   M S B A M L   `   `   `  ����G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko  5           Pavlyuchenko.AddTranspPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Pavlyuchenko     5        N� Title$  AddTranspPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��
Номер��6   $��1��5      $��5q�5      $��Right=�5      $��Center=�5      �� 5    
   $!��Вид транспорта��6   $��2��5!      $��5q�5"      $��Right=�5#      $��Center=�5$      �� 5%   
   $��Водитель��6   $��3��5&      $��5q�5'      $��Right=�5(      $��Center=�5)      �� 5+   
   $��1��5,      $��1��5-      $	��300��5.      $��5q�5/      $
��Left=�50      ��5+      �� *
Номер+50      �� 51   
   $��1��52      $��2��53      $	��300��54      $��5q�55      $
��Left=�56      ��51      �� *ВидТранспорта+56      �� 57   
   -   5        $	��CBP��57       �� DisplayMemberPath$ ФИО��59      $	��300��5:      $��5q�5;      $��1��5<      $��3��5=      $
��Left=�5>       �� SelectedItem 58      �� *Пользователи+5>      �� 5@   
   -   5         ��Name$ OkBtn��5@      $��Ok��5A      $��4��5C      $��5q�5D      $��Right=�5E      $��Center=�5F      $��70��5G      �� 5H   
   -   5        $ ClenBtn��5H      $��
Назад��5I      $��1��5K      $��4��5L      $��5q�5M      $
��Left=�5N      $��Center=�5O      $��70��5P      5Q      5R      