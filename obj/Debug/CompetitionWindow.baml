   M S B A M L   `   `   `  ����B  >CSE3055, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CSE3055CSE3055  5   	       CSE3055.CompetitionWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CSE3055     5   	     � Title$  CompetitionWindow��5   	   $	��450��6#   $	��800��60   .��5	      � -   5        $
��grd1��5	      ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FF3A2828��6   $ 1Q�61   5       � ColumnDefinitions 5   
   �� 5      $	��217 �6   �� 5      $
��475* �6   .+�5   
   �� $	��Top=�6   $��0��6-   .+�5      �� -   5         ��Name$ txtAra��5      $
��Left=�6&   $��23��6A    �� TextWrapping$
 Wrap=�5      $�� ��6   $	��Top=�6'   $	��202��6?   $��5,5,0,0q�6m   �� 5      -   5         ��Name$ listCompetitions��5      $	��380��6e   $��5,5,10,0q�6r   ��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ White��6'   $ 0Q�65   � 5      $ 	#FF4E989B��6'   $ 1Q�69   5      ��5       �� 5!      .R�5"      �� 	 �� Orientation$	 
Horizontal=�6%   .+�5#      �� ��6(   �� *CompetitionID+�� 5$      $��10,0,0,0q�6I   ��6(   �� *CompetitionName+6I   5%      5&      5(      5)      �� 5+   
   $��1��6   $
��Left=�6$   $��91.2,38,0,0q�6?   $
��Wrap=�6T   $��Competition ID��6h   $	��Top=�6~   �� 5,   
   $��1��6   $
��Left=�6$   $��71.2,67,0,0q�6?   $
��Wrap=�6T   $��Competition Name��6h   $	��Top=�6�   
 J� RenderTransformOrigin$
 
5.066,-6.5&�6�   �� 5-   
   $��1��6   $
��Left=�6$   $��146.2,94,0,0q�6?   $
��Wrap=�6U   $��Prize��6i   $	��Top=�6v   �� 5.   
   $��1��6   $
��Left=�6$   $��50.2,120,0,0q�6?   $
��Wrap=�6U   $��Number of Participants��6i   $	��Top=�6�   �� 5/   
   $��1��6   $
��Left=�6$   $��93.2,150,0,0q�6?   $
��Wrap=�6U   $��Last Champion��6i   $	��Top=�6~   �� 51   
   -   5        $��txtCompetitionID��51      $��1��6*   $
��Left=�6:   $��23��6U   $��181.2,31,0,0q�6a   $
 Wrap=�52      $	��Top=�6E   $	��186��6]   ��6&   �� *CompetitionID+6]   �� 53   
   -   5        $��txtCompetitionName��53      $��1��6,   $
��Left=�6<   $��23��6W   $��181.2,60,0,0q�6c   $
 Wrap=�54      $	��Top=�6G   $	��186��6_   ��6&   �� *CompetitionName+6_   �� 55   
   -   5        $��txtPrize��55      $��1��6"   $
��Left=�62   $��23��6M   $��181.2,87,0,0q�6Y   $
 Wrap=�56      $	��Top=�6=   $	��186��6U   ��6&   �� *Prize+6U   �� 57   
   -   5        $��txtNumOfParticipants��57      $��1��6.   $
��Left=�6>   $��23��6Y   $��181.2,115,0,0q�6e   $
 Wrap=�58      $	��Top=�6L   $	��186��6d   ��6&   �� *NumberOfParticipants+6d   �� 59   
   -   5        $ txtLastChampion��59      $��1��6+   $
��Left=�6;   $��23��6V   $��181.2,143,0,0q�6b   $
 Wrap=�5:      $	��Top=�6C   $	��186��6[   ��6%   �� *LastChampion+6[   �� 5=   
   -	   5        $��INSERT��5=      $��1��6"   $
��Left=�62   $��260.2,193,0,0q�6M   $	��Top=�6d   $��75��6|   6�   �� 5>   
   -
   5        $��DELETE��5>      $��1��6"   $
��Left=�62   $��180.2,218,0,0q�6M   $	��Top=�6d   $��75��6|   6�   �� 5?   
   -   5        $��UPDATE��5?      $��1��6"   $
��Left=�62   $��260.2,218,0,0q�6M   $	��Top=�6d   $��75��6|   6�   �� 5@   
   -   5        $
��LIST��5@      $��1��6    $
��Left=�60   $��181.2,193,0,0q�6K   $	��Top=�6b   $��75��6z   6�   �� 5A   
   -   5        $��GO BACK��5A      $��1��6#   $
��Left=�63   $��464.2,329,0,0q�6N   $	��Top=�6e   $��75��6}   
���   �
�������
�������6�   5C      5D      