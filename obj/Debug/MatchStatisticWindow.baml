   M S B A M L   `   `   `  ����B  >CSE3055, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CSE3055CSE3055  5   	   "    CSE3055.MatchStatisticWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CSE3055     5   	     � Title$  MatchStatisticWindow��5   	   $	��450��6&   $	��800��63   .��5	      � -   5        $
��grd1��5	      ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FF3A2828��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $	��217 �6   �� 5      $
��475* �6   .+�5   
   �� $	��Top=�6   $��0��6-   .+�5      �� -   5         ��Name$ txtAra��5      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�5      $�� ��6   $	��Top=�6'   $	��202��6?   $��5,5,0,0q�6m   �� 5      -   5         ��Name$ listMatchStats��5      $	��380��6a   $��5,5,10,0q�6n   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ White��6'   $ 0Q�65   � 5      $ 	#FF4E989B��6'   $ 1Q�69   5      ��5       �� 5!      .R�5"      �� 	 �� Orientation$	 
Horizontal=�6%   .+�5#      �� ��6(   �� *HomeTeamName+�� 5$      $	�� - ��6(   �� 5%      ��6(   �� *AwayTeamName+5&      5'      5)      5*      �� 5,   
   $��1��6   $
��Left=�6$   $��91.2,38,0,0q�6?   $
��Wrap=�6T   $��Match ID��6h   $	��Top=�6x   �� 5-   
   $��1��6   $
��Left=�6$   $��71.2,67,0,0q�6?   $
��Wrap=�6T   $��Match Stat ID��6h   $	��Top=�6}   
 J� RenderTransformOrigin$
 
5.066,-6.5&�6�   �� 5.   
   $��1��6   $
��Left=�6$   $��227.2,127,0,0q�6?   $
��Wrap=�6V   $��Points��6j   $	��Top=�6x   �� 50   
   -   5        $��
txtMatchID��50      $��1��6$   $
��Left=�64   $��23��6O   $��181.2,31,0,0q�6[   $
 Wrap=�51      $	��Top=�6?   $��60��6W   ��6&   �� *	MatchID+6W   �� 52   
   -   5        $��txtMatchStatID��52      $��1��6(   $
��Left=�68   $��23��6S   $��181.2,60,0,0q�6_   $
 Wrap=�53      $	��Top=�6H   $��60��6`   ��6&   �� *MatchStatisticID+6`   �� 54   
   -   5        $��txtHomeTeamName��54      $��1��6)   $
��Left=�69   $��23��6T   $��71.2,92,0,0q�6`   $
 Wrap=�55      $	��Top=�6D   $	��170��6\   ��6&   �� *HomeTeamName+6\   �� 56   
   -   5        $��txtAwayTeamName��56      $��1��6)   $
��Left=�69   $��23��6T   $��246.2,92,0,0q�6`   $
 Wrap=�57      $	��Top=�6D   $	��170��6\   ��6&   �� *AwayTeamName+6\   �� 58   
   -   5        $ 
txtHPoints��58      $��1��6&   $
��Left=�66   $��23��6Q   $��136.2,120,0,0q�6]   $
 Wrap=�59      $	��Top=�6E   $��70��6]   ��6%   �� *HomeTeamPoints+6]   �� 5:   
   -	   5        $ 
txtAPoints��5:      $��1��6&   $
��Left=�66   $��23��6Q   $��281.2,120,0,0q�6]   $
 Wrap=�5;      $	��Top=�6A   $��70��6Y   ��6!   �� *AwayTeamPoints+6Y   �� 5<   
   -
   5        $ txtHRebounds��5<      $��1��6(   $
��Left=�68   $��23��6S   $��136.2,148,0,0q�6_   $
 Wrap=�5=      $	��Top=�6C   $��70��6[   ��6!   �� *HomeTeamRebounds+6[   �� 5>   
   -   5        $ txtHAssists��5>      $��1��6'   $
��Left=�67   $��23��6R   $��136.2,176,0,0q�6^   $
 Wrap=�5?      $	��Top=�6B   $��70��6Z   ��6!   �� *HomeTeamAssists+6Z   �� 5@   
   -   5        $ txtHTurnovers��5@      $��1��6)   $
��Left=�69   $��23��6T   $��136.2,204,0,0q�6`   $
 Wrap=�5A      $	��Top=�6D   $��70��6\   ��6!   �� *HomeTeamTurnovers+6\   �� 5B   
   -   5        $ txtHFG��5B      $��1��6"   $
��Left=�62   $��23��6M   $��136.2,232,0,0q�6Y   $
 Wrap=�5C      $	��Top=�6=   $��70��6U   ��6!   �� *
HomeTeamFG+6U   �� 5D   
   -   5        $ txtH3P��5D      $��1��6"   $
��Left=�62   $��23��6M   $��136.2,260,0,0q�6Y   $
 Wrap=�5E      $	��Top=�6=   $��70��6U   ��6!   �� *
HomeTeam3P+6U   �� 5F   
   -   5        $ txtH2P��5F      $��1��6"   $
��Left=�62   $��23��6M   $��136.2,288,0,0q�6Y   $
 Wrap=�5G      $	��Top=�6=   $��70��6U   ��6!   �� *
HomeTeam2P+6U   �� 5H   
   -   5        $ txtHFP��5H      $��1��6"   $
��Left=�62   $��23��6M   $��136.2,316,0,0q�6Y   $
 Wrap=�5I      $	��Top=�6=   $��70��6U   ��6!   �� *
HomeTeamFP+6U   �� 5K   
   -   5        $ txtARebounds��5K      $��1��6(   $
��Left=�68   $��23��6S   $��281.2,148,0,0q�6_   $
 Wrap=�5L      $	��Top=�6C   $��70��6[   ��6!   �� *AwayTeamRebounds+6[   �� 5M   
   -   5        $ txtAAssists��5M      $��1��6'   $
��Left=�67   $��23��6R   $��281.2,176,0,0q�6^   $
 Wrap=�5N      $	��Top=�6B   $��70��6Z   ��6!   �� *AwayTeamAssists+6Z   �� 5O   
   -   5        $ txtATurnovers��5O      $��1��6)   $
��Left=�69   $��23��6T   $��281.2,204,0,0q�6`   $
 Wrap=�5P      $	��Top=�6D   $��70��6\   ��6!   �� *AwayTeamTurnovers+6\   �� 5Q   
   -   5        $ txtAFG��5Q      $��1��6"   $
��Left=�62   $��23��6M   $��281.2,232,0,0q�6Y   $
 Wrap=�5R      $	��Top=�6=   $��70��6U   ��6!   �� *
AwayTeamFG+6U   �� 5S   
   -   5        $ txtA3P��5S      $��1��6"   $
��Left=�62   $��23��6M   $��281.2,260,0,0q�6Y   $
 Wrap=�5T      $	��Top=�6=   $��70��6U   ��6!   �� *
AwayTeam3P+6U   �� 5U   
   -   5        $ txtA2P��5U      $��1��6"   $
��Left=�62   $��23��6M   $��281.2,288,0,0q�6Y   $
 Wrap=�5V      $	��Top=�6=   $��70��6U   ��6!   �� *
AwayTeam2P+6U   �� 5W   
   -   5        $ txtAFP��5W      $��1��6"   $
��Left=�62   $��23��6M   $��281.2,316,0,0q�6Y   $
 Wrap=�5X      $	��Top=�6=   $��70��6U   ��6!   �� *
AwayTeamFP+6U   �� 5Z   
   -   5        $��INSERT��5Z      $��1��6"   $
��Left=�62   $��246.2,355,0,0q�6M   $	��Top=�6d   $��75��6|   6�   �� 5[   
   -   5        $��DELETE��5[      $��1��6"   $
��Left=�62   $��166.2,379,0,0q�6M   $	��Top=�6d   $��75��6|   6�   �� 5\   
   -   5        $��UPDATE��5\      $��1��6"   $
��Left=�62   $��246.2,379,0,0q�6M   $	��Top=�6d   $��75��6|   6�   �� 5]   
   -   5        $
��LIST��5]      $��1��6    $
��Left=�60   $��166.2,355,0,0q�6K   $	��Top=�6b   $��75��6z   6�   �� 5^   
   -   5        $��GO BACK��5^      $��1��6#   $
��Left=�63   $��460.2,379,0,0q�6N   $	��Top=�6e   $��75��6}   
���   �
�������
�������6�   �� 5_   
   $��1��6   $
��Left=�6$   $��218,155,0,0q�6?   $
��Wrap=�6T   $��Rebounds��6h   $	��Top=�6x   �� 5`   
   $��1��6   $
��Left=�6$   $��224.2,183,0,0q�6?   $
��Wrap=�6V   $��Assists��6j   $	��Top=�6y   �� 5a   
   $��1��6   $
��Left=�6$   $��218.2,211,0,0q�6?   $
��Wrap=�6V   $��	Turnovers��6j   $	��Top=�6{   �� 5b   
   $��1��6   $
��Left=�6$   $��239.2,239,0,0q�6?   $
��Wrap=�6V   $��FG��6j   $	��Top=�6t   �� 5c   
   $��1��6   $
��Left=�6$   $��239.2,267,0,0q�6?   $
��Wrap=�6V   $��3P��6j   $	��Top=�6t   $
 0.541,1.827&�6�   �� 5d   
   $��1��6   $
��Left=�6$   $��239.2,295,0,0q�6?   $
��Wrap=�6V   $��2P��6j   $	��Top=�6t   $
 0.541,1.827&�6�   �� 5e   
   $��1��6   $
��Left=�6$   $��239.2,323,0,0q�6?   $
��Wrap=�6V   $��FP��6j   $	��Top=�6t   $
 0.541,1.827&�6�   5g      5h      