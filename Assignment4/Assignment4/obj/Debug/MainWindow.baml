   M S B A M L   `   `   `  ����F  BAssignment4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Assignment4Assignment4  5   	       Assignment4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Assignment4     5   	     � Title$  
MainWindow��5   	   $��682.722��6   $��1187.916��6-   .��5	      � .+�5
   
   �� -   5         ��Name$ OpenCourseWorkBtn��5
      $!��Open Course Work
JSON File��6,   $
��Left=�6Z   $��	10,41,0,0q�6u   $	��Top=�6�   $	��129��6�   $��49��6�    � UseLayoutRounding . $��Center=�6�   $��Center=�6  �� 5   
   $��Course Work Filename��6   $
��Left=�6/   $��	10,10,0,0q�6J   $	��Top=�6]   �� 5   
   $��Course Name��6   $
��Left=�6&   $��	10,95,0,0q�6A   $	��Top=�6T   �� 5   
   $��Overall Grade��6   $
��Left=�6(   $��
10,123,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ OverallGradeTb��5      $��97,125,814,0q�6*    �� TextWrapping$
 Wrap=�6@    �� 
IsReadOnly .  �� IsReadOnlyCaretVisible . $	��Top=�6�   $��24��6�   �� 5   
   $��
Categories��6   $
��Left=�6%   $��
10,154,0,0q�6@   $	��Top=�6T   �� 5   
   $��Assignments��6   $
��Left=�6&   $��284,154,0,0q�6A   $	��Top=�6V   �� 5   
   $��Submissions��6   $
��Left=�6&   $��700,154,0,0q�6A   $	��Top=�6V   �� 5   
   -   5         ��Name$ CategoriesListView��5   s   $
��Left=�6   $	��296��6.   $��
10,180,0,0q�6;   $	��Top=�6O   $	��269��6g    �� View 5      �� 5      .P�5      �� $
��Name��6%   	 �� Width$	 134.5��6Y   
 �� DisplayMemberBinding
 63   �� *Name+6Y   �� 5      $��
Percentage��6%   $	 134.5��6e   
 69   �� *
Percentage+6e   5      5      �� 5   
   -   5        $ AssignmentsListView��5   t   $
��Left=�6   $	��296��6.   $��284,180,0,0q�6;   $	��Top=�6P   $	��411��6h    5      �� 5      .P�5      �� $
��Name��6%   $		 137��6Y   
 63   �� *Name+6Y   �� 5      $��Description��6%   $		 137��6g   
 6:   �� *Description+6g   �� 5      $��CategoryName��6%   $		 137��6i   
 6;   �� *CategoryName+6i   5       5"      �� 5#   
   -   5        $ CourseNameTb��5#      $��97,97,814,0q�6(   $
 Wrap=�6=    .  . $	��Top=�6�   $��24��6�   �� 5$   
   -   5        $ CourseWorkFilenameTb��5$      $��144,12,10,0q�60   $
 Wrap=�6E    .  . $	��Top=�6�   $��24��6�   �� 5%   
   -   5        $ SubmissionsListView��5%   N   $	��296��6   $��700,180,10,0q�6    $	��Top=�66    5&      �� 5'      .P�5(      �� $��CategoryName��6%   $		 156��6i   
 6;   �� *CategoryName+6i   �� 5)      $��AssignmentName��6%   $		 156��6m   
 6=   �� *AssignmentName+6m   �� 5*      $��Grade��6%   $		 156��6[   
 64   �� *Grade+6[   5+      5-      �� 5.   
   $��Target Assignment Name��6   $
��Left=�61   $��
10,536,0,0q�6L   $	��Top=�6`   �� 5/   
   -   5        $ TargetAssignmentTb��5/      $��158,538,0,0q�6.   $
 Wrap=�6C   $	��Top=�6W   $��24��6o   $
��Left=�6{   $	��208��6�   �� 50   
   -	   5        $ FindSubmissionBtn��50      $��Find Submission��6,   $
��Left=�6F   $��158,567,0,0q�6a   $	��Top=�6v   $	��208��6�   $��35��6�    . $��Center=�6�   $��Center=�6�   6  �� 51   
   $��Assignment Name��6   $
��Left=�6*   $��472,536,0,0q�6E   $	��Top=�6Z   �� 52   
   -
   5        $ AssignmentNameTb��52      $��584,538,10,0q�6,   $
 Wrap=�6B    .  . $	��Top=�6�   $��24��6�   �� 53   
   $��Category Name��6   $
��Left=�6(   $��472,565,0,0q�6C   $	��Top=�6X   �� 54   
   -   5        $ CategoryNameTb��54      $��584,567,10,0q�6*   $
 Wrap=�6@    .  . $	��Top=�6�   $��24��6�   �� 55   
   $��Grade��6   $
��Left=�6    $��472,594,0,0q�6;   $	��Top=�6P   �� 56   
   -   5        $ GradeTb��56      $��584,596,10,0q�6#   $
 Wrap=�69    .  . $	��Top=�6}   $��24��6�   58      59      