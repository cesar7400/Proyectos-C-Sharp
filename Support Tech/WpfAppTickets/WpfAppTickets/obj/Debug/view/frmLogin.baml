   M S B A M L   `   `   `  ����H  DWpfAppTickets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfAppTickets.viewWpfAppTickets.view  5   	   !    WpfAppTickets.view.frmLogin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:WpfAppTickets.view     5   	     � Title$  Iniciar sesión��5   	   $	��600��6    $	��400��6-    � WindowStyle$
 None=�69    � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�6b   $	��400��6�   $	��600��6�   $	��400��6�   $	��600��6�   .��5	      � -   5         �Name$ grdLogin��5	      $	��700��6   .+�5   
   �� $	��100��6   $��0,60,0,0q�6   $	��Top=�6/   $	��100��6G   $��Center=�6S   $��/images/logo.png��6p   �� 5   
   $��Iniciar sesión��6   $��Center=�6)   $��	0,188,0,0q�6F   $	��Top=�6Y    J� RenderTransformOrigin$ 1.171,0.295&�6q   $��28(�6�   $
��Bold"�6�   �� 5   
   -   5         ��Name$ txtUser��5      $��Center=�6#   $	��Top=�6@   $	��300��6X   $��18(�6d   
������ ���	#FF178FFE �� 
CaretBrush �	#FF2196F3$��50��6�   $��Stretch=�6�   $��16,10,21,10q�6�    �� MaxLines$ 1��6  $��2,2,2,2q�6  $��	0,303,0,0q�6(  	 �� 	MaxLength$	 20��6;  G� 5   
   -   5        
 G�Name$
 txtPassword��5       G� PasswordChar$	 •��6+   $��Center=�6<   $	��Top=�6Y   $	��300��6q   $��18(�6}   
������ ���	#FF178FFE G� 
CaretBrush �	#FF2196F3$��50��6�   $��Stretch=�6�   $��16,10,16,10q�6  $��2,2,2,2q�6  $��	0,413,0,0q�64   G� 	MaxLength$ 20��6G  �� 5   
   -   5         ��Name$ btnLogin��5      $��Iniciar sesión��6#   $��Center=�6<   $��	0,500,0,0q�6Y   $	��Top=�6l   $��50��6�   $	��300��6�   ���	#FF2196F3$��18(�6�   
�������$
��Bold"�6�   $��2��6�   �� 5   
   -   5         ��Name$ imgClose��5      $
��Left=�6"   $��24��6=   $��
350,10,0,0q�6I   $	��Top=�6]   $��24��6u   $��/images/Close.png��6�   �� 5   
   $��Usuario��6   $
��Left=�6"   $��
50,266,0,0q�6=   $	��Top=�6Q   $��20(�6i   $
��Bold"�6w   $��0,5,5,5q�6�   �� 5   
   $��Contraseña��6   $
��Left=�6%   $��
50,376,0,0q�6@   $	��Top=�6T   $��20(�6l   $
��Bold"�6z   $��0,5,5,5q�6�   5      5      