   M S B A M L   `   `   `  ����A  =WPFApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPFApp.WindowsWPFApp.Windows  5   	       WPFApp.Windows.Manage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:WPFApp.Windows     5   	     � Title$  Manage��5   	   $	��450��6   $	��800��6%    � 	Resources 5	         ProductCollection �� Source �� Path��%E   &	        �� 5
   
    5      �� $ ProductList�5      5      .��5      �  � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��0��6$   $��Search:��61   $��10q�6@   �� 5   
   -   5         ��Name$ 	txtFilter��5   _   $��1��6   $��0��6"   $��10q�6/   6_   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ dgMovies��5!      $��1��5       $��2��6       AutoGenerateColumns .  	   SelectionMode$	 Single=�5#      
   SelectionUnit$
 FullRow=�5$         GridLinesVisibility$ 
Horizontal=�5%         CanUserDeleteRows .     CanUserAddRows .     CanUserResizeRows .  ��5    4   ��  �� Source# [     Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 61      
IsReadOnly .    MinWidth$ 60Q�6W   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6e   �� *Id+  5-      $
 Name��6%   $ SizeToCells 63    . $ 40Q�6Y    6g   �� *Name+  5.      $ 
CategoryID��6%   $ SizeToCells 69    . $ 80Q�6_    6m   �� *
CategoryId+  5/      $ Entry Price��6%   $ SizeToCells 6:    . $	 120Q�6`    6o   �� *
EntryPrice+  50      $ Selling Price��6%   $ SizeToCells 6<    . $	 120Q�6b    6q   �� *SellingPrice+  51      $ Locked��6%   $ SizeToCells 65    . $ 80Q�6[    6i   �� *
IsLocked+   	CellStyle 53      �� 54       �� 
TargetType*  $System.Windows.Controls.DataGridCell"  6    �� Triggers 55      P� 56       P� Property �@ 
IsSelected P� Value . . �57      ��  �� Property � �� �� Value$ 0q�6@   58      5:      5<      5=      5>      