   M S B A M L   `   `   `  ����H  DJbnu_Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Jbnu_CalendarJbnu_Calendar  5   	       Jbnu_Calendar.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Jbnu_Calendar     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  63     � Title$  
MainWindow��5   	   $	��600��6   $
��1000��6)    � WindowStartupLocation$ CenterScreen=�66    � 
ResizeMode$ NoResize=�6[    � WindowStyle$
 None=�6q   .��5
      � ���	#FFEEEEEE.+�5   
   �� $	��Top=�6   .+�5      � ���	#FFCD8FFF$��10��6*   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��JBNU Calendar��6    $��Center=�65   $��20(�6P   $��Champagne & Limousines)�6^   $
��20 0q�6�   $
��Bold"�6�   5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� -   5         ��Name$ ButtonFechar��5      $��30��63   $��30��6>   $��0q�6w   
������� J� RenderTransformOrigin$ 0.427,0.271&�6�   ��6J   Z� ��6`   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�62   5      5      5      5      � 5   
   $��
250 55 0 0q�6   .+�5       � -   5         �Name$ GridPrincipal��5       $��Center=�6*   $��Center=�6G   5!      � 5$   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5&      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5        	  Name$	 TrainsitionigContentSlide��5&   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase
   OpeningEffect
 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.2X�.��5'      � -   5        $ 
GridCursor��5'      $��	0 100 0 0q�6+   ���	#FFCD8FFF$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   5(      �� 5*      -   5         ��Name$ ListViewMenu��5*      $��0 100q�6-   
�������$��Champagne & Limousines)�6O   $��18(�6w    �� SelectedIndex$ 0��6�   .@�5+      �� $��60��6   .��5-      �� $ 
Horizontal=�6!   .+�5.        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5/      $��Notice��6$   $��17(�62   $��Center=�6@   $
��20 0q�6[   50      51      �� 52      $��60��6   .��53      �� $ 
Horizontal=�6!   .+�54        $ Calendar=�62   $��30��6B   $��30��6M   $��Center=�6Y   $��5q�6t   �� 55      $��Calendar��6$   $��17(�64   $��Center=�6B   $
��20 0q�6]   56      57      �� 58      $��60��6   .��59      �� $ 
Horizontal=�6!   .+�5:        $ FormatListBulleted=�62   $��30��6L   $��30��6W   $��Center=�6c   $��5q�6~   �� 5;      $��Calender List��6$   $��17(�69   $��Center=�6G   $
��20 0q�6b   5<      5=      �� 5>      $��60��6   .��5?      �� $ 
Horizontal=�6!   .+�5@        $ WbSunny=�62   $��30��6A   $��30��6L   $��Center=�6X   $��5q�6s   �� 5A      $��Weather��6$   $��17(�63   $��Center=�6A   $
��20 0q�6\   5B      5C      5D      5E      5F      5G      