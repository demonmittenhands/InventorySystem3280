   M S B A M L   `   `   `  ����K  GRecreationOutlet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:RecreationOutletRecreationOutlet  5   	       RecreationOutlet.Search   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:RecreationOutlet     5   	     � Title$  Search��5   	   $��440.977��6   $��512.03��6)   .��5	      � .+�5
   
   �� .+�5      ��  �� Left$ 34��6   
 �� Top$ 26��6%   .��65   Select an Invoice #6J   �� 5      -   5         ��Name$ cbo_InvoiceNum��5      $ 38��6/   $ 57��6@   $��99��6P   6]   (  "System.Windows.Controls.DatePicker  5      $	 320��6   $ 28��6+   6=   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_SearchResults��5   /      AutoGenerateColumns .  $��10,98,10,10q�6I      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Invoice Id��6H      Width5  /System.Windows.Controls.DataGridLengthConverter$ 75 6\   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 
 �� Path$
 	InvoiceId�6\     5      $
 Date��6C   $	 125 6Q   	 6%   �� $

 Date�6Q     5      $ Customer��6L   $	 125 6^   	 6%   �� $
 Customer.Name�6^     5      $ 
Total Cost��6H   	 6%   �� $
 	TotalCost�6H   5      5      5      