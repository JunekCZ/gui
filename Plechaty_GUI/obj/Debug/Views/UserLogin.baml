   M S B A M L   `   `   `  ����G  CPlechaty_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Plechaty_GUI.ViewsPlechaty_GUI.Views  5   	   "    Plechaty_GUI.Views.UserLogin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Plechaty_GUI.Views     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�6?    � 
ResizeMode$ NoResize=�6R   $��1q�6h    � Title$" Uživatelské přihlášení��5   	   $	��320��6(   $	��200��65   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5        $��10��5      $��Center=�5      $��Right=�5      $��X��5      ���#AAAAAA$��40��5      $��40��5      
������ $��0q�5      $
��Bold"�5      $��0 0 10 0q�5       � Cursor$
 Hand��5      ��5!      �� 5"       �� 
TargetType" ��6    �� BasedOn# [B��6,    �� Triggers 5#      P� 5$      	 P� Property	 �@J�IsMouseOver
 P� Value
 . . �5%      ��  �� Property � �� �� Value �#ffffff6;   �� 5&       � �� �#ff00336;   5'      5)      5+      �� 5,   
   -   5        $��
loginLabel��5,      $��Center=�6"   $��Center=�6?   $��0��6Z   $��Přihlášení��6g   $��16(�6|   �� 5-   
   -   5        $��emailBorder��5-      $��1��6$   
������� �� CornerRadius$ 16��6E   $	��160��6W   $��40��6c   ._�5.      �� -   5        $��emailTextBox��5.      
�������$��Email��6�   $��16��6�   $	��140��6�   $��	10 0 10 0q�6�   $��Center=�6�   $��Center=�6�   
������� �� 	MaxLength$ 24��6   �� MaxLines$ 1��6  5/      �� 50   
   -   5        $��passwordBorder��50      $��2��6'   
�������$ 16��6H   $	��160��6Z   $��40��6f   ._�51      G� -   5        $��passwordTextBox��51       G� Password$ Heslo��61   
������� G� PasswordChar$ *��6�   $��16��6�   $	��140��6�   $��	10 0 10 0q�6�   $��Center=�6�   $��Center=�6�   
������� G� 	MaxLength$ 24��6,  52      �� 53   
   -   5        $��loginButton��53      $��Přihlásit��6�   $��3��6�   $��80��6�   $��40��6�   $	��Top=�6�   �� 54   
   -   5        $��createAccountLabel��54      $
 Hand��6�   $��Nemám účet��6�   $��Center=�6�   $��Bottom=�6�   $��4��6  $��0 0 0 12q�6  55      56      