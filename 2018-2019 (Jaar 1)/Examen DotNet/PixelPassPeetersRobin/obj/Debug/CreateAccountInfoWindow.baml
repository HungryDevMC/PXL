   M S B A M L   `   `   `  ����D  @PixelPass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PixelPass	PixelPass  5   	   '    !PixelPass.CreateAccountInfoWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PixelPass     5   	     � Title$   ��5   	   $��291.176��6   $��440.425��6#   
����ح�.��5
      � .+�5   
   �� $
��Left=�6   $��	25,24,0,0q�6/   $��Title:��6B   $	��Top=�6P   �� 5   
   $
��Left=�6   $��	25,58,0,0q�6/   $��	Username:��6B   $	��Top=�6S   �� 5   
   $
��Left=�6   $��	25,94,0,0q�6/   $��	Password:��6B   $	��Top=�6S   �� 5   
   $
��Left=�6   $��
25,129,0,0q�6/   $��Notes:��6C   $	��Top=�6Q   �� 5   
   $
��Left=�6   $��
25,164,0,0q�6/   $��Expiration date:��6C   $	��Top=�6[   �� 5   
   -   5        $��titleTextBox��5      $
��Left=�5      $��23��6-   $��
132,17,0,0q�69   $�� ��6M   $	��Top=�6U   $	��150��5      6   �� 5   
   -   5        $��usernameTextBox��5      $
��Left=�5      $��23��6-   $��
132,51,0,0q�69   $�� ��6M   $	��Top=�6U   $	��150��5      6   �� 5   
   -   5        $��passwordTextBox��5      $
��Left=�5      $��23��6-   $��
132,87,0,0q�69   $�� ��6M   $	��Top=�6U   $	��150��5      65   �� 5   
   -   5        $��notesTextBox��5      $
��Left=�5      $��23��6-   $��132,122,0,0q�69   $�� ��6N   $	��Top=�6V   $	��150��5      6   �� 5   
   -   5        $��expirationSlider��5      $
��Left=�5      $��132,162,0,0q�6,   $	��Top=�6A   $	��150��5       � Minimum$ 1Q�6    � Maximum$ 31Q�6)    � SmallChange$ 1Q�66    �� TickPlacement$ BottomRight=�6F   5   )   �� 5   
   -   5        $��expirationDateTextBlock��5      $
��Left=�5      $��300,164,0,0q�6/   $��(dd/mm/jjjj)��6D   $	��Top=�5      5      �� 5   
   -   5         ��Name$ passwordStrengthTextBlock��5       $
��Left=�5      $��
300,94,0,0q�6/   $��(weak/average/strong)��6C   $	��Top=�5      5       �� 5!   
   -   5        $��createButton��5#      $��Create��5!      $
��Left=�6"   $��300,220,0,0q�6=   $	��Top=�5"      $��75��6)   5#   %   5%      5&      