   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp.ViewsWpfApp.Views  5      C&clr-namespace:WpfApp.Models.ViewModelsWpfApp.Models.ViewModels  5          WpfApp.Views.NewCaseView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:WpfApp.Views     5      =
viewmodels&clr-namespace:WpfApp.Models.ViewModels     5      .��5      � 
�������  � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $
��auto �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��	20 20 0 0q�6)   .+�5      �� $��Ärende: Nytt ärende��6   ���#4980FF$��10 0 0 0q�6L   $��Medium"�6^   $��16(�6r   �� 5      ���#4980FF$��4��6+   $	��170��66   $
��Left=�6B   $��0 5 0 0q�6]   5      �� 5      $��1��6   $��0 0 20 0q�6V   $��Right=�6h   ���#4980FF
�������$��Medium"�6�   $��0q�6�   $��X��6�   $��Center=�6�   $
��10 5q�6�   ��6%   �� *NavigateToActiveCasesCommand+6�   5      � 5   
   $��1��6   ���#F5FAFE 5      �� 5       $��* �6#   �� 5!      $��5 �6#   �� 5"      $��* �6#     5$      �� 5%      $
��auto �6    �� 5&      $
��auto �6    �� 5'      $��* �6    �� 5(      $
��auto �6    .+�5+      �� $��0��6   $��0��6%   $��3��65   $��Kundinformation��6I   $��10(�6`   
�������$��
30 20 30 0q�6�   �� 5-      $��1��6   $��0��6&   $��
50 20 10 0q�66   .+�5.      �� $��Kundens namn��6   $��10(�60   
�������6>   �� 5/      $��0 5 0 20q�6L   $��14(�6^   $��5q�6m   ��6   �� *" CaseEntity.Customer.CustomerName+6m   50      �� 52      $��1��6   $��2��6&   $��10 20 50 20q�66   .+�53      �� $��E-postadress��6   $��10(�60   
�������6>   �� 54      $��0 5 0 20q�6E   $��14(�6W   $��5q�6e   ��6   �� *CaseEntity.Customer.Email+6e   55      �� 57      $��2��6   $��0��6&   $��3��66   $��
50 0 50 20q�6J   .+�58      �� $��Beskrivning��6   $��10(�6/   
�������6=   �� 59      $��0 5 0 0q�6B   $	��350��6S   $��14(�6`   $��5q�6n   ��6   �� *CaseEntity.Description+6n   5:      �� 5<      $��3��6   $��0��6"   $��3��62   $��
50 0 50 20q�6j   ���#4980FF
�������$��Medium"�6�   $��0q�6�   $��Skapa ärende��6�   $��10 10q�6�   ��6F   �� *SaveCaseCommand+6�   5>      5?      5@      