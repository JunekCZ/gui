   M S B A M L   `   `   `  ����G  CPlechaty_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Plechaty_GUI.ViewsPlechaty_GUI.Views  5   	   !    Plechaty_GUI.Views.Register   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Plechaty_GUI.Views     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � Title$ Register��5   	   $	��450��6   $	��600��6'   .��5	      � -   5        $��contentGrid��5	       � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5        $��1��5      $��0 0 20 0q�5      $��Center=�5      $��Right=�5      $��X��5      ���#AAAAAA$��40��5      $��40��5      
������ $��0q�5      $
��Bold"�5!       � Cursor$
 Hand��5"      ��5$      �� 5%       �� 
TargetType" ��6    �� BasedOn# [B��6,    �� Triggers 5&      P� 5'      	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �5(      ��  �� Property � �� �� Value �#ffffff6;   �� 5)       � �� �#ff00336;   5*      5,      5.      �� 5/   
   $��
Registrace��6   $��20(�6%   $��2��63   $��Center=�6G   $��Center=�6b   �� 50   
   -   5        $��firstnameBorder��50      $��1��6(   
������� �� CornerRadius$ 16��6I   $	��200��6[   $��40��6g   $��Right=�6s   $��0 0 20 0q�6�   ._�51      �� -   5        $��firstnameTextBox��51      
 � Tag$ Jméno��6.   
�������$��Jméno��6�   $��16��6�   $	��140��6�   $��	10 0 10 0q�6�   $��Center=�6�   $��Center=�6�   
������� �� 	MaxLength$ 24��6   �� MaxLines$ 1��6  52      �� 53   
   -   5        $��lastnameBorder��53      $��1��6'   $��1��64   
�������$ 16��6X   $	��200��6j   $��40��6v   $
��Left=�6�   $��20 0 0 0q�6�   ._�54      �� -   5        $��lastnameTextBox��54      $ Příjmení��6-   
�������$��Příjmení��6�   $��16��6�   $	��140��6�   $��	10 0 10 0q�6�   $��Center=�6�   $��Center=�6�   
�������$ 24��6  $ 1��6$  55      �� 57   
   -   5        $��emailBorder��57      $��2��6$   
�������$ 16��6E   $	��200��6W   $��40��6c   $��Right=�6o   $��0 0 20 0q�6�   ._�58      �� -   5        $��emailTextBox��58      $ Email��6*   
�������$��Email��6�   $��16��6�   $	��140��6�   $��	10 0 10 0q�6�   $��Center=�6�   $��Center=�6�   
�������$ 24��6  $ 1��6  59      �� 5:   
   -	   5        $��passwordBorder��5:      $��2��6'   $��1��64   
�������$ 16��6X   $	��200��6j   $��40��6v   $
��Left=�6�   $��20 0 0 0q�6�   ._�5;      G� -
   5        $��passwordBox��5;      $ Heslo��6-   
������� G� Password$ Heslo��6�    G� PasswordChar$ *��6�   $��16��6�   $	��140��6�   $��	10 0 10 0q�6�   $��Center=�6�   $��Center=�6�   
������� G� 	MaxLength$ 24��6,  5<      �� 5=   
   -   5        $��registerButton��5=      $��Registrovat��6'   $��3��6=   $��2��6J   $��92��6^   $��40��6i   
�������6�   5>      5?      