   M S B A M L   `   `   `  ���� G  CPlechaty_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Plechaty_GUI.ViewsPlechaty_GUI.Views  "    Plechaty_GUI.Views.UserLogin   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:Plechaty_GUI.Views       � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$��1q� � Title$" Uživatelské přihlášení��$	��320��$	��200��.���  � RowDefinitions �� �� �� �� .+��� -   $��10��$��Center=�$��Right=�$��X�����#AAAAAA$��40��$��40��
������ $��0q�$
��Bold"�$��0 0 10 0q� � Cursor$
 Hand������  �� 
TargetType" �� �� BasedOn# [B�� �� Triggers P� 	 P� Property	 �@J�IsMouseOver
 P� Value
 . . ���  �� Property � �� �� Value �#ffffff��  � �� �#ff0033�� -   $��
loginLabel��$��Center=�$��Center=�$��0��$��Přihlášení��$��16(��� -   $��emailBorder��$��1��
������� �� CornerRadius$ 16��$	��160��$��40��._��� -   $��emailTextBox��
�������$��Email��$��16��$	��140��$��	10 0 10 0q�$��Center=�$��Center=�
������� �� 	MaxLength$ 24�� �� MaxLines$ 1���� -   $��passwordBorder��$��2��
�������$ 16��$	��160��$��40��._�G� -   $��passwordTextBox�� G� Password$ Heslo��
������� G� PasswordChar$ *��$��16��$	��140��$��	10 0 10 0q�$��Center=�$��Center=�
������� G� 	MaxLength$ 24���� -   $��loginButton��$��Přihlásit��$��3��$��80��$��40��$	��Top=��� -   $��createAccountLabel��$
 Hand��$��Nemám účet��$��Center=�$��Bottom=�$��4��$��0 0 0 12q�