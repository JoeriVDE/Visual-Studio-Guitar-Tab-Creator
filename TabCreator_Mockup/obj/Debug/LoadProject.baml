   M S B A M L   `   `   `  ����L  HTabCreator_Mockup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:TabCreator_MockupTabCreator_Mockup  5   	   #    TabCreator_Mockup.LoadProject   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:TabCreator_Mockup     5   	     � Title$  Load a project��5   	    �� TextAlignment$ Center=�6    $	��500��6A   $	��600��6N    � 
ResizeMode$ CanMinimize=�6Z      
Black_Dark#��[  6s   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��0.1* �6   6.   �� 5      $��1* �6   6,   �� 5      $��1* �6   6,   �� 5      $
��0.1* �6   6.    � RowDefinitions 5   
   �� 5      $
��0.1* �6   6,   �� 5      $��0.75* �6   6-   �� 5      $��2* �6   6*   �� 5      $��0.75* �6   6-   �� 5      $��0.75* �6   6-   �� 5      $
��0.2* �6   6,   .+�5   
   �� -   5        $��	lbl_Title��5      $
��Wrap=�5      $��Center=�6!   $��Center=�6>   $��1��5      $��1��6   $��2��6*     
Main_Title#��[ 6>   {�.  Load a previous project5      ]� 5    
   -   5        $��Selection_StackPanel��5       $��1��60   $��2��6@   $��2��6T   ��. .+�5!      � $	��Top=�6    5"      �� 5#      $��1* �6'   64   �� 5$      $��2* �6'   64   �� 5%      $��1* �6'   64   .+�5(      �� $��Last Modified��6     Black_SemiDark#��[ 61   $��0��6^    �� Padding$	 0,5q�6n   6~   �� 5)      $��Project Name��6   #��[ 60   $��1��6]   $	 0,5q�6m   6}   �� 5*      $��Tuning��6   #��[ 6*   $��2��6W   $	 0,5q�6g   6w   5+      �� 5-      #��[ 6    �� SelectedIndex$ 0��6C   $��0q�6U   .@�5.      �� $��Stretch=�6   #��[ 6C     Black_ExtraDark#��[ 6p   
������ $��0q�6�   .��5/      �  50      �� 51      $��1* �6/   6<   �� 52      $��2* �6/   6<   �� 53      $��1* �6/   6<   .+�56      �� -   5        $��txt_LastModDate��56   $   $��
01/01/2016��6;   $��0��6M   $
��Left=�6]   6z   �� 57      -   5        $��txt_ProjectName��57   $   $/��)One hell of an awesome imaginary project!��6;   $��1��6l   $
��Left=�6|   6�   �� 58      -   5        $��
txt_Tuning��58   $   $��Standard: E-A-D-G-B-E��66   $��2��6S   $
��Left=�6c   6�   59      5:      5;      5<      �� 5>   
   $��1��6   $��2��6%   $��3��69   $��0,10,0,0q�6F   .+�5?      �� $��Open Existing project��6     Label_Marked#��[ 64   6\   �� 5@       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5A      �� $
��Path��6   #��[ 6'   6O   �� 5B      -   5        $��txt_FilePath��5B      $	��400��6.     Fill_Field_Textbox#��[ 6:   6h   �� 5C      -   5        $��btn_OpenExplorer��5C      $��Center=�61   $��5q�6S   .��5D      �� $��Resources/Folder_Logo.png��6   $��26��6?   $��26��6J   6X   5E      5F      5G      �� 5J   
   -   5        $��	btn_Canel��5J      $��Cancel��6"   $��1��63   $��4��6C   $��0,20,100,20q�6P   6e   �� 5K   
   -	   5        $��btn_LoadProject��5K      $��Load Project��6(   $��2��6?   $��4��6O   $
��0,20q�6\   6j   5L      5M      