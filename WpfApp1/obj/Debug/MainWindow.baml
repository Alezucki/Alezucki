   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	        WpfApp1.FinestraPrincipale   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Le Chat��5   	   $	��450��6   $	��800��6&   .��5	      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   �� 5      $��* �6   .+�5   
   � -   5         �Name$ PannelloChats��5      $��0��6&    � RowDefinitions 5      �� 5      $��50 �6    �� 5      $��* �6    .+�5      �  � Orientation$ 
Horizontal=�6   $��0��61   .+�5      �� 
�������$��50��6,   $��50��68   $��0q�6C   .��5      �� -   5        $��Impostazioni��5      $=��7C:\Users\AleZu\Desktop\WpfApp1\WpfApp1\Impostazioni.jpg��60   $��10q�6q    J� RenderTransformOrigin$ 2.702,0.521&�6}   5      �� 5      $
��Chat��6   $��25(�6'   $��Futura)�65   $��0��6I   $��5,5,5,5q�6V   5      �� 5      -   5         ��Name$ 	BarraChat��5      $��Visible=�6.   $��Disabled=�6T   
�������$��1��6�   .��5      �� -   5        $��PannelloChat��5   4    �� Orientation$ Vertical=�6   .+�5       �� -   5         ��Name$ AggiungiChat��5       $��+ Aggiungi una Chat��63   $��15(�6Q   $��Futura)�6_   
���iii�$��40��6�   
�������$��0q�6�   6�   5!      5#      5%      � 5&   
   -   5        $ TestoMsg��5&      $��1��6!    5'      �� 5(      $	��350 �6    �� 5)      $��* �6    .+�5+      �� -   5        	 ��Name$	 
BordoInput��5+      
 �� CornerRadius$
 10��6)   $��1��6;   $	��500��6H   $��10q�6T   $��1q�6`   
�������$
��Left=�6�   ._�5,      �� -   5         ��Name$ InputTestuale��5,   5   $��Inserisci del testo��6    �� TextAlignment$
 Left=�6L    �� TextWrapping$
 Wrap=�6a   $��15(�6u   $��Ubuntu)�6�   $��Center=�6�   $��10q�6�   
�������$��0q�6�   6
  5-      5.      52      53      