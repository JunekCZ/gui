   M S B A M L   `   `   `  ���� G  CPlechaty_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Plechaty_GUI.ViewsPlechaty_GUI.Views  +clr-namespace:Plechaty_GUIPlechaty_GUI  !    Plechaty_GUI.Views.CartView   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     2local clr-namespace:Plechaty_GUI.Views     2plechatyGuiclr-namespace:Plechaty_GUI       � WindowStyle$
  None=� � WindowStartupLocation$ CenterScreen=�$��1q� � 
ResizeMode$ NoResize=� � Title$ Nákupní košík��$	��450��$	��800��.���  � RowDefinitions �� $��80 ��� �� $��80 �.+�� -   $��TopGrid��$��12�� � ColumnDefinitions �� �� �� �� �� �� �� �� �� �� �� �� .+��� $��1��$��2��$��Nákupní košík��$��Center=�$
��Left=�$��16(��� -   $��10��$��Center=�$��Right=�$��X�����#AAAAAA$��40��$��40��
������ $��0q�$
��Bold"� � Cursor$
 Hand������  �� 
TargetType" �� �� BasedOn# [B��	 �� Triggers	 P� 
 P� Property
 �@J�IsMouseOver P� Value . . ���  �� Property � �� �� Value �#ffffff��  � �� �#ff0033�� -   $��9��$��Center=�$��Right=�$��_�����#AAAAAA$��40��$��40��
������ $��0q�$��	ExtraBold"�$��16(�$
 Hand������ " ��# [B��	 P� 
 �@J�IsMouseOver . . ���  � �� �#8a817c��  � �� �#ffffff�� -   $��
contentBox��$��1��$��12��$��0q����� .R�� $��productListGrid�� �� $��60 ��� $��60 ��� $��60 ��� $��80 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 ��� $��60 � �� $��30 ��� $��30 ��� $	��172 �.+��� $	��180��$	��180��$��3��$
��Left=�$	��Top=�$��1��$��3�� J� OpacityMask !�  !� Visual ��  �� CornerRadius$ 16��$	��200��$	��200��
�������._��� ���� *	Image_url+�� $��24��$��24��$��Bottom=�$
��Left=�$ 16��$��3��$��1��$��1 0 0 53q����� *
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
��Left=����� *DescriptionShort+���� *	TextLight+�� -   $��	Odstranit��$��2��$��4��$��2��$��80��$��40��$��Bottom=�$
��Left=�$��0 0 0 32q�
�������
 � Tag �� *Id_p+���� *
Lipstick+�� -   $��Odstranit vše��$��2��$��6��$��2��$	��100��$��40��$��Bottom=�$
��Left=�$��0 0 0 32q�
������� �� *Id_p+���� *Skin+� $��2�� �� �� �� �� �� �� �� �� �� �� �� �� .+��� -   $��	buyButton��$ No��$��Nakoupit��$��1��$��2��$
��Left=�$	��100��$��40���� -   $��clearButton��$��Vyprázdnit košík��$��3��$��2��$
��Left=�$	��120��$��40���� -	   $��
totalLabel��$��Celkem: ? kč��$��9��$��2��$��Right=�$��Center=�