   M S B A M L   `   `   `  ����   Plechaty_GUI    Plechaty_GUI.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  
MainWindow��$	��720��$
��1360�� � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�$��Tahoma)� � Icon$ Icons/basket-white.png��.���  � RowDefinitions �� $��80 ��� .+�� -   $��TopGrid��$��12�� � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� �� �� .+��� -   $��1��$��52��$��52��$��Center=�$
��Left=� J� OpacityMask !�  !� Visual �� 	 �� CornerRadius$	 16��$��52��$��52��
�������$��Center=�$��Center=�._��� $��24��$��24��$��Center=�$��Center=�$��Icons/profile.png���� -   $��1��$��52��$��52��$��Center=�$��Right=�
������� !�  �� $	 16��$��52��$��52��
�������$��Center=�$��Center=�._��� $��24��$��24��$��Center=�$��Center=�$��Icons/basket.png���� -   $��productsCountBorder��$��1��$��20��$��20��$��Center=�$��Right=�
���  ��$��0 0 4 20q�
 K� ZIndex$
 -1�� !�  �� $	 8��$��20��$��20��
���  ��$��Center=�$��Center=�._��� $��0��
�������$��Center=�$��Center=�$��8(��� $��3��$��6��$��52�� !�  �� $	 5��$	��480��$��52��
�������._��� -   $��
SearchRect��
������ �� -   $��	SearchBox��$��3��$��5��
������ $��16(����#AAAAAA$��Center=�$��20��$	��480�� �� TextWrapping$
 Wrap=�$��	Hledat...��$��0q� �� 	MaxLength$ 40�� �� MaxLines$ 1��$��Center=��� $
��🔍��$��3��$
��Left=�$��12 0 0 0q�$��Center=��� -   $��10��$��Center=�$��Right=�$��X�����#AAAAAA$��40��$��40��
������ $��0q�$
��Bold"� � Cursor$
 Hand������  �� 
TargetType" �� �� BasedOn# [B�� �� Triggers P�  P� Property �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �#ffffff��  � �� �#ff0033�� -   $��10��$��Center=�$��Center=�$��_�����#AAAAAA$��40��$��40��
������ $��0q�$��	ExtraBold"�$��16(�$
 Hand������ " ��# [B�� P�  �@J�IsMouseOver . . ���  � �� �#8a817c��  � �� �#ffffff� $��1�� �� �� �� �� �� �� �� �� �� �� �� ��  �� �� �� �� �� �� .+�� -	   $��categoryGrid��$��1��$��2��$��6�� �� $	��109 ��� .+�� -
   $��SpecialGrid��$��0��.+��� $	��200��$��40��$��Center=�$
��Left=�$	 16��
��������� $��16 0 0 0q�
�������$��Center=�$
��Left=�$��Nové��$��16(��� $��Icons/ribbon-white.png��$��20��$��20��$��Center=�$��Right=�$��0 0 40 0q� � -   $��categoryFrame��$��1��� -   $��
FilterGrid��$��0��$��12�� �� �� �� �� �� �� �� �� �� �� �� �� .+�� $��3��.+�� -   .+��� -   $��Filter1Border��$	��100��$��40��$��Center=�$
��left=�$	 16��$��2q����#E0E0E0._��� -   $��Filter1Rect���� -   $��Filter1Label��$��Třídit��$��Center=�$
��Left=�$��48 0 0 0q�   FilterLabel#��[  �� $��16��$��16��$��Icons/adjustments.png��$��Center=�$
��Left=�$��20 0 0 0q�� $��4��$��2��.+�� -   
 � Tag$ 1��.+��� -   $��Filter2Border��$	��200��$��40��$��Center=�$��Center=�$	 16��$��2q����#E0E0E0._��� -   $��Filter2Rect���� -   $��Filter2Label��$��Pánské��#��[  � $��6��$��2��.+�� -   $ 2��.+��� -   $��Filter3Border��$	��200��$��40��$��Center=�$��Center=�$	 16��$��2q����#E0E0E0._��� -   $��Filter3Rect���� -   $��Filter3Label��$��Dámské��#��[  � $��8��$��2��.+�� -   $ 0��.+��� -   $��Filter4Border��$	��200��$��40��$��Center=�$��Center=�$	 16��$��2q����#E0E0E0._��� -   $��Filter4Rect���� -   $��Filter4Label��$��Unisex��#��[  � $��10��.+��� -   $��Circle��$	 20��$��40��$��40��$��Center=�$��Right=�$��2q�._��� $��Icons/refresh.png��$��20��$��20�� � -   $��productFrame��$��1��$��3��$��8��$��4�� � UseLayoutRounding .    � NavigationUIVisibility$ Hidden=�