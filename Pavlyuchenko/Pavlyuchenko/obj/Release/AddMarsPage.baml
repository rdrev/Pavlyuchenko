   M S B A M L   `   `   `  ���� G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko      Pavlyuchenko.AddMarsPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:Pavlyuchenko       N� Title$  AddMarsPage��.���  � ColumnDefinitions �� $	��120 ��� $��* � � RowDefinitions �� $��30 ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $��* �.+��� $��Транспорт��$��1��$��5q�$��Right=�$��Center=��� $��Номер этапа��$��2��$��5q�$��Right=�$��Center=��� $#��Налальный адрес��$��3��$��5q�$��Right=�$��Center=��� $!��Конечный адрес��$��4��$��5q�$��Right=�$��Center=��� -   $	��CBT�� �� DisplayMemberPath$ 
Номер��$	��300��$��5q�$��1��$��1��$
��Left=� �� SelectedItem �� *Транспорты+�� $��1��$��2��$	��300��$��5q�$
��Left=����� *НомерЭтапа+�� $��1��$��3��$	��300��$��5q�$
��Left=����� *НачальныйАдрес+�� $��1��$��4��$	��300��$��5q�$
��Left=����� *КонечныйАдрес+�� -    ��Name$ OkBtn��$��Ok��$��5��$��5q�$��Right=�$��Center=�$��70���� -   $ ClenBtn��$��
Назад��$��1��$��5��$��5q�$
��Left=�$��Center=�$��70��