   M S B A M L   `   `   `  ����A  =WpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5   	   5clr-namespace:WpfApp.ViewModelsWpfApp.ViewModels  5   	   +clr-namespace:WpfApp.ViewsWpfApp.Views  5   	       WpfApp.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:WpfApp     5   	   6
viewModelsclr-namespace:WpfApp.ViewModels     5   	   ,viewsclr-namespace:WpfApp.Views     5   	     � Title$  WpfApp��5   	   $	��650��6   $
��1150��6%   .��5      � ���#212E3F � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   � $��0��6   $��10q�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��0��6    �� Orientation$ 
Horizontal=�6)   $��Center=�6C   .+�5      �� 
�������$��
0 0 20px 0q�6I   $
��Thin"�6]   $��22(�6o   $��Center=�6}   ��6   �� *
AppTitle+6}   �� 5      $��Nytt Ärende��6   $
��10 4q�6\   ���#4980FF
�������$��Medium"�6�   $��0q�6�   ��6/   �� *NavigateToNewCaseCommand+6�   5      5      �� 5   
   $��1��6   ��6&   �� *CurrentViewModel+ � 	Resources 5        �� DataType,  &WpfApp.ViewModels.ActiveCasesViewModel"   WpfApp.Views.ActiveCasesView%  WpfApp.ViewModels.CaseViewModel   WpfApp.Views.CaseView+  %WpfApp.ViewModels.CreateUserViewModel!   WpfApp.Views.CreateUserView)  #WpfApp.ViewModels.HandlersViewModel   WpfApp.Views.HandlersView(	  "WpfApp.ViewModels.NewCaseViewModel
   WpfApp.Views.NewCaseView��%w  (��       5!      *, +)(�� 2     5$      *, +)(�� d     5'      *, +)(�� �     5*      *, +)(�� �     5-      *,	 +)�� 5!      "  6   .R�5"        5#      �� 5$      "  6   .R�5%        5&      �� 5'      "  6   .R�5(        5)      �� 5*      "  6   .R�5+        5,      �� 5-      " 	 6   .R�5.      
  5/      50      51      53      54      