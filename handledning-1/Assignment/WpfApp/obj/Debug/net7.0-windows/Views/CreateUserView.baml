   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp.ViewsWpfApp.Views  5      5clr-namespace:WpfApp.ViewModelsWpfApp.ViewModels  5      !    WpfApp.Views.CreateUserView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp.Views     5      6
viewModelsclr-namespace:WpfApp.ViewModels     5      .��5      � 
�������  � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��	20 20 0 0q�6)   .+�5      �� $��Ny Handläggare��6   ���#4980FF$��10 0 0 0q�6G   $��Medium"�6Y   $��16(�6m   �� 5      ���#4980FF$��4��6+   $	��170��66   $
��Left=�6B   $��0 5 0 0q�6]   5      �� 5      $��1��6   $��0 0 20 0q�6%   $��Right=�67   ���#4980FF
�������$��Medium"�6{   $��0q�6�   $��X��6�   $��Center=�6�   $
��10 5q�6�   5      � 5   
   $��1��6   ���#F5FAFE 5      �� 5      $��* �6#   �� 5       $��5 �6#   �� 5!      $��* �6#     5#      �� 5$      $
��auto �6    �� 5%      $
��auto �6    �� 5&      $��* �6    �� 5'      $
��auto �6    .+�5*      �� $��0��6   $��0��6%   $��3��65   $��Handläggarinformation��6I   $��10(�6f   
�������$��
30 20 30 0q�6�   �� 5,      $��1��6   $��0��6&   $��
50 20 10 0q�66   .+�5-      �� $��Förnamn��6   $��10(�6+   
�������69   �� 5.      $��0 5 0 20q�6@   $��14(�6R   $��5q�6a   ��6   �� *UserEntity.FirstName+6a   �� 5/      $��E-postadress��6   $��10(�60   
�������6>   �� 50      $��0 5 0 0q�6<   $��14(�6M   $��5q�6[   ��6   �� *UserEntity.Email+6[   51      �� 53      $��1��6   $��2��6&   $��10 20 50 20q�66   .+�54      �� $��	Efternamn��6   $��10(�6-   
�������6;   �� 55      $��0 5 0 20q�6?   $��14(�6Q   $��5q�6_   ��6   �� *UserEntity.LastName+6_   57      �� 59      $��3��6   $��0��6"   $��3��62   $��
50 0 50 20q�6G   ���#4980FF
�������$��Medium"�6�   $��0q�6�   $��Skapa Handläggare��6�   $
��10 5q�6�   $��Center=�6�   5;      5<      5=      