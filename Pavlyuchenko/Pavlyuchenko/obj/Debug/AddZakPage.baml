   M S B A M L   `   `   `  ����G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko  5          Pavlyuchenko.AddZakPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Pavlyuchenko     5        N� Title$  
AddZakPage��5	      .��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��Посылка��6   $��1��5      $��5q�5      $��Right=�5      $��Center=�5      �� 5   
   -   5         ��Name$	 TBK��5      $��Клиент��5      $��2��5       $��5q�5!      $��Right=�5"      $��Center=�5#      �� 5%   
   -   5        $	��CBP��5%       �� DisplayMemberPath$ Название��5'      $	��300��5(      $��5q�5)      $��1��5*      $��1��5+      $
��Left=�5,       �� SelectedItem 5&      �� *Посылки+5,      �� 5-   
   -   5        $	��CBK��5-      $% Пользователи.ФИО��5/      $	��300��50      $��5q�51      $��1��52      $��2��53      $
��Left=�54       5.      �� *Клиенты+54      �� 56   
   -   5         ��Name$ OkBtn��56      $��Ok��57      $��3��59      $��5q�5:      $��Right=�5;      $��Center=�5<      $��70��5=      �� 5>   
   -   5        $ ClenBtn��5>      $��
Назад��5?      $��1��5A      $��3��5B      $��5q�5C      $
��Left=�5D      $��Center=�5E      $��70��5F      5G      5H      