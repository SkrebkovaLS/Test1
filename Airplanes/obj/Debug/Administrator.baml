   M S B A M L   `   `   `  ����D  @Airplanes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Airplanes	Airplanes  5   	       Airplanes.Administrator   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Airplanes     5   	     � Title$  Administrator��5   	   $	��450��6   $	��800��6,    � 
ResizeMode$ NoResize=�68    � WindowStartupLocation$ CenterScreen=�6N   .��5	      � .+�5
   
   �� -   5         ��Name$ btn_add_user��5
      $��Add user��6'   $
��Left=�6:   $��8,10,0,0q�6U   $	��Top=�6g    J� RenderTransformOrigin$ -10.49,-3.635&�6   6�   �� 5   
   -   5        $ btn_exit��5      $
��Exit��6#   $
��Left=�62   $��	72,10,0,0q�6M   $	��Top=�6`   $ -10.49,-3.635&�6x   $��53��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dg_admin_user��5      $��10,96,10,95q�6U      AutoGenerateColumns .     
IsReadOnly . ��5      �� 5       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   	 �� Triggers	 5      �� 5      
 �� Binding
 6&   �� *Active+ �� Value	 false6A   .a�5      ��  �� Property � �� �� Value
 �  ��6I   5      �� 5      
 6&   �� *	User Role+ Administrator6D   .a�5      ��  � ��
 ����6P   5      5       � BindingGroup 5      &   System.Windows.Data.BindingGroup  5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6<      
Visibility$ Hidden=�6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6H     5      $
 Name��6>    6%   �� *Name+6>     5       $ 	Last name��6C    6%   �� *	Last Name+6C     5!      $	 Age��6=    6%   �� *Age+6=     5"      $ 	User Role��6C    6%   �� *	User Role+6C     5#      $ Email Address��6G    6%   �� *Email address+6G     5$      $ Office��6@    6%   �� *Office+6@     5%      $ Active��6@   $ Hidden=�6P    6%   �� *Active+6P   5'      �� 5(   
   $��Office��6   $
��Left=�6!   $��	19,57,0,0q�6<   $	��Top=�6O   $ -0.381,0.847&�6g   $��TeX Gyre Adventor)�6�   �� 5)   
   -   5         ��Name$ office��5)      $
��Left=�6#   $��	65,61,0,0q�6>   $	��Top=�6Q   $	��120��6i    �� DisplayMemberPath$ Title��6u    �� SelectedValuePath$ Title��6�   6�   �� 5*   
   -   5        $ reset��5*      $��Reset��6    $
��Left=�60   $��
200,61,0,0q�6K   $	��Top=�6_   6w   �� 5+   
   -   5        $ enable_disable��5+      $��Enable/Disable Login��6)   $
��Left=�6H   $��153,378,0,0q�6c   $	��Top=�6x   $	��138��6�   6�   �� 5,   
   -   5        $ remove��5,      $��Remove��6!   $
��Left=�62   $��23��6M   $��374,388,0,0q�6Y   $	��Top=�6n   $��89��6�   6�   �� 5-   
   -   5        $ Change_role��5-      $��Change role��6&   $
��Left=�6<   $��26��6W   $��505,370,0,0q�6c   $	��Top=�6x   $	��181��6�   6�   5/      50      