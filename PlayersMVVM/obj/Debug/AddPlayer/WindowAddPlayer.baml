   M S B A M L   `   `   `  ����F  BPlayersMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PlayersMVVM.AddPlayerPlayersMVVM.AddPlayer  5   	   Q-clr-namespace:PlayersMVVM.TbWithErrorProviderPlayersMVVM.TbWithErrorProvider  5   	   ?$clr-namespace:PlayersMVVM.ConvertersPlayersMVVM.Converters  5   	   +    %PlayersMVVM.AddPlayer.WindowAddPlayer   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:PlayersMVVM.AddPlayer     5   	   ?tbwep-clr-namespace:PlayersMVVM.TbWithErrorProvider     5   	   5con1$clr-namespace:PlayersMVVM.Converters     5   	   -   5          �Name$  addNewPlayerWindow��5
   :    � Title$ WindowAddPlayer��6	   $	��270��6!   $	��400��6.    � 	Resources 5      1   +PlayersMVVM.Converters.BooleanAndConverters   booleanAndConverters��%   &	          5   
   6$   5      .��5      �  � DataContext 6   �� *	NewPlayer+ � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��2* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��Imię:��6   $��0��6!   $��0��6.   $��5q�6>   >   8PlayersMVVM.TbWithErrorProvider.TextBoxWithErrorProvider  5   
   -   5          Name$ newPlayerFirstNameTbwep��5   Y   $��0��5   Q   $��1��6^   $��Stretch=�6n   $��Center=�5   ,   $��5q�6N      Text 5   )   �� *	FirstName+ �� Mode$ TwoWay=�5   Y   �� 5   
   $��	Nazwisko:��6   $��1��6%   $��0��62   $��5q�6B     5    
   -   5        $ newPlayerLastNameTbwep��5!   Y   $��1��5    P   $��1��6]   $��Stretch=�6m   $��Center=�5!   ,   $��5q�6N    5    )   �� *
LastName+$ TwoWay=�5!   Y   �� 5#   
   $��Wiek:��6   $��2��6!   $��0��6.   $��5q�6>   �� 5$   
   -   5        	 ��Name$	 comboBoxRangeOfAge��5&   Q   $��2��5%   $   $��1��61   $��Stretch=�6A   $��Center=�5&   $   $��5q�6F   
 �� SelectedValue$
 25��5'   $   ��5$      ��  �� Path$ DataContext.RangeOfAge� �� RelativeSource ��  �� AncestorType$ WindowL� �� SelectedItem 5'   7   �� *Age+$ TwoWay=��� 5)   
   $��Waga:��6   $��3��6!   $��0��6.   $��5q�6>   �� 5*   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   .+�5+      �� -   5         ��Name$ sliderWeight��5,   B    � Minimum$ 50Q�5+       � Maximum$	 110Q�6"    �� TickFrequency$	 0.1Q�60    �� IsSnapToTickEnabled . $��5q�5,      $��Stretch=�6$   $	��140��6X    � Value 5+   _   �� *Weight+$ TwoWay=�5,   X   �� 5-      $��5q�6f   ��6   ��  �� ElementName$ sliderWeight��$ Value� �� StringFormat$ {0} kg��6f   5.      �� 50   
   $��4��6   $��1��6"   $ 
Horizontal=�62   .+�51      �� -   5         ��Name$ 	addButton��51   <   $��Dodaj��6   $��10q�6%   $��50��61   {�52      `� 53       `� 	Converter# [  6#   .1�54      �� $ newPlayerFirstNameTbwep��6"   $ 
IsNotEmpty�6H   �� 55      $ newPlayerLastNameTbwep��6"   $ 
IsNotEmpty�6G   56      58      �� 59      -   5        $ cancelButton��59   =   $��Anuluj��6   $��10q�6&   $��50��62   6S   5:      5;      5<      