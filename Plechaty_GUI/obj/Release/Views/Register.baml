   M S B A M L   `   `   `  ���� G  CPlechaty_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Plechaty_GUI.ViewsPlechaty_GUI.Views  !    Plechaty_GUI.Views.Register   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:Plechaty_GUI.Views       � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � Title$ Register��$	��450��$	��600��.��� -   $��contentGrid�� � RowDefinitions �� �� �� ��  � ColumnDefinitions �� �� .+��� -   $��1��$��0 0 20 0q�$��Center=�$��Right=�$��X�����#AAAAAA$��40��$��40��
������ $��0q�$
��Bold"� � Cursor$
 Hand������  �� 
TargetType" �� �� BasedOn# [B�� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  �� Property � �� �� Value �#ffffff��  � �� �#ff0033�� $��
Registrace��$��20(�$��2��$��Center=�$��Center=��� -   $��firstnameBorder��$��1��
������� �� CornerRadius$ 16��$	��200��$��40��$��Right=�$��0 0 20 0q�._��� -   $��firstnameTextBox��
 � Tag$ Jméno��
�������$��Jméno��$��16��$	��140��$��	10 0 10 0q�$��Center=�$��Center=�
������� �� 	MaxLength$ 24�� �� MaxLines$ 1���� -   $��lastnameBorder��$��1��$��1��
�������$ 16��$	��200��$��40��$
��Left=�$��20 0 0 0q�._��� -   $��lastnameTextBox��$ Příjmení��
�������$��Příjmení��$��16��$	��140��$��	10 0 10 0q�$��Center=�$��Center=�
�������$ 24��$ 1���� -   $��emailBorder��$��2��
�������$ 16��$	��200��$��40��$��Right=�$��0 0 20 0q�._��� -   $��emailTextBox��$ Email��
�������$��Email��$��16��$	��140��$��	10 0 10 0q�$��Center=�$��Center=�
�������$ 24��$ 1���� -	   $��passwordBorder��$��2��$��1��
�������$ 16��$	��200��$��40��$
��Left=�$��20 0 0 0q�._�G� -
   $��passwordBox��$ Heslo��
������� G� Password$ Heslo�� G� PasswordChar$ *��$��16��$	��140��$��	10 0 10 0q�$��Center=�$��Center=�
������� G� 	MaxLength$ 24���� -   $��registerButton��$��Registrovat��$��3��$��2��$��92��$��40��
�������