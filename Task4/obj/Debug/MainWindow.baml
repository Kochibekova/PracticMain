   M S B A M L   `   `   `  ????@  <Task4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Task4Task4  5   	       Task4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Task4     5   	     ? Title$  Task4??5   	   $	??450??6   $	??800??6$   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $
??206* ?6   ?? 5      $
??213* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??92* ?6   ?? 5      $
??111* ?6   ?? 5      $	??61* ?6   .+?5   
   ?? -   5         ??Name$ count??5      $??1??6    $
??Left=?6,   $??
10,111,0,0q?6G   $	??Top=?6[   $	??120??6s   $??30??6   6?   ?? 5   
   -   5         ??Name$ answer??5      $?? ??6    $
??Left=?6+   $??	10,63,0,0q?6F   $	??Top=?6Y   $??30??6q   $	??120??6}   ???	#FFFF93936?   ?? 5   
   -   5        $ answer1??5      $?? ??6!   $
??Left=?6,   $??
144,65,0,0q?6G   $	??Top=?6[   $??30??6s   $	??120??6   ???	#FFFF93936?   ?? 5   
   -   5         ??Name$ a??5      $
??Left=?6   $??23??68   $??	10,24,0,0q?6D    ?? TextWrapping$
 Wrap=?6W   $	??Top=?6k   $	??120??6?   ???	#FFFF93936?   ?? 5   
   -   5        $ b??5      $
??Left=?6   $??23??68   $??
144,24,0,0q?6D   $
 Wrap=?6X   $	??Top=?6l   $	??120??6?   ???	#FFFF93936?   ?? 5   
   $
??Left=?6   $??	22,10,0,0q?6/   $
??Wrap=?6B   $ ??Введите число ??6V   $	??Top=?6l   $??16??6?   $??83??6?   ?? 5   
   $
??Left=?6   $??
157,10,0,0q?6/   $
??Wrap=?6C   $ ??Введите число ??6W   $	??Top=?6m   $??16??6?   $??83??6?   ?? 5   
   -   5        $ z2??5      $??2??6   $
??Left=?6)   $??
25,111,0,0q?6D   $	??Top=?6X   $	??187??6p   $??30??6|   $??1??6?   ?? 5   
   -   5        $ k??5      $?? ??6   $
??Left=?6&   $??	25,47,0,0q?6A   $	??Top=?6T   $	??298??6l   ???	#FFD1F7CF$??1??6?   $??48??6?   ?? 5   
   -   5        $ z3??5      $??3??6   $
??Left=?6)   $??
10,143,0,0q?6D   $	??Top=?6X   $	??120??6p   $??32??6|   $??2??6?   ?? 5   
   -	   5        $ f??5      $?? ??6   $
??Left=?6&   $??	10,94,0,0q?6A   $	??Top=?6T   $??31??6l   $	??120??6x   ???	#FFECBEE1$??2??6?   ?? 5   
   -
   5        $	 za3??5      $
??Left=?6   $??31??6:   $??	10,42,0,0q?6F   $
 Wrap=?6Y   $	??Top=?6m   $	??120??6?   ???	#FFECBEE1$??2??6?   ?? 5   
   -   5        $ z4??5      $??4??6   $
??Left=?6)   $??	10,80,0,0q?6D   $	??Top=?6W   $	??110??6o   $??32??6{   $??1??6?   ?? 5    
   -   5        $	 age??5       $
??Left=?6   $??31??6:   $??	10,26,0,0q?6F   $
 Wrap=?6Y   $	??Top=?6m   $	??110??6?   ???	#FFA0F9FD$??1??6?   ?? 5!   
   -   5        $ n??5!      $?? ??6   $
??Left=?6&   $??
144,26,0,0q?6A   $	??Top=?6U   $??31??6m   $	??110??6y   ???	#FFA0F9FD$??1??6?   ?? 5"   
   -   5        $ z5??5"      $??5??6   $??1??6)   $
??Left=?69   $??
10,112,0,0q?6T   $??1??6h   $	??Top=?6u   $	??120??6?   $??32??6?   6?   ?? 5#   
   -   5        $ r??5#      $?? ??6   $??1??6&   $
??Left=?66   $??	10,76,0,0q?6Q   $??1??6d   $	??Top=?6q   $	??168??6?   $??31??6?   ???	#FFE6D8C46?   ?? 5$   
   -   5        $	 fuu??5$      $??1??6   $
??Left=?6/   $??31??6J   $??	10,23,0,0q?6V   $??1??6i   $
 Wrap=?6v   $	??Top=?6?   $	??168??6?   ???	#FFE6D8C46?   ?? 5%   
   $
??Left=?6   $??	22,47,0,0q?6/   $
??Wrap=?6B   $??Результат??6V   $	??Top=?6g   $??16??6   $??83??6?   ?? 5&   
   $
??Left=?6   $??	22,10,0,0q?6/   $
??Wrap=?6B   $ ??Введите число ??6V   $	??Top=?6l   $??16??6?   $??83??6?   $??1??6?   ?? 5'   
   $
??Left=?6   $??
157,10,0,0q?6/   $
??Wrap=?6C   $??Результат??6W   $	??Top=?6h   $??16??6?   $??83??6?   $??1??6?   ?? 5(   
   $
??Left=?6   $??25,3,0,0q?6/   $
??Wrap=?6A   $	??Top=?6U   $??1??6m   $??32??6}   $	??202??6?   ?? 6?   $?Выводит??6?   ?? 6?   $2?, квадраты чисел от 10 до 20??6?   ?? 6?   ?? 6?   $?включительно.??6?   6?   ?? 5)   
   $
??Left=?6   $??	10,24,0,0q?6/   $
??Wrap=?6B   $ ??Введите число ??6V   $	??Top=?6l   $??16??6?   $??83??6?   $??2??6?   ?? 5*   
   $
??Left=?6   $??10,2,0,0q?6/   $
??Wrap=?6A   $ ??Введите число ??6U   $	??Top=?6k   $??16??6?   $??83??6?   $??1??6?   $??1??6?   ?? 5+   
   $
??Left=?6   $??	10,55,0,0q?6/   $
??Wrap=?6B   $??Результат??6V   $	??Top=?6g   $??16??6   $??83??6?   $??1??6?   $??1??6?   ?? 5,   
   $
??Left=?6   $??	10,82,0,0q?6/   $
??Wrap=?6B   $??Результат??6V   $	??Top=?6g   $??16??6   $??83??6?   $??2??6?   5.      5/      