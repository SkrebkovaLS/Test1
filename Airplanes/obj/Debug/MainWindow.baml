   M S B A M L   `   `   `  ����D  @Airplanes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Airplanes	Airplanes  5   	       Airplanes.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Airplanes     5   	     � Title$  Login��5   	   $	��450��6   $	��800��6$    � 
ResizeMode$ NoResize=�60    � WindowStartupLocation$ CenterScreen=�6F   .��5	      �  J� RenderTransformOrigin$ 
0.41,0.502&�6    � ColumnDefinitions 5
   
   �� 5      $	��27* �6   �� 5      $	��31* �6   �� 5      $
��742* �6   .+�5   
   �� $��2��6   $
��Left=�6    $	��101��6;   $��
153,38,0,0q�6H   $	��Top=�6\   $	��505��6t   $0��*/Resources/Images/DS2017_TP09_color@2x.png��6�   �� 5   
   $��2��6   $��Username��6    $
��Left=�63   $��	106,0,0,0q�6N   $��Center=�6a   $��TeX Gyre Adventor)�6|   $
��Bold"�6�   ��5      �� 5      5      �� 5   
   $��2��6   $��Password��6    $
��Left=�63   $��106,270,0,0q�6N   $	��Top=�6c   $��TeX Gyre Adventor)�6{   $
��Bold"�6�   �� 5   
   $��2��6   $
��Left=�6"   $��0��6=   $��	241,0,0,0q�6H    �� TextWrapping$
 Wrap=�6[   $��TextBox��6o   $��Center=�6~   $	��229��6�   $ 0.5,0.5&�6�   .��6�   z�5      V� 5      .~�5      ��  �� ScaleX$ -1Q�6%   �� 5      �� 5      T� 5      5      .��5   '   5      �� 5    
   -   5         ��Name$ Username��5       $��2��6$   $
��Left=�64   $��24��6O   $��	209,0,0,0q�6[   $
 Wrap=�6n   $��Center=�6�   $	��337��6�   4  .System.Windows.Automation.AutomationProperties   Name$ Username��6�   �� 5!   
   -   5        	 ��Name$	 	btn_login��5!      $��2��6$   $��Login��64   $
��Left=�6D   $��217,340,0,0q�6_   $	��Top=�6t   $��26��6�   $	��125��6�   $��TeX Gyre Adventor)�6�   $ 	btn_login��6�   $
��Bold"�6�   6�   �� 5"   
   -   5        $	 btn_exit��5"      $��2��6#   $
��Exit��63   $
��Left=�6B   $��396,340,0,0q�6]   $	��Top=�6r   $��26��6�   $	��125��6�   $��TeX Gyre Adventor)�6�   $ btn_exit��6�   $
��Bold"�6�   6�   �� 5#   
   -   5        
 ��Name$
 errors��5#      $��2��6$   $
��Left=�64   $��139,384,0,0q�6O   $
��Wrap=�6d   $	��Top=�6x   $	��319��6�   $��17��6�   $ errors��6�   ���	#FFF411116�   G� 5$   
   -   5         G�Name$ Password��5$      $��2��6(   $
��Left=�68   $��24��6S   $��209,270,0,0q�6_   $	��Top=�6t   $	��337��6�   5%      5&      