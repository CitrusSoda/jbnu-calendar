   M S B A M L   `   `   `  ����H  DJbnu_Calendar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Jbnu_CalendarJbnu_Calendar  5          Jbnu_Calendar.Calendar   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Jbnu_Calendar     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  68   $
��auto��5      $
��auto��6   .��5	      � .+�5
   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5
   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      ��  �� Orientation$ 
Horizontal=�6   $��Bottom=�62   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ calendar��5      $
��Left=�6-   $	��Top=�6H   $	��360��6`   $	��280��6m   6y   �� 5      .+�5      �� $��10q�6!   .+�5      �� -   5         ��Name$
 year��5   $   $��2000년��62   $��50(�6?   $��Champagne & Limousines)�6M   ���	#FFCD8FFF6u   �� 5      -   5        $ month��5   $   $
��1월��63   $��25(�6=   $��Champagne & Limousines)�6K   $
��Bold"�6s   $��5q�6�   �� 5      -   5        $	 day��5   $   $
��1일��61   $��20(�6;   $��Champagne & Limousines)�6I   $��5q�6q   5      �� 5      $��계획��6   $��Center=�6)   $
��Bold"�6F   $��24(�6X   �� 5      -   5         ��Name$
 plan��5      $��70��6,   $	��200��68    �� TextWrapping$
 Wrap=�6D    �� AcceptsReturn . $��16(�6m   �� 5      -   5        $��Champagne & Limousines)�5      $��일정 추가��6E   $��18(�6U   $��50q�6c   6o   5      5      5      5      5      