   M S B A M L   `   `   `  ����A  =MVVM_1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MVVM_1.ViewModelMVVM_1.ViewModel  5   	       MVVM_1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4	viewmodelclr-namespace:MVVM_1.ViewModel     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5	      *   $MVVM_1.ViewModel.MainWindowViewModel  5
   
   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��10 �6   �� 5       � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��20 �6   �� 5      $��50 �6   �� 5      $
��Auto �6   .+�5   
   �� $��Right=�6   $��Center=�60   Imię6Q   �� 5   
   $��1��6   $��0��6!   $��Right=�61   $��Center=�5      
Nazwisko69   �� 5   
   $��0��6   $��2��6   $��Center=�6/   $	��100��6J   $
��Left=�6V   ��5      �� *Name+ �� UpdateSourceTrigger$ PropertyChanged=��� 5   
   $��1��6   $��2��6   $��Center=�6/   $	��100��6J   $
��Left=�6V   ��5      �� *	Surname+$ PropertyChanged=��� 5    
   $��2��6   $��2��6   $	��100��6.   $
��Left=�6:   ��5!      �� *ValidateCommand+ �� Mode$ TwoWay=�.��6B   
Sprawdź6K   �� 5"   
   $��3��6   $��2��6!   $
��Left=�61   $��Center=�5#      ��6/   �� *Result+$ PropertyChanged=�5$      5%      