   M S B A M L   `   `   `  ����C  ?VlasProg, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VlasProgVlasProg  5   	       VlasProg.AuthWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:VlasProg     5   	     � Title$  Авторизация��5   	   $	��500��6   $	��500��6*    � WindowStartupLocation$ CenterScreen=�66    � WindowStyle$ 
ToolWindow=�6[   .��5	      � .+�5
   
   �� $\��VC:\Users\Practice.OP9_WinDC.005\source\repos\PraktikaBDApp\VlasProg\Res\Background.jpg��6   $
��Fill=�5      �� 5   
   $��Stretch=�6   $��Stretch=�5      $	��450��5      $	��450��5      ��5      Z� .+�5      �� $��Авторизация��6   $��30(�5      $�� 30 25 30 -10q�5      $��Center=�5      
�������5      �� 5      $��Введите логин��6   $��20(�5      $��
UltraLight"�5      $�� 30 50 30 0q�5      $
��Left=�5      
�������5      �� 5      -   5         ��Name$ TbLogin��5      $��24��5       $��	30 0 30 0q�5!      
���������5"      Z� ��5#      Z� .��5$   )   5%      �� 5'      $!��Введите пароль��6   $��20(�5(      $��
UltraLight"�5)      $�� 30 25 30 0q�5*      $
��Left=�5+      
�������5,      G� 5.      -   5         G�Name$ 
PbPassword��5.      $��24��5/      $��	30 0 30 0q�50      
���������51      Z� ��52      Z� 53      �� 55      $��0q�6   
���   �$��30q�6=   ._�56      �� .+�57      �� -   5         ��Name$ 
TB_Captcha��5<      $��48��57        �� TextAlignment$ Center=�58      $��36(�59      $��Strikethrough{�5:      $��Comic Sans MS)�5;      
���������5=      Z� 5>      �� 5?      -   5        $ TBX_Captcha��5A      $��24��5?      $��
Капча��5@      
���������5B      Z� ��5C      Z� 5D      5E      5F      �� 5H      -   5         ��Name$ BtnLogin��5H      $��
Войти��5I      $��
30 20 30 0q�5J      $��30��5K      
���������5M      Z� ��5N      Z� 5O      5P      5Q      5S      