   M S B A M L   `   `   `  ����b  ^PresentationFramework.Aero2, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   SecundaryBackgroundColor  �� Color  PrimaryTextColor  PrimaryGrayColor  PrimaryBackgroundColor  SecundaryBlackColor  btnClose  
panelBlack  OptionMark.Static.Glyph   OptionMark.Static.Background 	 OptionMark.MouseOver.Glyph #
 OptionMark.MouseOver.Background " OptionMark.Disabled.Background  OptionMark.Disabled.Border  OptionMark.Disabled.Glyph ! OptionMark.Pressed.Background  OptionMark.Pressed.Glyph 	 close �� 	UriSource  maximize  minimize  restore  DefaultIcon  SecundaryIconColor  TextFourthColor  PrimaryBlueColor  iToggleButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers	 P� Property
 P� Value �� 
TargetName  
menuButton �� CornerRadius �� Triggers  	topButton  DataGridRowStyle1)   #System.Windows.Controls.DataGridRow �� Padding?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter    
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter    DetailsVisibility$   SelectiveScrollingOrientation&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader!   HeadersVisibilityConverter7  1System.Windows.Controls.DataGridHeadersVisibility
   Row ]� 
Conditions �� Property �� Value  ColumnHeaderGripperStyle  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3	   -Microsoft.Windows.Themes.DataGridHeaderBorder   CanUserSort  	  IsClickable! 	  	IsPressed" J� IsMouseOver# 	  	IsHovered$   SeparatorBrush% 	  SeparatorBrush&   SortDirection' 	  SortDirection(   SeparatorVisibility) 	  SeparatorVisibility* n�Name  DataGridCellStyle1*
  $System.Windows.Controls.DataGridCell  DataGridStyle15  /System.Windows.Controls.DataGridLengthConverter+ ��Name,   SelectAllCommand- �� 
ResourceId. �� TypeInTargetAssembly
/   AllG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter0  Name1   Column2 ��Name3 �� CanContentScroll4 ��Name5 �� ScrollableHeight6 � Maximum7 �� Orientation8 �� ViewportHeight9 �� ViewportSize*: �� #ComputedVerticalScrollBarVisibility; � Value< �� Mode= �� ScrollableWidth> �� ViewportWidth,? �� %ComputedHorizontalScrollBarVisibility   CheckBoxStyle1@ �NameA F�NameB J� OpacityC �� StretchD ��NameE ��Name ! gridEditButton " gridRemoveButtonF �� BasedOn # searchTextbox $ 	addButton % filterTextBox & gridButtonIcon�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      UthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  5      %�7  &	        &	 !     &	 B     &	 c     &	 �     &	 �     &	 �     &	 �     &	 
    &		 -    &	
 P    &	 s    &	 �    &	 �    &	 �    &	 �    &	 "    &	 O    &	     &	 �    &	 �    &	     &	 .    &	 O    &	 p    &	 )    &	 �    &	 �
    &	 �    &	 �    7  7  &	 @    &	 �    &	  t     7  7  7  7 
 7 	 7 	 7  7  7  7  7  7  7  &	! �)    &	" ,    7 ! &	# �,    &	$ .0    &	% 3    7 # &	& X5    �� 5      $  #EFF2F7��67   �� 5      $  #FFFFFF��6/   �� 5      $  #BFBFC4��6/   �� 5      $  #131725��65   �� 5	      $  #EFF2F7��62   �� 5
      $  #F72626��6'   �� 5      $  #343A40��6)   �� 5      $  	#FF212121��66   �� 5      $  	#FFFFFFFF��6;   �� 5      $  	#FF212121��69   �� 5      $  	#FFF3F9FF��6>   �� 5      $  	#FFE6E6E6��6=   �� 5      $  	#FFBCBCBC��69   �� 5      $  	#FF707070��68   �� 5      $  	#FFD9ECFF��6<   �� 5      $  	#FF212121��67   �� 5      $ ../images/close.png?�6    �� 5      $ ../images/maximize.png?�6#   �� 5      $ ../images/minimize.png?�6#   �� 5      $ ../images/restore.png?�6"   �� 5      $ ../images/default.png?�6&   �� 5      $  #FFFFFF��61   �� 5      $  #4B5D78��6.   �� 5       $  #3772FF��6/   �� 5"      " d�6'   .�5#   
   ��  � ��$ 36��6"   �� 5$   
    � ��$ 36��6#   �� 5%   
    � �� 5&      �� 5'      " d�6"   .R�5(      �� $ border��6   #��z��6-   #��z��6a    . ._�5)      �� $��..\images\Menu.png��6    5*       5+      P� 5,      	 �@J�IsMouseOver
 . . �5-      �� $ border��5.   "    � ��
 ���� 5/   "   �� 50      $ border��51   "    � �� �#FFFFFF52   "   53      P� 54      	 �@d�	IsChecked$

 trueY�67   . �55      �� $ border��56   %    � ��
 ���� 57   %   �� 58      $ border��59   %    � �� �#FFFFFF5:   %   5;      5=      5?      5@      �� 5B      " ��6   .�5C   
   ��  � ��
 ���� 6'   �� 5D   
    � �� �#D0C0FF6'   �� 5E   
    �@�FocusVisualStyle 6-   Z� �� 5F   
    � ��$ 35��6#   �� 5G   
    � ��$	 5 3q�6#   �� 5H   
    � ��$ 13(�6%   �� 5I   
    � �� 5J      �� 5K      " ��6"   .R�5L      �� #��z��6   $ 7��6G   ._�5M      �� $��Center=�6+   $
��Left=�6F   5N      5O      5Q       5R   
   P� 5S      	 �@J�IsMouseOver
 . . �5T      ��  � �� �#494E536/   �� 5U       � �� �#ffffff6/   5V      5X      �� 5[      " ��6   .�5\   
   ��  � ��
 ���� 6'   �� 5]   
    � �� �#6E77836'   �� 5^   
    �@�FocusVisualStyle 6-   Z� �� 5_   
    � ��$ 24��6#   �� 5`   
    � ��$ 24��6"   �� 5a   
    � ��$ Right=�60   �� 5b   
    � �� 5c      �� 5d      " ��6"   .R�5e      �� #��z��6   $ 50��6G   ._�5f      �� $��Center=�6+   $��Center=�6F   5g      5h      5j       5l   
   P� 5m      	 �@J�IsMouseOver
 . . �5n      ��  � �� �#dcdcdc6/   5o      5q      �� 5u      "   6&   .�5v   
   ��  � ��$ 0 4 0 0q�6#   �� 5w   
    � �� �#FFFFFF6'   �� 5x   
    �@J�SnapsToDevicePixels . 60   �� 5y   
    �@=�ErrorTemplate 65   Z� �� 5z   
    �@  ValidationErrorTemplate 5{      �� 5|      .R�5}      �� 
���  ��$��2,0,0,0q�61   $��!��6B   $��Center=�6K   5~      5�      �� 5�   
    � �� 5�      �� 5�      "   6"   .R�5�      �� $ 
DGR_Border��6   $	 0 8q�61   $ 5��6?   #��z��6P   $��0q�6z    . ._�5�         5�      �� 5�   "   $
��Auto �63   �� 5�   "   $��* �63    5�      �� 5�   "   $��* �60   �� 5�   "   $
��Auto �60   .+�5�        $��1��65   #��z 6E   # z 6o     5�      $��1��67   $��1��6G   #y�z 6k   6T   �� *AreRowDetailsFrozen+# Z # Z  �� "  6k    5�      $��2��60   $ Vertical=�6A   y�6�   �� *HeadersVisibility+# Z # Z  �� "  5�      5�      5�      5�       5�   
   P� 5�      	 �@J�IsMouseOver
 . . �5�      ��  � �� �	#ECECECEC6/   �� 5�       � �� �#0000006/   5�      P� 5�      	 �@  
IsSelected
 . . �5�      ��  � �� �#C4E2FF6/   �� 5�       � �� �#ffffff6/   5�      ]� 5�       5�      �� 5�       �@  
IsSelected . 66   �� 5�       �@��IsSelectionActive .  6F   ./�5�      ��  � �� �#dfdfdf6/   5�      5�      �� 5�      " n�6-   .�5�   
   ��  � ��$ 8��6"   �� 5�   
    � ��
 ���� 6'   �� 5�   
    �@�Cursor$ SizeWE��6#   �� 5�   
    � �� 5�      �� 5�      " n�6"   .R�5�      �� #��z��6   # z��6G   5�      5�      5�      �� 5�      "  6/   .�5�   
   ��  � ��$ Center=�65   �� 5�   
    � ��
 ���� 6'   �� 5�   
    � �� �#69717D6'   �� 5�   
    � ��$ 
15 0 15 10q�6#   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      � .+�5�      	  #��z��65   #��z��6_   #��z��6�   #  z 6�   #! z��6�   ## z" 6  # z��6=  #% z$ 6a  #' z& 6�  #) z( 6�  ._�5�      �� #��z��6/   ��. # z 6�   #��z��6�   5�      n� 5�      $* PART_LeftHeaderGripper��6    $
��Left=�6@   8��  6[   n� 5�      $* PART_RightHeaderGripper��6    $��Right=�6A   8�� 6]   5�      5�      5�      5�      �� 5�      " 
 6'   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � ��$ Center=�6.   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    � ��$
 15 0q�6#   �� 5�   
    � �� 5�      �� 5�      " 
 6"   .R�5�      �� #��z��6   $��0q�6G    . ._�5�      �� # z 6+   5�      5�      5�      5�      �� 5�      "  6#   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � �� �#2225286'   �� 5�   
    � ��$ 0q�6,   �� 5�   
     �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5�   
    � �� . 6:   �� 5�   
    �@��PanningMode$
 Both=�65   �� 5�   
    �@��IsFlicksEnabled .  63   �� 5�   
    �@ AutoGenerateColumns .  60   �� 5�   
    �@ HeadersVisibility$ Column=�6.   �� 5�   
    � ��$ 0 10 0 0q�6#   �� 5�   
    � ��$ 5��6%   �� 5�   
    �@ SelectionMode$ Single=�6*   �� 5�   
    �@ SelectionUnit$ FullRow=�6*   �� 5�   
    �@ CanUserAddRows .  6+   �� 5�   
    �@ CanUserDeleteRows .  6.   �� 5�   
    �@ CanUserReorderColumns .  62   �� 5�   
    �@ CanUserResizeRows .  6.   �� 5�   
    � ��$ 13(�6%   �� 5�   
    �@ GridLinesVisibility$
 None=�60   �� 5�   
    �@ ColumnWidth$ * 6(   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z��6   #��z��6G   #��z��6{   # z��6�    . ._�5�      �� $+ DG_ScrollViewer��6'   |�.  ��5�      �� 5�   "   " ��62   .R�5�   &   �  5�   *   �� 5�   .   $
��Auto �6?   �� 5�   .   $��* �6?   �� 5�   .   $
��Auto �6?    5�   *   �� 5�   .   $
��Auto �6<   �� 5   .   $��* �6<   �� 5  .   $
��Auto �6<   .+�5  *   �� #��Z, 61   |�.  ��6r   C� *�� $"- DataGridSelectAllButtonStyle��".  +y�6�   �� *HeadersVisibility+# Z # Z/  �� "  ��6�  �� *CellsPanelHorizontalOffset+ �� "    5  *   $!0 PART_ColumnHeadersPresenter��6I   $��1��6n   y�6~   �� *HeadersVisibility+# Z # Z1  �� "  �� 5  *   $!2 PART_ScrollContentPresenter��6A   $��2��6f   #3 z��6z   $��1��6�   �� 5  *   $4 PART_VerticalScrollBar��64   $��2��6T   #6 z5 6d   $7 Vertical=�6�   $��1��6�   #9 z8 6�   #y�z: 6D  ; 6�   �� *VerticalOffset+$< OneWay=� �� *TemplatedParent+6D  � 5  *   $��1��6/   $��2��6?    5  .   �� 5	  2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5
  2   $��* �6C   .+�5  .   �� $4 PART_HorizontalScrollBar��68   $��1��6Z   #6 z= 6j   $7 
Horizontal=�6�   #9 z> 6�   #y�z? 6?  ; 6�   �� *HorizontalOffset+$< OneWay=� �� *TemplatedParent+6?  5  +   5  '   5  #   .��5     �� # z 6-   5     5     5     5      5  
   ]� 5      5     �� 5      �@��
IsGrouping . 66   �� 5     " �@%�IsVirtualizingWhenGrouping .  6X   ./�5     ��  � �� .  6B   5     5      �� 5"     " ��6#   .�5#  
   ��  �@�FocusVisualStyle 6-   Z� �� 5$  
    � ��8   6'   �� 5%  
    � �� �#DAE2EA6(   �� 5&  
    � ��# � ��6'   �� 5'  
    � ��$ 1q�6,   �� 5(  
    � �� 5)     �� 5*     " ��6"   .R�5+     � $@ templateRoot��6   
������  .  5,     �� 5-     $
��Auto �6/   �� 5.     $��* �6/   .+�50     �� $ checkBoxBorder��6!   $ 3��69   $ 1q�6J   #��z��6V   #��z��6�   #��z��6�   #��z��6�   $��1q�6#  #��z��6.  ._�51     � $@ markGrid��6#   .+�52  "   F� $A 
optionMark��6'   Y�����4� �� Ѽ�G dԊ Ѩ�D dԊ �    ^>O ��z r�5 ��@ ��\ 
ܺ��� @�j�  �>��4� �� 8�� $��1q�6�   $B 0Q�6  $
C None=�6  �� 53  "   $D indeterminateMark��6,   8�� $��2q�6w   $B 0Q�6�   54     55     �� 56     $E contentPresenter��6+   $��1��6E   |�.  #��z��6g   #��z��6�   ��. # z 6�   #��z��6$  57      58     P� 59     	 � ��
 . . �5:     ��  6A   Z�  �@�FocusVisualStyle�� 5;      � ��$ 4,-1,0,0q�68   5<     P� 5=     	 �@J�IsMouseOver
 . . �5>     �� $ checkBoxBorder��6;   8   � ��6W   �� 5?     $ checkBoxBorder��6<    � �� �#9575CD6X   �� 5@     $ 
optionMark��65   8   � ��6M   �� 5A     $ indeterminateMark��65   8   � ��6T   5B     P� 5C     	 � {�
 .  . �5D     �� $ checkBoxBorder��6;   8   � ��6W   �� 5E     $ checkBoxBorder��6<   8   � ��6X   �� 5F     $ 
optionMark��65   8   � ��6M   �� 5G     $ indeterminateMark��65   8 	  � ��6T   5H     P� 5I     	 � ��
 . . �5J     �� $ checkBoxBorder��6;   8 
  � ��6W   �� 5K     $ checkBoxBorder��6<    � �� �#9575CD6X   �� 5L     $ 
optionMark��65   8   � ��6M   �� 5M     $ indeterminateMark��65   8   � ��6T   5N     P� 5O     	 �@d�	IsChecked$

 trueY�67   . �5P     �� $ 
optionMark��68    �@J�Opacity$ 1Q�6P   �� 5Q     $ indeterminateMark��68    �@J�Opacity$ 0Q�6W   5R     P� 5S     
 67   Z� 	 �@d�	IsChecked. �5T     �� $ 
optionMark��68    �@J�Opacity$ 0Q�6P   �� 5U     $ indeterminateMark��68    �@J�Opacity$ 1Q�6W   5V     5X     5Z     5[     �� 5]     " ��6#   .�5^  
   ��  � �� �#512DA86'   �� 5_  
    � �� �#4A148C6(   �� 5`  
    � �� �#ffffff6'   �� 5a  
    �@�FocusVisualStyle 6-   Z� �� 5b  
    � ��$ Center=�6.   �� 5c  
    � �� 5d     �� 5e     " ��6"   .R�5f     �� #��z��6   #��z��6G   $ 5q�6s   $��1q�6   $ 5��6�   ._�5g     �� $��Center=�6+   $��Center=�6F   5h     5i     5k      5l  
   P� 5m     	 �@J�IsMouseOver
 . . �5n     ��  � �� �#673AB76/   5o     5q     �� 5s     " ��6%   8F   .�5t  
   ��  � ��
 ���� 6'   �� 5u  
    � ��
 ���� 6(    5v  
   P� 5w     	 �@J�IsMouseOver
 . . �5x     ��  � ��
 ���� 6/   5y     5{     �� 5~     " ��6"   .�5  
   ��  � �� �#ffffff6'   �� 5�  
    � �� �#B0B9C66'   �� 5�  
    � ��$ 0q�6,   �� 5�  
    � ��$ 12(�6%   �� 5�  
    � ��$ 15 10q�6$   �� 5�  
    � ��$ Center=�6.   �� 5�  
    � ��$
 0 10q�6#   �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� $ border��6   $ 20��6-   #��z��6?    . $��1q�6�   ���#E0E6ED._�5�     �� $+ PART_ContentHost��6'   |�.  $��Hidden=�6S   $��Hidden=�6z   5�      5�     P� 5�     	 �@J�IsMouseOver
 . . �5�     �� $ border��6<    � �� �#d9d9d96P   5�     P� 5�     	 �@J�IsKeyboardFocused
 . . �5�     �� $ border��6<    � �� �#d9d9d96P   5�     5�     5�     5�     �� 5�     " ��6   .�5�  
   ��  � �� �#6741D96'   �� 5�  
    � �� �#ffffff6'   �� 5�  
    �@�FocusVisualStyle 6-   Z� �� 5�  
    � ��$ 35��6#   �� 5�  
    � ��$	 150��6"   �� 5�  
    � ��$ 0 20 0 0q�6#   �� 5�  
    � ��$ 13(�6%   �� 5�  
    � ��$ Right=�60   �� 5�  
    � ��$ 1��6%   �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� #��z��6   $ 7��6G   ._�5�     �� $��Center=�6+   $��Center=�6F   5�     5�     5�      5�  
   P� 5�     	 �@J�IsMouseOver
 . . �5�     ��  � �� �#7B5CD66/   �� 5�      � �� �#ffffff6/   5�     5�     �� 5�     " ��6"   8F   .�5�  
   ��  � ��$
 10 7q�6$   �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� $ border��6   $ 7��6-   #��z��6>   $��1q�6h   ���#E0E6ED . ._�5�     �� $+ PART_ContentHost��6'   |�.  $��Hidden=�6S   $��Hidden=�6z   5�      5�     P� 5�     	 �@J�IsMouseOver
 . . �5�     �� $ border��6<    � �� �#d9d9d96P   5�     P� 5�     	 �@J�IsKeyboardFocused
 . . �5�     �� $ border��6<    � �� �#d9d9d96P   5�     5�     5�     5�     �� 5�     " ��6#   .�5�  
   ��  � ��$ Center=�6.   �� 5�  
    � ��$ 12��6"   �� 5�  
    � ��$ 12��6#   5�     5�     