   M S B A M L   `   `   `  ����J  FImageServiceGui, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:ImageServiceGuiImageServiceGui  5      '    !ImageServiceGui.View.SettingsView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:ImageServiceGui     5      ��5   7   �� *BackG+.��5	      � -   5        $��SettingsGrid��5	   &   $
��Left=�6   .+�5
   
   �� -   5        $��	MainStack��5
   ,     �� Orientation$  Vertical=�6   .+�5      �� $  
Horizontal=�6   .+�5      �� -   5         ��Name$	 lbl��5      $��Settings��6%   $��1��68   $	��Top=�6H   $��2��6`   $��22(�5      
����+��$
��Bold"�66   $��Italic$�6H   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $
 lbl1��5      $��OutputDirectory��6&   $	��140��6@   $
��Bold"�6L   $��16(�6^   �� 5      -   5        $ 	lblOutput��5      $��1��6L   $��16(�6\   ��6+   �� *outPutFolder+6\   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $ 	lbl1_Copy��5      $��Source Name��6+   $	��140��6A   $��1��6M   $��2��6]   $
��Bold"�6q   $��16(�6�   �� 5      -   5        $ lblSourceName��5      $��1��6O   $��16(�6_   ��6/   �� *
sourceName+6_   5      �� 5      $  
Horizontal=�6   .+�5      �� -   5        $
 lbl2��5      $��Log Name��6&   $	��140��69   $��1��6E   $��2��6U   $
��Bold"�6i   $��16(�6{   �� 5      -	   5        $ 
lblLogName��5      $��16(�6I   ��6,   �� *	logName+6I   5      �� 5      $  
Horizontal=�6   $��39��62   .+�5      �� -
   5        $
 lbl4��5      $��Thumbnail Size��6&   $	��140��6?   $��1��6K   $��2��6[   $
��Bold"�6o   $��16(�6�   �� 5      -   5        $ lblThumbSize��5      $��1��6P   $��16(�6`   ��6.   �� *ThumbnailSize+6`   5       �� 5!      -   5         ��Name$	 btn��5!   H   $��0,30,0,0q�66   $��Remove��6U   $��38��6f   $	��600��6r   $
��15px(�6~   y�6   �� *	HideOrVis+��5"      �� *RemoveCommand+��5#      �� 5$      .��5%      �  � Color$ Yellow��6'    � Offset$ 0Q�66   � 5&      $	 Red��6'   $ 1Q�63   5'      5)      �� 5*      $	��215��6<   y�6   �� *	HideOrVis+.��5+      �� -   5         ��Name$ listHandlers��5+   (   $��15(�6   $
��Left=�6>   $	��Top=�6Y   $	��578��5,      ��6"   �� *ListOfHandlers+ �� SelectedItem 6I   �� *SelectedItem+ �� Mode$ TwoWay=�5-      5.      5/      50      51      