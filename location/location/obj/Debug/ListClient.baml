   M S B A M L   `   `   `  ����C  ?location, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:locationlocation  5      9!clr-namespace:location.Propertieslocation.Properties  5          location.ListClient   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:location     5      8
Properties!clr-namespace:location.Properties     5      $��983.423��5	      $��418.206��6/   .��5
      � -   5        $��MainContent2��5
      $��10,0,10.2,10.4q�6     � ColumnDefinitions  5   
   �� 5      �� 5      $��0* �6   .+�5   
   �� $��Liste des clients��6   $
��Left=�6,   $��
222,42,0,0q�6G   $	��Top=�6[   $	��204��6s   ���	#FFB63C3C$
��Bold"�6�   $��22(�6�   $��46��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtclient��5         AutoGenerateColumns .  $��31,153,128.2,67q�6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6=      Header$ Identifiant��6I   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *ID+6I     5      $	 100 6=   $	 Nom��6I    6%   �� *Nom+6I     5      $	 100 6A   $ Prénom��6M    6%   �� *Prenom+6M     5      $	 100 6H   $ Date Naissance��6T    6%   �� *Date_Naissance+6T     5      $	 100 6B   $ Adresse��6N    6%   �� *	Adresse+6N     5      $	 100 6G   $ Code Postal��6S    6%   �� *Code_Postale+6S     5      $	 100 6@   $ Ville��6L    6%   �� *Ville+6L   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5      ��  ��Name$ 	btnDelete��6%   -   5        $��Delete��5!   %   5"      5$      5'      �� 5(   
   $��Recherche by ID:��6   $
��Left=�6+   $��
31,105,0,0q�6F   $	��Top=�6Z   $��38��6r   $	��144��6~   $
��Bold"�6�   $��Italic$�6�   $��14(�6�   �� 5)   
   $
��Left=�6   $��38��6-   $��222,105,0,0q�69   	 �� TextWrapping$
	 Wrap=�6N   $	��Top=�6b   $	��169��6z   �� 5*   
   $
��Left=�6   $��469,105,0,0q�6/   $
��Wrap=�6D   $	��Top=�6Y   $��43��6q   $	��139��6}   $��18(�6�   �� 5+      -   5        $��UpdatClient.xaml?�5+      .�6P   .�5,      �� $��Mis à jour Client��6   $��30��65   $	��139��6A   5-      5.      �� 53   
   -   5        $
��Main��53      $��
24,33,0,10q�6%   $
��Left=�69   $	��930��6T   6b   55      56      