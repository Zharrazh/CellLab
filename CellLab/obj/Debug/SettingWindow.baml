   M S B A M L   `   `   `  ����B  >CellLab, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CellLabCellLab  5   	       CellLab.SettingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CellLab     5   	   -   5          � Title$  Settings��5   	   $	��350��6   $	��400��6'    J� IsManipulationEnabled .   � WindowStartupLocation$ CenterScreen=�6Q    � 
ResizeMode$ NoResize=�6v   .��5	      � .+�5
   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   $��10,30,10,10q�62   .+�5      �� $��Карта:��6   �� 5      -   5         ��Name$ ComboBox_Map��5   ?   $��10,0,0,0q�6    �� SelectedIndex$ 0��6-   .@�5      �� .��6   Карта 16%   5      5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $%��Колличество еды :��6   $	��121��64   �� 5      -   5         ��Name$ Slider_food��5       � Minimum$ 0Q�6.   	 � Maximum$		 100Q�6:   
 �� Orientation$
 
Horizontal=�6H   $	��180��6b   $��10,0,0,0q�6n    � Value$ 10Q�6�    �� TickFrequency$ 1Q�6�    �� IsSnapToTickEnabled . 6�   �� 5      -   5         ��Name$ TextBox_food��5      $��50��60   $��Center=�6p   $��Center=�6�   ��6;   ��  �� ElementName$ Slider_food�� �� Path$ Value�6�   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $)��#Питательность еды :��6   �� 5      -   5        $ Slider_foodNutrition��5      $ 0Q�67   $		 100Q�6C   $
 
Horizontal=�6Q   $	��180��6k   $��10,0,0,0q�6w   $ 10Q�6�   $ 1Q�6�    . 6�   �� 5      -   5        $ TextBox_foodNutrition��5      $��50��69   $��Center=�6�   $��Center=�6�   ��6D   �� $ Slider_foodNutrition��$ Value�6�   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $%��Колличество яда :��6   $	��121��64   �� 5      -   5        $ Slider_poison��5      $ 0Q�60   $		 100Q�6<   $
 
Horizontal=�6J   $	��180��6d   $��10,0,0,0q�6p   $ 10Q�6�   $ 1Q�6�    . 6�   �� 5      -   5        $ TextBox_poison��5      $��50��62   $��Center=�6t   $��Center=�6�   ��6=   �� $ Slider_poison��$ Value�6�   5      �� 5       $ 
Horizontal=�6   $��10q�62   .+�5!      �� $��Радиация :��6   $	��121��6-   �� 5"      -	   5        $ Slider_radiation��5"      $ 0Q�63   $		 100Q�6?   $
 
Horizontal=�6M   $	��180��6g   $��10,0,0,0q�6s   $ 2Q�6�   $ 1Q�6�    . 6�   �� 5#      -
   5        $ TextBox_radiation��5#      $��50��65   $��Center=�6z   $��Center=�6�   ��6@   �� $ Slider_radiation��$ Value�6�   5$      �� 5%      $ 
Horizontal=�6   $��Right=�62   .+�5&      �� -   5         ��Name$ OkBtn��5&   I   $��Ok��6   $��20q�6&   $��60��62   $��30��6=   6X   �� 5'      -   5        $ 	CanselBtn��5'   M   $��Отмена��6   $��20q�6*   $��60��66   $��30��6A   6`   5(      5*      5,      5-      