   M S B A M L   `   `   `  ����I  EMVVM_WPF_Task1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:MVVM_WPF_Task1.ViewsMVVM_WPF_Task1.Views  5   	   E'clr-namespace:MVVM_WPF_Task1.ViewModelsMVVM_WPF_Task1.ViewModels  6:   #    MVVM_WPF_Task1.Views.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:MVVM_WPF_Task1.Views     5   	   >
ViewModels'clr-namespace:MVVM_WPF_Task1.ViewModels     6:     � Title$  MainView��5   	   $	��490��6   $	��380��6'    � DataContext 5	      -   'MVVM_WPF_Task1.ViewModels.MainViewModel  5
   
   6%   .��5      �� $	��350��6   .+�5   
   �� -   5        $��cbCars��5       �� SelectedValuePath$ Id��6c    �� DisplayMemberPath$ Vendor��6z   $��28(�6�    �� SelectedIndex$ 0��6�    �� SelectedItem 6!   �� *Car+ �� UpdateSourceTrigger$ PropertyChanged=���6�   �� *Cars+6�   �� 5   
   $��32(�6   $
��Bold"�6   .��60   Vendor68   �� 5   
   $��30(�6   ��6"   �� *
Car.Vendor+6@   �� 5   
   $��32(�6   $
��Bold"�6   .��60   Model67   �� 5   
   $��30(�6   ��6"   �� *	Car.Model+6?   �� 5   
   $��32(�6   $
��Bold"�6   .��60   Year66   �� 5   
   $��30(�6   ��6"   �� *
Car.Year+6>   �� 5   
   $��32(�61   $��10q�6?   ��6   �� *ShowCommand+.��6K   Show6Q   �� 5   
   $��32(�61   $��10q�6?   ��6   �� *EditCommand+.��6K   Edit6Q   5      5      