   M S B A M L   `   `   `  ����L  HTabCreator_Mockup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TabCreator_MockupTabCreator_Mockup  5   	   #    TabCreator_Mockup.StartWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TabCreator_Mockup     5   	     � Title$  Welcome to tabcreator��5   	    �� TextAlignment$ Center=�6'   $	��500��6H   $	��600��6U    � 
ResizeMode$ CanMinimize=�6a      
Black_Dark#��[  6z   .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $
��2.5* �6   6,   �� 5      $��0.75* �6   6-   �� 5      $��2* �6   6*   �� 5      $��0.75* �6   6-   �� 5      $��2* �6   6*   �� 5      $��0.75* �6   6-   �� 5      $��2* �6   6*   �� 5      $��1* �6   6*    � ColumnDefinitions 5   
   �� 5      $��0.75* �6   6/   �� 5      $��0.75* �6   6/   �� 5      $
��2.5* �6   6.   �� 5      $��0.75* �6   6/   �� 5      $��0.75* �6   6/   .+�5    
   �� -   5        $��img_GuitarLogo��5       $��Resources/Guitar_Logo.png��6&   $��0��5!      $��0��6    $��2��6-   $��2��6A   $��Center=�5"      $��Center=�6-   $
��0,15q�6H   5#      �� 5&   
   -   5        $��	lbl_Title��5&      $
��Wrap=�5'      $
��Left=�6!   $��Center=�6<   $��2��5(      $��0��6   $��2��6*   $��2��6;     
Main_Title#��[ 5)      {�.  #!Super awesome guitar tab creator!5+      �� 5-   
   -   5        $��btn_CreateProject��5-      $��3��6*   $��2��67   $��Create Project��6G   $��20,0,0,0q�6`   6�   �� 5.   
   -   5        $��btn_OpenProject��5.      $��5��6(   $��2��65   $��Open Project��6E   $��20,0,0,0q�6]   6�   �� 5/   
   -   5        $��btn_CloseApp��5/      $��7��6%   $��2��62   $��	Close App��6B   $��20,0,0,0q�6q   6�   50      51      