   M S B A M L   `   `   `  ���� G  CPavlyuchenko, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:PavlyuchenkoPavlyuchenko  !    Pavlyuchenko.KlientLookPage   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     ,localclr-namespace:Pavlyuchenko     -     N� Title$  KlientLookPage��.���  � RowDefinitions �� $
��auto ��� $��* � � ColumnDefinitions �� $
��auto ��� $��* �.+��� -    ��Name$ ClearBtn��$��
Назад��$��0��$
��Left=�$��Center=�$��5q��� -   $ AddBtn��$��Добавить��$��0��$��1��$
��Left=�$��Center=�$��5q�&   System.Windows.Controls.DataGrid  -     Name$ DG��$��1��$��2��   AutoGenerateColumns .     
IsReadOnly .    Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ 
Адрес��1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 �� *
Адрес+  $ Пользовател��	 �� *!Пользователи.ФИО+4  .System.Windows.Controls.DataGridTemplateColumn  -   	UpTel��
   CellTemplate
 �� .R��� $ UpBtn��-   $��Изминить��  -   
DelTel��
 �� .R��� $ DelBtn��-   $��Удалить��