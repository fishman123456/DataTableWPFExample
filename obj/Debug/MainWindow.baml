   M S B A M L   `   `   `  ����N  JDataTableWPFExample, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DataTableWPFExampleDataTableWPFExample  5   	   $    DataTableWPFExample.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:DataTableWPFExample     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   $��20(�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.5* �6   6,   �� 5      $
��1.5* �6   6,   �� 5      $
��0.5* �6   6,   �� 5      $
��0.5* �6   6,   �� 5      $��3* �6   6*   .+�5   
   �� $��0��6   $��0��6   $��Query:��6-   �� 5   
   -   5         ��Name$ queryTextBox��5      $��1��6(    �� TextWrapping$
 Wrap=�65   $��0��6I   �� 5   
   -   5         ��Name$ runBtn��5   <   $��2��6   $��0��6   $	��Run��6.   6L   �� 5   
   $��3��6   $��0��6   $��Result:��6-   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ resultDataGrid��5   0   $��4��6   $��0��6    60   5      5      