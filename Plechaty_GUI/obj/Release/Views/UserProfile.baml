   M S B A M L   `   `   `  ����   Plechaty_GUI$    Plechaty_GUI.Views.UserProfile   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � WindowStartupLocation$  CenterScreen=� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=�$��1q� � Title$ UserProfile��$	��450��$	��800��.���  � RowDefinitions �� �� �� �� ��  � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� �� �� .+��� -   $��10��$��Center=�$��Right=�$��X�����#AAAAAA$��40��$��40��
������ $��0q�$
��Bold"�$��0 0 10 0q� � Cursor$
 Hand������  �� 
TargetType" �� �� BasedOn# [B��	 �� Triggers	 P� 
 P� Property
 �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �#ffffff��  � �� �#ff0033�� $��1��$��24��$��24�� �� CornerRadius$ 12��$
��Left=� J� OpacityMask !�  !� Visual �� $��24��$��24��$ 12��
�������._��� $��../Icons/profile.png��$��24��$��24���� -   $��	nameLabel��$��Karel Novotný��$��2��$��2��$
��Left=�$��Center=��� -   $��balanceLabel��$��0 kč��$��4��$
��Left=�$��Center=��� -   $��logoutButton��
�������$��2��$	��100��$��40��$��8��$��Odhlásit se���� -   $��
contentBox��$��1��$��0��$��4��$��12��$��0q����� .R�� $��productListGrid�� �� $��60 ��� $��60 ��� $��60 ��� $��80 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 � �� $��30 ��� $��30 ��� $	��172 �.+��� $	��180��$	��180��$��3��$
��Left=�$	��Top=�$��1��$��3�� !�  �� $ 16��$	��200��$	��200��
�������._��� ���� *	Image_url+�� $��24��$��24��$��Bottom=�$
��Left=�$ 16��$��3��$��1��$��1 0 0 53q����� *
Lipstick+ K� ZIndex �� *ZIndex+._��� 
�������$��Center=�$��Center=����� *Count+�� $��14(�$
��Bold"�$��0��$��4��$��8��$	��Top=�$
��Left=����� *Name+���� *
Lipstick+�� $��1��$��4��$��8��$	��Top=�$
��Left=�y��� *
Visibility+.���� ���� *PriceString+�� $��1��$��4��$��8��$	��Top=�$
��Left=�y��� *VisibilityNegated+.���� $��Strikethrough{����� *PriceString+�� $��1��$��4��$��8��$��40 0 0 0q�
���  ��$	��Top=�$
��Left=����� *SpecialString+�� $��4 0 0 0q�$��14(�$	��500��$	��140��$��2��$��4��$��8��$
��Wrap=�$	��Top=�$
��Left=����� *DescriptionShort+���� *	TextLight+