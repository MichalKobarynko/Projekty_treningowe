   M S B A M L   `   `   `  ����E  AZadaniaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:ZadaniaWPF
ZadaniaWPF  5   	   ?$clr-namespace:ZadaniaWPF.ModelWidokuZadaniaWPF.ModelWidoku  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	          ZadaniaWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:ZadaniaWPF     5   	   3mw$clr-namespace:ZadaniaWPF.ModelWidoku     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      .s&clr-namespace:System;assembly=mscorlib  5	        � Title$  
ZadaniaWPF��5   	   $	��500��6   $	��500��6)    � DataContext 5      $   ZadaniaWPF.ModelWidoku.Zadania  5       � 	Resources 5         stylPrzycisku �� 
TargetType �� Property �� Value  boolToVisibility)   #ZadaniaWPF.PriorytetZadaniaToString  priorytetToString(   "ZadaniaWPF.PriorytetZadaniaToBrush  priorytetToBrush%   ZadaniaWPF.BoolToBrushConverter  czyZrealizowaneToBrush  czyPoTerminieToBrush   KolorDlaFałszu   KolorDlaPrawdy.   (ZadaniaWPF.BoolToTextDecorationConverter # czyZrealizowaneToTextDecoration!   ZadaniaWPF.ZadanieConverter  twórzZadanie:  4System.Windows.Controls.Primitives.DatePickerTextBox �� Path	 �� StringFormat
 �� ConverterCulture �� RelativeSource �� AncestorType(  "System.Windows.Controls.DatePicker��%�  &	        &	 �     &	     &	 %    &	 8    &	 K    &	 t    &	 �    '  �    �� 5      " ��6    .�5      ��  � ��$ 10(�6    �� 5       � ��$ 5q�6   �� 5       � ��$ 85��6   �� 5       � ��$ 20��6   �� 5       � ��$ Right=�6+   �� 5       � ��$	 Top=�6)   5      �� 5      6!     5      6#     5      6"     5      6     5      
 � � �
 �  ��6S     5      6(     5      6   �� 5      "  6
   .�5       ��  � �� 5!      �� 5"      .R�5#      �� ��6   �� $ SelectedDate�$	 {0:dd MMMM yyyy}��$
 pl-PL�� �� "  5%      5'      5(      5)      .	  (System.Windows.Interactivity.Interaction 	  Triggers 5*      /
  )System.Windows.Interactivity.EventTrigger
  5+       
  	EventName$ Closed��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5,      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6   �� *Zapisz+5-      .��5/      � $��0,-2,-0.4,2q�6   .+�50   
   �� $��	10,10,0,0q�6   $
��Left=�6'   $	��Top=�6B   $��Liczba zadań: ��6Z   �� 51      �6   �� $ ListaZadań.Count� �� Mode$ OneWay=�52      �� 53   
   -   5         ��Name$ lbListaZadań��53      $��10,35,10,200q�6(   ��6>   �� $ ListaZadań���54      �� 55      .R�56      ��  �� Orientation$ Vertical=�6!   $��3q�68   .+�57      �� $ 
Horizontal=�6%   .+�58      �� $��20(�6P   ��6(   �� $
 Opis�$ OneWay=���6^   �� *CzyZrealizowane+ �� 	Converter# [ ��6�   �� $ CzyZrealizowane�$ OneWay=�# [ �� 59      $��Zrealizowane��6%   #��[  6l   ��6<   �� $ OznaczJakoZrealizowane�y�6�   ��  �� *Self+$ 	IsEnabled�$ OneWay=�# [ �� 5:   	   $��Niezrealizowane��6   #��[  6]   ��6*   �� $ OznaczJakoNiezrealizowane�y�6�   ��  �� *Self+$ 	IsEnabled�$ OneWay=�# [ 5;   	   �� 5<      Priorytet: �� 5=      �6   �� $ 	Priorytet�$ OneWay=�# [ ��6s   �� $ 	Priorytet�$ OneWay=�# [ 
, Termin: �� 5>   &   �6*   �� $ PlanowanyTerminRealizacji�$ OneWay=�$	 {0:dd MMMM yyyy}��$
 pl-PL����6�   �� $< 6CzyZadaniePozostajeNiezrealizowanePoPlanowanymTerminie�$ OneWay=�# [ , Utworzone: �� 5?      �6   �� $ DataUtworzenia�$ OneWay=�$	 {0:dd MMMM yyyy}��$
 pl-PL��5@   	   5A      5B      ��5D      �� 5E      " ��6   .�5F      ��  � ��$ 3q�67   �� 5G       � ��
 �   �6<   �� 5H       � ��$ 1q�6@    �� Triggers 5I      P� 5J       P� Property �@J�IsMouseOver P� Value . . �5K      ��  � ��
 �����6C   5L      5N      5P      ,   &ZadaniaWPF.ConditionalMessageDialogBox  5Q      -   5          Name$ questionYesNo��5R         ZadaniaWPF.DialogBox   Caption$ 
ZadaniaWPF��5S      !   ZadaniaWPF.MessageDialogBox   Icon$ Question=�6      Buttons$ YesNo=�6)      DialogBypassButton$	 Yes=�5U         IsDialogBypassed 5T      ��  �� ElementName$ lbListaZadań��$# SelectedValue.CzyZrealizowane�   
CommandYes 5V      �� $ UsuńZadanie�!   ZadaniaWPF.CommandDialogBox    CommandParameter  5W      �� $ lbListaZadań��$ SelectedIndex��� 5X      $��Usuń zadanie��6   $
��Left=�5Y      $��Bottom=�6    $��
10,0,0,165q�5Z      $	��100��6   $��25��6%   #��[  5[      $F��@Czy jesteś pewien, że chcesz usunąć niezrealizowane zadanie?��5]      ��5\      �� $ questionYesNo��$
 Show�5]      �� 5^      $��Nowe zadanie��6   $��
10,0,10,10q�6#   $	��420��67   $	��140��6F   $��Bottom=�6S   .��5_      � .+�5`      �� $��Opis:��6   $��10,5,0,0q�6   $
��Left=�6.   $	��Top=�6I   �� 5a      -   5        ! ��Name$! tbOpis��5a      $��23��6   $��
10,30,10,0q�6*   $	��Top=�6>   �� 5b      $��
Priorytet:��6   $��	10,60,0,0q�6!   $
��Left=�64   $	��Top=�6O   �� 5c      -   5        " ��Name$" cbPriorytet��5c      $
��Left=�6$   $��	10,85,0,0q�6?   $	��Top=�6R   $	��120��6j   .@�5d      �� .��6   Mniej ważne6!   �� 5e      # �� 
IsSelected# . .��6&   Ważne6-   �� 5f      .��6   	Krytyczne6   5g      �� 5h      $��Termin realizacji:��6   $��
160,60,0,0q�6)   $
��Left=�6=   $	��Top=�6X     5i      -   5        $  Name$$ dpTerminRealizacji��5i      $��
160,85,0,0q�6-   $
��Left=�6A   $	��Top=�6\   
% �� Now&   SelectedDate#& Z% 6t   5j      &    ZadaniaWPF.NotificationDialogBox  5k      -   5        '  Name$' notificationDialogBox��5k   "   $ 
ZadaniaWPF��5l      (   CommandBefore( 6"   �� $ DodajZadanie�  5m      `� 5n      ) `� 	Converter#) [ 6   .1�5o   	   �� $ tbOpis��6   $
 Text�6&   �� 5p   	   $ dpTerminRealizacji��6   $ SelectedDate�62   �� 5q   	   $ cbPriorytet��6   $
 Text�6+   5r   	   5t      �� 5u      -   5        $��Dodaj zadanie��5u      $��
0,83,9.8,0q�5v      $��Right=�6   $	��Top=�67   $	��100��5w      $��25��6   #��[  5x      $��Zadanie zostało dodane��5y   H   ��6   �� $ notificationDialogBox��$
 Show�5{      5|      5}      �� 5~      $��Sortuj wg priorytetów��6   $
��Left=�6+   $��Bottom=�6F   $��120,0,0,165q�6a   $	��130��6v   $��25��6�   #��[  6�   $
��True��6�   ��6�   �� $ SortujZadania�6�   �� 5      $��Sortuj wg terminów��6   $
��Left=�6(   $��Bottom=�6C   $��260,0,0,165q�6^   $	��120��6s   $��25��6   #��[  6�   $��False��6�   ��6�   �� $ SortujZadania�6�   /   )ZadaniaWPF.FileSavedNotificationDialogBox  5�      -   5        *  Name$* saveConfirmation��5�      $ 
ZadaniaWPF��5�      ( 5�      �� *#!EksportujZadaniaDoPlikuTekstowego+  5�      �� $ saveFileDialogBox��$ FilePath�"   ZadaniaWPF.SaveFileDialogBox  5�      -	   5        +  Name$+ saveFileDialogBox��5�      $  Zapisz do pliku tekstowego��5�         ZadaniaWPF.FileDialogBox,   Filter$<, 6Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*��5�      -   FilterIndex$- 0��5�      .   
DefaultExt$	. txt��6   $��0,1,0,-1q�6%   /   CommandFileOk/ 5�      �� $ saveConfirmation��$
 Show��� 5�      $��Eksportuj...��5�      $��Right=�5�      $��Bottom=�6    $��
0,0,10,165q�5�      $��90��6   $��25��6#   #��[  5�      ��5�      �� *Show+$ saveFileDialogBox��5�      5�      